using Shopping_list_app;

namespace Shopping_list_app
{
    public partial class ShoppingListForm : Form
    {
        public ShoppingListManager shoppingListManager { get; private set; }

        public ShoppingListForm()
        {
            InitializeComponent();
            shoppingListManager = new ShoppingListManager();
        }

        private void ShoppingListForm_Load(object sender, EventArgs e)
        {
            dataGridViewBuy.AutoGenerateColumns = false;
            dataGridViewBuy.DataSource = shoppingListManager.ToBuyList;

            dataGridViewBought.AutoGenerateColumns = false;
            dataGridViewBought.DataSource = shoppingListManager.BoughtList;
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            using (AddProductForm addForm = new AddProductForm(this))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    shoppingListManager.AddItem(addForm.ProductName, addForm.ProductQuantity);
                }
            }
        }

        private void delItemBtn_Click(object sender, EventArgs e)
        {
            shoppingListManager.DeleteSelectedItems(shoppingListManager.ToBuyList);
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

        private SearchForm searchForm;

        public void OpenSearchWindow()
        {
            if (searchForm == null || searchForm.IsDisposed)
            {
                searchForm = new SearchForm();
                searchForm.SetOwner(this);
            }

            bool searchingToBuy = tabControl1.SelectedTab == ToBuy;
            bool searchingBought = tabControl1.SelectedTab == Bought;
            searchForm.SetSearchOptions(searchingToBuy, searchingBought);
            searchForm.Show();
            searchForm.BringToFront();
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
    }
}