namespace Shopping_list_app
{
    partial class AddProductForm
    {
        
        
        
        
        / <summary>
        
            / Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addProdNameLbl = new Label();
            addQtyLbl = new Label();
            txtProductName = new TextBox();
            numQuantity = new NumericUpDown();
            btnAdd = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // addProdNameLbl
            // 
            addProdNameLbl.AutoSize = true;
            addProdNameLbl.Location = new Point(13, 16);
            addProdNameLbl.Margin = new Padding(4);
            addProdNameLbl.Name = "addProdNameLbl";
            addProdNameLbl.Size = new Size(104, 25);
            addProdNameLbl.TabIndex = 0;
            addProdNameLbl.Text = "Item Name:";
            // 
            // addQtyLbl
            // 
            addQtyLbl.AutoSize = true;
            addQtyLbl.Location = new Point(33, 54);
            addQtyLbl.Margin = new Padding(4);
            addQtyLbl.Name = "addQtyLbl";
            addQtyLbl.Size = new Size(84, 25);
            addQtyLbl.TabIndex = 1;
            addQtyLbl.Text = "Quantity:";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(125, 13);
            txtProductName.Margin = new Padding(4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(236, 31);
            txtProductName.TabIndex = 2;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(125, 52);
            numQuantity.Margin = new Padding(4);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(58, 31);
            numQuantity.TabIndex = 3;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 107);
            btnAdd.Margin = new Padding(12, 4, 12, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Confirm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(241, 107);
            btnCancel.Margin = new Padding(12, 4, 12, 12);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddProductForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(374, 162);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(numQuantity);
            Controls.Add(txtProductName);
            Controls.Add(addQtyLbl);
            Controls.Add(addProdNameLbl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addProdNameLbl;
        private Label addQtyLbl;
        private TextBox txtProductName;
        private NumericUpDown numQuantity;
        private Button btnAdd;
        private Button btnCancel;
    }
}