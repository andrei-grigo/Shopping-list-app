using System.Media;

namespace Shopping_list_app
{
    public partial class SearchForm : Form
    {
        private ShoppingListForm ownerForm;
        private List<ShoppingItem> searchResults = new List<ShoppingItem>();
        private int currentResultIndex = -1;

        public SearchForm()
        {
            InitializeComponent();
            this.TopMost = true;
            this.MinimizeBox = true;
            txtSearch.Focus();
        }

        public void SetOwner(ShoppingListForm form)
        {
            ownerForm = form;
        }

        public void SetSearchOptions(bool searchToBuy, bool searchBought)
        {
            chkSearchToBuy.Checked = searchToBuy;
            chkSearchBought.Checked = searchBought;
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchTerm))
            {
                lblResults.Text = "Results: No search performed.";
                return;
            }

            ShoppingItem previousItem = null;
            if (searchResults.Count > 0 && currentResultIndex >= 0 && currentResultIndex < searchResults.Count)
            {
                previousItem = searchResults[currentResultIndex];
            }

            searchResults.Clear();
            currentResultIndex = -1;

            int toBuyResults = 0;
            int boughtResults = 0;

            if (chkSearchToBuy.Checked)
            {
                foreach (var item in ownerForm.shoppingListManager.ToBuyList)
                {
                    if (item.Name.ToLower().Contains(searchTerm))
                    {
                        searchResults.Add(item);
                        toBuyResults++;
                    }
                }
            }

            if (chkSearchBought.Checked)
            {
                foreach (var item in ownerForm.shoppingListManager.BoughtList)
                {
                    if (item.Name.ToLower().Contains(searchTerm))
                    {
                        searchResults.Add(item);
                        boughtResults++;
                    }
                }
            }

            if (searchResults.Count == 0)
            {
                lblResults.Text = "Results: No items found.";
                SystemSounds.Exclamation.Play();
                FlashWindow();
                return;
            }

            lblResults.Text = $"Results: {toBuyResults} to buy, {boughtResults} bought";

            if (previousItem != null && searchResults.Contains(previousItem))
            {
                currentResultIndex = searchResults.IndexOf(previousItem);
            }
            else
            {
                currentResultIndex = -1;
            }

            HighlightNextResult();
        }

        private void HighlightNextResult()
        {
            if (searchResults.Count == 0) return;

            currentResultIndex = (currentResultIndex + 1) % searchResults.Count;
            ShoppingItem item = searchResults[currentResultIndex];

            bool isToBuyItem = ownerForm.shoppingListManager.ToBuyList.Contains(item);
            DataGridView targetGrid = isToBuyItem ? ownerForm.dataGridViewBuy : ownerForm.dataGridViewBought;
            TabPage targetTab = isToBuyItem ? ownerForm.ToBuy : ownerForm.Bought;

            ownerForm.tabControl1.SelectedTab = targetTab;

            string columnName = isToBuyItem ? "colName" : "colNameBought";
            foreach (DataGridViewRow row in targetGrid.Rows)
            {
                if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString().Equals(item.Name, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    targetGrid.FirstDisplayedScrollingRowIndex = row.Index;

                    int capturedIndex = currentResultIndex;
                    Task.Delay(1000).ContinueWith(_ =>
                    {
                        if (searchResults.Count > 0 && capturedIndex >= 0 && capturedIndex < searchResults.Count && searchResults[capturedIndex] == item)
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());

                    this.BeginInvoke(new Action(() => this.Activate()));
                    return;
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (searchResults.Count == 0) return;

            currentResultIndex = (currentResultIndex - 1 + searchResults.Count) % searchResults.Count;
            HighlightPreviousResult();
        }

        private void HighlightPreviousResult()
        {
            if (searchResults.Count == 0) return;

            ShoppingItem item = searchResults[currentResultIndex];

            bool isToBuyItem = ownerForm.shoppingListManager.ToBuyList.Contains(item);
            DataGridView targetGrid = isToBuyItem ? ownerForm.dataGridViewBuy : ownerForm.dataGridViewBought;
            TabPage targetTab = isToBuyItem ? ownerForm.ToBuy : ownerForm.Bought;

            ownerForm.tabControl1.SelectedTab = targetTab;

            string columnName = isToBuyItem ? "colName" : "colNameBought";
            foreach (DataGridViewRow row in targetGrid.Rows)
            {
                if (row.Cells[columnName].Value != null && row.Cells[columnName].Value.ToString().Equals(item.Name, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                    targetGrid.FirstDisplayedScrollingRowIndex = row.Index;

                    int capturedIndex = currentResultIndex;
                    Task.Delay(1000).ContinueWith(_ =>
                    {
                        if (searchResults.Count > 0 && capturedIndex >= 0 && capturedIndex < searchResults.Count && searchResults[capturedIndex] == item)
                        {
                            row.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                        }
                    }, TaskScheduler.FromCurrentSynchronizationContext());

                    this.BeginInvoke(new Action(() => this.Activate()));
                    return;
                }
            }
        }

        private void FlashWindow()
        {
            for (int i = 0; i < 3; i++)
            {
                this.Opacity = 0.5;
                Task.Delay(100).Wait();
                this.Opacity = 1;
                Task.Delay(100).Wait();
            }
        }

        private void chkSearchBought_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSearchToBuy.Checked && !chkSearchBought.Checked)
            {
                chkSearchBought.Checked = true;
            }
        }

        private void chkSearchToBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSearchToBuy.Checked && !chkSearchBought.Checked)
            {
                chkSearchToBuy.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}