using System;
using System.Windows.Forms;

namespace Shopping_list_app
{
    public partial class AddProductForm : Form
    {
        public string ProductName { get; private set; }
        public int ProductQuantity { get; private set; }

        private ShoppingListForm ownerForm;

        public AddProductForm(ShoppingListForm owner)
        {
            InitializeComponent();
            ownerForm = owner;

            numQuantity.Leave += numQuantity_Leave;
            numQuantity.KeyDown += numQuantity_KeyDown;

            btnCancel.Click += btnCancel_Click;

            btnAdd.Click += btnAdd_Click;
        }

        private void numQuantity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numQuantity.Text))
            {
                numQuantity.Value = 1;
            }
        }

        private void numQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newProductName = txtProductName.Text.Trim();
            int newProductQuantity = (int)numQuantity.Value;

            if (string.IsNullOrWhiteSpace(newProductName))
            {
                MessageBox.Show("Please enter a product name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }

            foreach (var item in ownerForm.shoppingListManager.ToBuyList)
            {
                if (string.Equals(item.Name, newProductName, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Item '{newProductName}' is already in the To Buy list with quantity {item.Quantity}.",
                        "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (var item in ownerForm.shoppingListManager.BoughtList)
            {
                if (string.Equals(item.Name, newProductName, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Item '{newProductName}' is already in the Bought list with quantity {item.Quantity}.",
                        "Duplicate Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            ProductName = newProductName;
            ProductQuantity = newProductQuantity;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
