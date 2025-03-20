using Shopping_list_app;

namespace Shopping_list_app
{
    partial class ShoppingListForm
    {
        /// <summary>

        // Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingListForm));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            ToBuy = new TabPage();
            dataGridViewBuy = new DataGridView();
            colSelect = new DataGridViewCheckBoxColumn();
            colIndex = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colBuy = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            searchBtnBuy = new Button();
            boughtBtn = new Button();
            delItemBtn = new Button();
            addItemBtn = new Button();
            tabControl1 = new TabControl();
            Bought = new TabPage();
            dataGridViewBought = new DataGridView();
            colSelectBought = new DataGridViewCheckBoxColumn();
            colIndexBought = new DataGridViewTextBoxColumn();
            colNameBought = new DataGridViewTextBoxColumn();
            colQuantityBought = new DataGridViewTextBoxColumn();
            colBuyBought = new DataGridViewButtonColumn();
            colDeleteBought = new DataGridViewButtonColumn();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            searchBtnBought = new Button();
            moveBoughtBackBtn = new Button();
            delBoughtBtn = new Button();
            addBoughtBtn = new Button();
            imageList1 = new ImageList(components);
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            toolTip1 = new ToolTip(components);
            ToBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuy).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            Bought.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBought).BeginInit();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // ToBuy
            // 
            ToBuy.Controls.Add(dataGridViewBuy);
            ToBuy.Controls.Add(groupBox1);
            ToBuy.Font = new Font("Segoe UI", 9F);
            ToBuy.ForeColor = SystemColors.ControlText;
            ToBuy.ImageIndex = 0;
            ToBuy.Location = new Point(4, 35);
            ToBuy.Margin = new Padding(0);
            ToBuy.Name = "ToBuy";
            ToBuy.Size = new Size(812, 805);
            ToBuy.TabIndex = 1;
            ToBuy.Text = "To Buy";
            ToBuy.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBuy
            // 
            dataGridViewBuy.AllowUserToAddRows = false;
            dataGridViewBuy.AllowUserToDeleteRows = false;
            dataGridViewBuy.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridViewBuy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBuy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuy.Columns.AddRange(new DataGridViewColumn[] { colSelect, colIndex, colName, colQuantity, colBuy, colDelete });
            dataGridViewBuy.Dock = DockStyle.Fill;
            dataGridViewBuy.Location = new Point(0, 0);
            dataGridViewBuy.Name = "dataGridViewBuy";
            dataGridViewBuy.RowHeadersVisible = false;
            dataGridViewBuy.RowHeadersWidth = 62;
            dataGridViewBuy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBuy.Size = new Size(812, 729);
            dataGridViewBuy.TabIndex = 12;
            // 
            // colSelect
            // 
            colSelect.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSelect.DataPropertyName = "Select";
            colSelect.HeaderText = "Select";
            colSelect.MinimumWidth = 8;
            colSelect.Name = "colSelect";
            colSelect.Resizable = DataGridViewTriState.False;
            colSelect.Width = 64;
            // 
            // colIndex
            // 
            colIndex.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colIndex.HeaderText = "#";
            colIndex.MinimumWidth = 8;
            colIndex.Name = "colIndex";
            colIndex.Resizable = DataGridViewTriState.False;
            colIndex.Width = 59;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.DataPropertyName = "Name";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            colName.DefaultCellStyle = dataGridViewCellStyle2;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            // 
            // colQuantity
            // 
            colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 8;
            colQuantity.Name = "colQuantity";
            colQuantity.Resizable = DataGridViewTriState.True;
            colQuantity.Width = 116;
            // 
            // colBuy
            // 
            colBuy.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colBuy.HeaderText = "Buy?";
            colBuy.MinimumWidth = 8;
            colBuy.Name = "colBuy";
            colBuy.Resizable = DataGridViewTriState.False;
            colBuy.Text = "";
            colBuy.Width = 55;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colDelete.HeaderText = "Delete";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.Resizable = DataGridViewTriState.False;
            colDelete.Width = 68;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 729);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8, 4, 8, 8);
            groupBox1.Size = new Size(812, 76);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "To Buy List Controls";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 196F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 196F));
            tableLayoutPanel1.Controls.Add(searchBtnBuy, 3, 0);
            tableLayoutPanel1.Controls.Add(boughtBtn, 2, 0);
            tableLayoutPanel1.Controls.Add(delItemBtn, 1, 0);
            tableLayoutPanel1.Controls.Add(addItemBtn, 0, 0);
            tableLayoutPanel1.Location = new Point(8, 28);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.Size = new Size(796, 40);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // searchBtnBuy
            // 
            searchBtnBuy.Anchor = AnchorStyles.Right;
            searchBtnBuy.Image = (Image)resources.GetObject("searchBtnBuy.Image");
            searchBtnBuy.Location = new Point(606, 0);
            searchBtnBuy.Margin = new Padding(0);
            searchBtnBuy.MaximumSize = new Size(190, 40);
            searchBtnBuy.MinimumSize = new Size(190, 40);
            searchBtnBuy.Name = "searchBtnBuy";
            searchBtnBuy.Padding = new Padding(4, 0, 0, 0);
            searchBtnBuy.Size = new Size(190, 40);
            searchBtnBuy.TabIndex = 8;
            searchBtnBuy.Text = "Search";
            searchBtnBuy.TextAlign = ContentAlignment.MiddleRight;
            searchBtnBuy.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(searchBtnBuy, "Search for products in the list");
            searchBtnBuy.UseVisualStyleBackColor = true;
            searchBtnBuy.Click += searchBtnBuy_Click;
            // 
            // boughtBtn
            // 
            boughtBtn.Anchor = AnchorStyles.None;
            boughtBtn.Image = (Image)resources.GetObject("boughtBtn.Image");
            boughtBtn.Location = new Point(404, 0);
            boughtBtn.Margin = new Padding(0);
            boughtBtn.MaximumSize = new Size(190, 40);
            boughtBtn.MinimumSize = new Size(190, 40);
            boughtBtn.Name = "boughtBtn";
            boughtBtn.Padding = new Padding(4, 0, 0, 0);
            boughtBtn.Size = new Size(190, 40);
            boughtBtn.TabIndex = 7;
            boughtBtn.Text = "Check as Bought";
            boughtBtn.TextAlign = ContentAlignment.MiddleRight;
            boughtBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(boughtBtn, "Click to check selected items as bought");
            boughtBtn.UseVisualStyleBackColor = true;
            boughtBtn.Click += boughtBtn_Click;
            // 
            // delItemBtn
            // 
            delItemBtn.Anchor = AnchorStyles.None;
            delItemBtn.Image = (Image)resources.GetObject("delItemBtn.Image");
            delItemBtn.Location = new Point(202, 0);
            delItemBtn.Margin = new Padding(0);
            delItemBtn.MaximumSize = new Size(190, 40);
            delItemBtn.MinimumSize = new Size(190, 40);
            delItemBtn.Name = "delItemBtn";
            delItemBtn.Padding = new Padding(4, 0, 0, 0);
            delItemBtn.Size = new Size(190, 40);
            delItemBtn.TabIndex = 6;
            delItemBtn.Text = "Delete";
            delItemBtn.TextAlign = ContentAlignment.MiddleRight;
            delItemBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(delItemBtn, "Click to delete selected items");
            delItemBtn.UseVisualStyleBackColor = true;
            delItemBtn.Click += delItemBtn_Click;
            // 
            // addItemBtn
            // 
            addItemBtn.Anchor = AnchorStyles.Left;
            addItemBtn.Image = (Image)resources.GetObject("addItemBtn.Image");
            addItemBtn.Location = new Point(0, 0);
            addItemBtn.Margin = new Padding(0);
            addItemBtn.MaximumSize = new Size(190, 40);
            addItemBtn.MinimumSize = new Size(190, 40);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Padding = new Padding(4, 0, 0, 0);
            addItemBtn.Size = new Size(190, 40);
            addItemBtn.TabIndex = 2;
            addItemBtn.Text = "Add a Product";
            addItemBtn.TextAlign = ContentAlignment.MiddleRight;
            addItemBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(addItemBtn, "Click to add a product to the 'To Buy' list");
            addItemBtn.UseVisualStyleBackColor = true;
            addItemBtn.Click += addItemBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ToBuy);
            tabControl1.Controls.Add(Bought);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ImageList = imageList1;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(820, 844);
            tabControl1.SizeMode = TabSizeMode.FillToRight;
            tabControl1.TabIndex = 11;
            // 
            // Bought
            // 
            Bought.Controls.Add(dataGridViewBought);
            Bought.Controls.Add(groupBox2);
            Bought.ImageIndex = 1;
            Bought.Location = new Point(4, 35);
            Bought.Margin = new Padding(0);
            Bought.Name = "Bought";
            Bought.Size = new Size(812, 805);
            Bought.TabIndex = 2;
            Bought.Text = "Bought";
            Bought.UseVisualStyleBackColor = true;
            // 
            // dataGridViewBought
            // 
            dataGridViewBought.AllowUserToAddRows = false;
            dataGridViewBought.AllowUserToDeleteRows = false;
            dataGridViewBought.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewBought.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewBought.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBought.Columns.AddRange(new DataGridViewColumn[] { colSelectBought, colIndexBought, colNameBought, colQuantityBought, colBuyBought, colDeleteBought });
            dataGridViewBought.Dock = DockStyle.Fill;
            dataGridViewBought.Location = new Point(0, 0);
            dataGridViewBought.Name = "dataGridViewBought";
            dataGridViewBought.RowHeadersVisible = false;
            dataGridViewBought.RowHeadersWidth = 62;
            dataGridViewBought.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBought.Size = new Size(812, 729);
            dataGridViewBought.TabIndex = 14;
            // 
            // colSelectBought
            // 
            colSelectBought.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colSelectBought.DataPropertyName = "Select";
            colSelectBought.HeaderText = "Select";
            colSelectBought.MinimumWidth = 8;
            colSelectBought.Name = "colSelectBought";
            colSelectBought.Resizable = DataGridViewTriState.False;
            colSelectBought.Width = 64;
            // 
            // colIndexBought
            // 
            colIndexBought.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colIndexBought.HeaderText = "#";
            colIndexBought.MinimumWidth = 8;
            colIndexBought.Name = "colIndexBought";
            colIndexBought.Resizable = DataGridViewTriState.False;
            colIndexBought.Width = 59;
            // 
            // colNameBought
            // 
            colNameBought.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNameBought.DataPropertyName = "Name";
            colNameBought.HeaderText = "Name";
            colNameBought.MinimumWidth = 8;
            colNameBought.Name = "colNameBought";
            // 
            // colQuantityBought
            // 
            colQuantityBought.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colQuantityBought.DataPropertyName = "Quantity";
            colQuantityBought.HeaderText = "Quantity";
            colQuantityBought.MinimumWidth = 8;
            colQuantityBought.Name = "colQuantityBought";
            colQuantityBought.Resizable = DataGridViewTriState.True;
            colQuantityBought.Width = 116;
            // 
            // colBuyBought
            // 
            colBuyBought.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colBuyBought.HeaderText = "Return?";
            colBuyBought.MinimumWidth = 8;
            colBuyBought.Name = "colBuyBought";
            colBuyBought.Resizable = DataGridViewTriState.False;
            colBuyBought.Text = "↺";
            colBuyBought.UseColumnTextForButtonValue = true;
            colBuyBought.Width = 77;
            // 
            // colDeleteBought
            // 
            colDeleteBought.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colDeleteBought.HeaderText = "Delete";
            colDeleteBought.MinimumWidth = 8;
            colDeleteBought.Name = "colDeleteBought";
            colDeleteBought.Resizable = DataGridViewTriState.False;
            colDeleteBought.Width = 68;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableLayoutPanel3);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 729);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(8, 4, 8, 8);
            groupBox2.Size = new Size(812, 76);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bought List Controls";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top;
            tableLayoutPanel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 196F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 196F));
            tableLayoutPanel3.Controls.Add(searchBtnBought, 3, 0);
            tableLayoutPanel3.Controls.Add(moveBoughtBackBtn, 2, 0);
            tableLayoutPanel3.Controls.Add(delBoughtBtn, 1, 0);
            tableLayoutPanel3.Controls.Add(addBoughtBtn, 0, 0);
            tableLayoutPanel3.Location = new Point(8, 28);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel3.Size = new Size(796, 40);
            tableLayoutPanel3.TabIndex = 11;
            // 
            // searchBtnBought
            // 
            searchBtnBought.Anchor = AnchorStyles.Right;
            searchBtnBought.Image = (Image)resources.GetObject("searchBtnBought.Image");
            searchBtnBought.Location = new Point(606, 0);
            searchBtnBought.Margin = new Padding(0);
            searchBtnBought.MaximumSize = new Size(190, 40);
            searchBtnBought.MinimumSize = new Size(190, 40);
            searchBtnBought.Name = "searchBtnBought";
            searchBtnBought.Padding = new Padding(4, 0, 0, 0);
            searchBtnBought.Size = new Size(190, 40);
            searchBtnBought.TabIndex = 8;
            searchBtnBought.Text = "Search";
            searchBtnBought.TextAlign = ContentAlignment.MiddleRight;
            searchBtnBought.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(searchBtnBought, "Search for products in the list");
            searchBtnBought.UseVisualStyleBackColor = true;
            searchBtnBought.Click += searchBtnBought_Click;
            // 
            // moveBoughtBackBtn
            // 
            moveBoughtBackBtn.Anchor = AnchorStyles.None;
            moveBoughtBackBtn.Font = new Font("Segoe UI", 8.5F);
            moveBoughtBackBtn.Image = (Image)resources.GetObject("moveBoughtBackBtn.Image");
            moveBoughtBackBtn.Location = new Point(404, 0);
            moveBoughtBackBtn.Margin = new Padding(0);
            moveBoughtBackBtn.MaximumSize = new Size(190, 40);
            moveBoughtBackBtn.MinimumSize = new Size(190, 40);
            moveBoughtBackBtn.Name = "moveBoughtBackBtn";
            moveBoughtBackBtn.Size = new Size(190, 40);
            moveBoughtBackBtn.TabIndex = 7;
            moveBoughtBackBtn.Text = "Send Back to Buy";
            moveBoughtBackBtn.TextAlign = ContentAlignment.MiddleRight;
            moveBoughtBackBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(moveBoughtBackBtn, "Move a purchased item from the 'Bought' list back to the 'To Buy' list");
            moveBoughtBackBtn.UseVisualStyleBackColor = true;
            moveBoughtBackBtn.Click += moveBoughtBackBtn_Click;
            // 
            // delBoughtBtn
            // 
            delBoughtBtn.Anchor = AnchorStyles.None;
            delBoughtBtn.Image = (Image)resources.GetObject("delBoughtBtn.Image");
            delBoughtBtn.Location = new Point(202, 0);
            delBoughtBtn.Margin = new Padding(0);
            delBoughtBtn.MaximumSize = new Size(190, 40);
            delBoughtBtn.MinimumSize = new Size(190, 40);
            delBoughtBtn.Name = "delBoughtBtn";
            delBoughtBtn.Padding = new Padding(4, 0, 0, 0);
            delBoughtBtn.Size = new Size(190, 40);
            delBoughtBtn.TabIndex = 6;
            delBoughtBtn.Text = "Delete";
            delBoughtBtn.TextAlign = ContentAlignment.MiddleRight;
            delBoughtBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(delBoughtBtn, "Click to delete selected items");
            delBoughtBtn.UseVisualStyleBackColor = true;
            delBoughtBtn.Click += delBoughtBtn_Click;
            // 
            // addBoughtBtn
            // 
            addBoughtBtn.Anchor = AnchorStyles.Left;
            addBoughtBtn.Image = (Image)resources.GetObject("addBoughtBtn.Image");
            addBoughtBtn.Location = new Point(0, 0);
            addBoughtBtn.Margin = new Padding(0);
            addBoughtBtn.MaximumSize = new Size(190, 40);
            addBoughtBtn.MinimumSize = new Size(190, 40);
            addBoughtBtn.Name = "addBoughtBtn";
            addBoughtBtn.Padding = new Padding(4, 0, 0, 0);
            addBoughtBtn.Size = new Size(190, 40);
            addBoughtBtn.TabIndex = 2;
            addBoughtBtn.Text = "Add a Product";
            addBoughtBtn.TextAlign = ContentAlignment.MiddleRight;
            addBoughtBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(addBoughtBtn, "Click to add an already purchased item directly to the 'Bought' list");
            addBoughtBtn.UseVisualStyleBackColor = true;
            addBoughtBtn.Click += addBoughtBtn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cart.png");
            imageList1.Images.SetKeyName(1, "check.png");
            // 
            // dataGridViewButtonColumn3
            // 
            dataGridViewButtonColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewButtonColumn3.HeaderText = "Delete";
            dataGridViewButtonColumn3.MinimumWidth = 8;
            dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            dataGridViewButtonColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewButtonColumn3.Width = 150;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewButtonColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewButtonColumn2.HeaderText = "Edit";
            dataGridViewButtonColumn2.MinimumWidth = 8;
            dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            dataGridViewButtonColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewButtonColumn2.Width = 150;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewButtonColumn1.HeaderText = "Buy?";
            dataGridViewButtonColumn1.MinimumWidth = 8;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewButtonColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            dataGridViewTextBoxColumn2.MinimumWidth = 8;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            dataGridViewCheckBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCheckBoxColumn1.DataPropertyName = "Select";
            dataGridViewCheckBoxColumn1.HeaderText = "Select";
            dataGridViewCheckBoxColumn1.MinimumWidth = 8;
            dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            dataGridViewCheckBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // ShoppingListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 844);
            Controls.Add(tabControl1);
            MinimumSize = new Size(842, 400);
            Name = "ShoppingListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shopping List App";
            Load += ShoppingListForm_Load;
            ToBuy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuy).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            Bought.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBought).EndInit();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public TabControl tabControl1;
        public TabPage ToBuy;
        public TabPage Bought;
        public DataGridView dataGridViewBuy;
        public DataGridView dataGridViewBought;

        private TextBox textBox1;
        private Label label1;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button boughtBtn;
        private Button delItemBtn;
        private Button addItemBtn;
        private ImageList imageList1;
        private DataGridViewButtonColumn dataGridViewButtonColumn3;
        private DataGridViewButtonColumn dataGridViewButtonColumn2;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private Button searchBtnBuy;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button searchBtnBought;
        private Button moveBoughtBackBtn;
        private Button delBoughtBtn;
        private Button addBoughtBtn;
        private ToolTip toolTip1;
        private DataGridViewCheckBoxColumn colSelect;
        private DataGridViewTextBoxColumn colIndex;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewButtonColumn colBuy;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewCheckBoxColumn colSelectBought;
        private DataGridViewTextBoxColumn colIndexBought;
        private DataGridViewTextBoxColumn colNameBought;
        private DataGridViewTextBoxColumn colQuantityBought;
        private DataGridViewButtonColumn colBuyBought;
        private DataGridViewButtonColumn colDeleteBought;
    }
}