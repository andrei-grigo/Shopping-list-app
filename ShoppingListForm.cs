using Shopping_list_app;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Shopping_list_app
{
    public partial class ShoppingListForm : Form
    {
        private AddProductForm addForm = null;

        private SearchForm searchForm = null;

        public ShoppingListManager shoppingListManager { get; private set; }

        public ShoppingListForm()
        {
            InitializeComponent();
            shoppingListManager = new ShoppingListManager();
            dataGridViewBuy.RowPostPaint += UpdateRowIndexForBuyList;
            dataGridViewBought.RowPostPaint += UpdateRowIndexForBoughtList;

        }

        private void ShoppingListForm_Load(object sender, EventArgs e)
        {
            dataGridViewBuy.AutoGenerateColumns = false;
            dataGridViewBuy.DataSource = shoppingListManager.ToBuyList;
            dataGridViewBuy.CellContentClick += dataGridViewBuy_CellContentClick;
            dataGridViewBuy.CellFormatting += dataGridViewButtonColumn_CellFormatting;
            dataGridViewBuy.RowsAdded += (sender, e) => UpdateTabCounts();
            dataGridViewBuy.RowsRemoved += (sender, e) => UpdateTabCounts();

            dataGridViewBought.AutoGenerateColumns = false;
            dataGridViewBought.DataSource = shoppingListManager.BoughtList;
            dataGridViewBought.CellContentClick += dataGridViewBought_CellContentClick;
            dataGridViewBought.CellFormatting += dataGridViewButtonColumn_CellFormatting;
            dataGridViewBought.RowsAdded += (sender, e) => UpdateTabCounts();
            dataGridViewBought.RowsRemoved += (sender, e) => UpdateTabCounts();

            UpdateTabCounts();
        }

        private void dataGridViewButtonColumn_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (sender == dataGridViewBuy)
                {
                    if (dataGridViewBuy.Columns[e.ColumnIndex] == colBuy)
                    {
                        e.Value = "✔";
                        e.FormattingApplied = true;
                        dataGridViewBuy.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Click to check this item as bought";
                    }
                    else if (dataGridViewBuy.Columns[e.ColumnIndex] == colDelete)
                    {
                        e.Value = "🗑️";
                        e.FormattingApplied = true;
                        dataGridViewBuy.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Click to permanently delete this item";
                    }
                }
                else if (sender == dataGridViewBought)
                {
                    if (dataGridViewBought.Columns[e.ColumnIndex] == colBuyBought)
                    {
                        e.Value = "↺";
                        e.FormattingApplied = true;
                        dataGridViewBought.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Click to move this item back to the 'To Buy' list";
                    }
                    else if (dataGridViewBought.Columns[e.ColumnIndex] == colDeleteBought)
                    {
                        e.Value = "🗑️";
                        e.FormattingApplied = true;
                        dataGridViewBought.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = "Click to permanently delete this item";
                    }
                }
            }
        }

        private void UpdateTabCounts()
        {
            int toBuyCount = dataGridViewBuy.RowCount;
            int boughtCount = dataGridViewBought.RowCount;

            ToBuy.Text = $"To Buy ({toBuyCount})";
            Bought.Text = $"Bought ({boughtCount})";
        }

        private void UpdateRowIndexForBuyList(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            var rowIndex = e.RowIndex + 1;
            dgv.Rows[e.RowIndex].Cells["colIndex"].Value = rowIndex;
        }

        private void UpdateRowIndexForBoughtList(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var dgv = sender as DataGridView;
            var rowIndex = e.RowIndex + 1;
            dgv.Rows[e.RowIndex].Cells["colIndexBought"].Value = rowIndex;
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            if (addForm == null || addForm.IsDisposed)
            {
                addForm = new AddProductForm(this);
                addForm.StartPosition = FormStartPosition.Manual;

                addForm.Location = new Point(
                    this.Location.X + (this.Width - addForm.Width) / 2,
                    this.Location.Y + (this.Height - addForm.Height) / 2
                );

                addForm.FormClosed += (s, args) =>
                {
                    if (addForm.DialogResult == DialogResult.OK)
                    {
                        shoppingListManager.AddItem(addForm.ProductName, addForm.ProductQuantity);
                    }

                    addForm = null;
                };

                addForm.Show();
            }
            else
            {
                addForm.BringToFront();
                addForm.Activate();
            }
        }

        private void delItemBtn_Click(object sender, EventArgs e)
        {
            var selectedItems = dataGridViewBuy.Rows.Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["colSelect"].Value))
                .Select(row => row.DataBoundItem as ShoppingItem)
                .ToList();

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("No items selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemNames = string.Join(Environment.NewLine, selectedItems.Select(item => $"{item.Name} (Quantity: {item.Quantity})"));

            var result = MessageBox.Show($"Are you sure you want to delete the following item(s) from the 'To Buy' list?\n\n{itemNames}",
                "Delete Items", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                foreach (var item in selectedItems)
                {
                    shoppingListManager.DeleteSingleItem(item, showConfirmation: false);
                }
            }
        }
        private void boughtBtn_Click(object sender, EventArgs e)
        {
            shoppingListManager.MarkAsBought();
        }

        private void dataGridViewBuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridViewBuy.Columns[e.ColumnIndex].Name == "colBuy")
            {
                var item = shoppingListManager.ToBuyList[e.RowIndex];
                shoppingListManager.MarkSingleItemAsBought(item);
            }
            else if (dataGridViewBuy.Columns[e.ColumnIndex].Name == "colDelete")
            {
                var item = shoppingListManager.ToBuyList[e.RowIndex];
                shoppingListManager.DeleteSingleItem(item);
            }
        }

        public void OpenSearchWindow()
        {
            if (searchForm == null || searchForm.IsDisposed)
            {
                searchForm = new SearchForm();
                searchForm.SetOwner(this);
                searchForm.StartPosition = FormStartPosition.Manual;

                searchForm.Location = new Point(
                    this.Location.X + (this.Width - searchForm.Width) / 2,
                    this.Location.Y + (this.Height - searchForm.Height) / 2
                );

                bool searchingToBuy = tabControl1.SelectedTab == ToBuy;
                bool searchingBought = tabControl1.SelectedTab == Bought;
                searchForm.SetSearchOptions(searchingToBuy, searchingBought);

                searchForm.FormClosed += (s, args) =>
                {
                    searchForm = null;
                };

                searchForm.Show(this);
            }
            else
            {
                searchForm.BringToFront();
                searchForm.Activate();
            }
        }

        private void searchBtnBuy_Click(object sender, EventArgs e)
        {
            OpenSearchWindow();
        }

        private void searchBtnBought_Click(object sender, EventArgs e)
        {
            OpenSearchWindow();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                OpenSearchWindow();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void HighlightItem(ShoppingItem item)
        {
            DataGridView targetGrid = shoppingListManager.ToBuyList.Contains(item) ? dataGridViewBuy : dataGridViewBought;
            TabPage targetTab = shoppingListManager.ToBuyList.Contains(item) ? ToBuy : Bought;

            Task.Delay(200).ContinueWith(_ =>
            {
                tabControl1.SelectedTab = targetTab;
            }, TaskScheduler.FromCurrentSynchronizationContext());

            Task.Delay(400).ContinueWith(_ =>
            {
                foreach (DataGridViewRow row in targetGrid.Rows)
                {
                    if (row.DataBoundItem == item)
                    {
                        row.Selected = true;
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                        targetGrid.FirstDisplayedScrollingRowIndex = row.Index;
                        Task.Delay(1000).ContinueWith(__ => row.DefaultCellStyle.BackColor = System.Drawing.Color.White);
                        return;
                    }
                }
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void delBoughtBtn_Click(object sender, EventArgs e)
        {
            var selectedItems = dataGridViewBought.Rows.Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(row.Cells["colSelectBought"].Value))
                .Select(row => row.DataBoundItem as ShoppingItem)
                .ToList();

            if (selectedItems.Count == 0)
            {
                MessageBox.Show("No items selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemNames = string.Join(Environment.NewLine, selectedItems.Select(item => $"{item.Name} (Quantity: {item.Quantity})"));

            var result = MessageBox.Show($"Are you sure you want to delete the following item(s) from the 'Bought' list?\n\n{itemNames}",
                "Delete Items", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                foreach (var item in selectedItems)
                {
                    shoppingListManager.DeleteSingleItemBought(item, showConfirmation: false);
                }
            }
        }
        private void addBoughtBtn_Click(object sender, EventArgs e)
        {
            var addForm = new AddProductForm(this, isBought: true);
            addForm.StartPosition = FormStartPosition.Manual;

            addForm.Location = new Point(
                this.Location.X + (this.Width - addForm.Width) / 2,
                this.Location.Y + (this.Height - addForm.Height) / 2
            );

            addForm.FormClosed += (s, args) =>
            {
                if (addForm.DialogResult == DialogResult.OK)
                {
                }
            };

            addForm.Show();
        }

        private void moveBoughtBackBtn_Click(object sender, EventArgs e)
        {
            shoppingListManager.MoveBoughtBackToBuy();
            dataGridViewBuy.Refresh();
            dataGridViewBought.Refresh();
        }

        private void dataGridViewBought_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridViewBought.Columns[e.ColumnIndex].Name == "colBuyBought")
            {
                var item = shoppingListManager.BoughtList[e.RowIndex];
                shoppingListManager.MarkSingleItemAsToBuy(item);
            }
            else if (dataGridViewBought.Columns[e.ColumnIndex].Name == "colDeleteBought")
            {
                var item = shoppingListManager.BoughtList[e.RowIndex];
                shoppingListManager.DeleteSingleItemBought(item);
            }
        }
    }
}