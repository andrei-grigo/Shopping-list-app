using Shopping_list_app;

namespace Shopping_list_app
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
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
        private System.Windows.Forms.CheckBox chkSearchToBuy;
        private System.Windows.Forms.CheckBox chkSearchBought;

        private void InitializeComponent()
        {
            lblSearch = new Label();
            txtSearch = new TextBox();
            chkSearchToBuy = new CheckBox();
            chkSearchBought = new CheckBox();
            lblResults = new Label();
            groupSearchBox1 = new GroupBox();
            btnSearch = new Button();
            btnPrevious = new Button();
            btnCancel = new Button();
            groupSearchBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(13, 16);
            lblSearch.Margin = new Padding(4);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 25);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(89, 13);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(296, 31);
            txtSearch.TabIndex = 1;
            // 
            // chkSearchToBuy
            // 
            chkSearchToBuy.AutoSize = true;
            chkSearchToBuy.Location = new Point(8, 32);
            chkSearchToBuy.Margin = new Padding(4);
            chkSearchToBuy.Name = "chkSearchToBuy";
            chkSearchToBuy.Size = new Size(166, 29);
            chkSearchToBuy.TabIndex = 2;
            chkSearchToBuy.Text = "Search in To Buy";
            chkSearchToBuy.UseVisualStyleBackColor = true;
            chkSearchToBuy.CheckedChanged += chkSearchToBuy_CheckedChanged;
            // 
            // chkSearchBought
            // 
            chkSearchBought.AutoSize = true;
            chkSearchBought.Location = new Point(8, 69);
            chkSearchBought.Margin = new Padding(4);
            chkSearchBought.Name = "chkSearchBought";
            chkSearchBought.Size = new Size(172, 29);
            chkSearchBought.TabIndex = 3;
            chkSearchBought.Text = "Search in Bought";
            chkSearchBought.UseVisualStyleBackColor = true;
            chkSearchBought.CheckedChanged += chkSearchBought_CheckedChanged;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(13, 166);
            lblResults.Margin = new Padding(4);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(86, 25);
            lblResults.TabIndex = 4;
            lblResults.Text = "Result(s): ";
            // 
            // groupSearchBox1
            // 
            groupSearchBox1.Controls.Add(chkSearchToBuy);
            groupSearchBox1.Controls.Add(chkSearchBought);
            groupSearchBox1.Location = new Point(13, 52);
            groupSearchBox1.Margin = new Padding(4);
            groupSearchBox1.Name = "groupSearchBox1";
            groupSearchBox1.Padding = new Padding(4);
            groupSearchBox1.Size = new Size(188, 106);
            groupSearchBox1.TabIndex = 5;
            groupSearchBox1.TabStop = false;
            groupSearchBox1.Text = "Search Controls";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(393, 13);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(393, 55);
            btnPrevious.Margin = new Padding(4);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(112, 34);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(393, 124);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SearchForm
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(518, 204);
            Controls.Add(btnCancel);
            Controls.Add(btnPrevious);
            Controls.Add(btnSearch);
            Controls.Add(groupSearchBox1);
            Controls.Add(lblResults);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Search";
            TopMost = true;
            groupSearchBox1.ResumeLayout(false);
            groupSearchBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblResults;
        private GroupBox groupSearchBox1;
        private Button btnSearch;
        private Button btnPrevious;
        private Button btnCancel;
    }
}