using Shopping_list_app;

namespace Shopping_list_app
{
    partial class ShoppingListForm
    {
        /// <summary>
        ///  Required designer variable.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingListForm));
            ToBuy = new TabPage();
            dataGridViewBuy = new DataGridView();
            colSelect = new DataGridViewCheckBoxColumn();
            colIndex = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colBuy = new DataGridViewButtonColumn();
            colEdit = new DataGridViewButtonColumn();
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
            colEditBought = new DataGridViewButtonColumn();
            colDeleteBought = new DataGridViewButtonColumn();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            searchBtnBought = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            imageList1 = new ImageList(components);
            tableLayoutPanel2 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            dataGridViewButtonColumn3 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn2 = new DataGridViewButtonColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
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
            dataGridViewBuy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuy.Columns.AddRange(new DataGridViewColumn[] { colSelect, colIndex, colName, colQuantity, colBuy, colEdit, colDelete });
            dataGridViewBuy.Dock = DockStyle.Fill;
            dataGridViewBuy.Location = new Point(0, 0);
            dataGridViewBuy.Name = "dataGridViewBuy";
            dataGridViewBuy.RowHeadersVisible = false;
            dataGridViewBuy.RowHeadersWidth = 62;
            dataGridViewBuy.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBuy.Size = new Size(812, 729);
            dataGridViewBuy.TabIndex = 12;
            dataGridViewBuy.CellContentClick += dataGridViewBuy_CellContentClick;
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
            colIndex.Width = 59;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 8;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 8;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
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
            colBuy.Width = 55;
            // 
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colEdit.HeaderText = "Edit";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.Resizable = DataGridViewTriState.False;
            colEdit.Width = 48;
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
            tabControl1.SizeMode = TabSizeMode.Fixed;
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
            dataGridViewBought.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBought.Columns.AddRange(new DataGridViewColumn[] { colSelectBought, colIndexBought, colNameBought, colQuantityBought, colBuyBought, colEditBought, colDeleteBought });
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
            colIndexBought.Width = 59;
            // 
            // colNameBought
            // 
            colNameBought.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNameBought.DataPropertyName = "Name";
            colNameBought.HeaderText = "Name";
            colNameBought.MinimumWidth = 8;
            colNameBought.Name = "colNameBought";
            colNameBought.ReadOnly = true;
            // 
            // colQuantityBought
            // 
            colQuantityBought.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colQuantityBought.DataPropertyName = "Quantity";
            colQuantityBought.HeaderText = "Quantity";
            colQuantityBought.MinimumWidth = 8;
            colQuantityBought.Name = "colQuantityBought";
            colQuantityBought.ReadOnly = true;
            colQuantityBought.Resizable = DataGridViewTriState.True;
            colQuantityBought.Width = 116;
            // 
            // colBuyBought
            // 
            colBuyBought.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colBuyBought.HeaderText = "Buy?";
            colBuyBought.MinimumWidth = 8;
            colBuyBought.Name = "colBuyBought";
            colBuyBought.Resizable = DataGridViewTriState.False;
            colBuyBought.Width = 55;
            // 
            // colEditBought
            // 
            colEditBought.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colEditBought.HeaderText = "Edit";
            colEditBought.MinimumWidth = 8;
            colEditBought.Name = "colEditBought";
            colEditBought.Resizable = DataGridViewTriState.False;
            colEditBought.Width = 48;
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
            groupBox2.Text = "To Buy List Controls";
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
            tableLayoutPanel3.Controls.Add(button5, 2, 0);
            tableLayoutPanel3.Controls.Add(button6, 1, 0);
            tableLayoutPanel3.Controls.Add(button7, 0, 0);
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
            searchBtnBought.UseVisualStyleBackColor = true;
            searchBtnBought.Click += searchBtnBought_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(404, 0);
            button5.Margin = new Padding(0);
            button5.MaximumSize = new Size(190, 40);
            button5.MinimumSize = new Size(190, 40);
            button5.Name = "button5";
            button5.Padding = new Padding(4, 0, 0, 0);
            button5.Size = new Size(190, 40);
            button5.TabIndex = 7;
            button5.Text = "Check as Bought";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(202, 0);
            button6.Margin = new Padding(0);
            button6.MaximumSize = new Size(190, 40);
            button6.MinimumSize = new Size(190, 40);
            button6.Name = "button6";
            button6.Padding = new Padding(4, 0, 0, 0);
            button6.Size = new Size(190, 40);
            button6.TabIndex = 6;
            button6.Text = "Delete";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.TextImageRelation = TextImageRelation.ImageBeforeText;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Left;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(0, 0);
            button7.Margin = new Padding(0);
            button7.MaximumSize = new Size(190, 40);
            button7.MinimumSize = new Size(190, 40);
            button7.Name = "button7";
            button7.Padding = new Padding(4, 0, 0, 0);
            button7.Size = new Size(190, 40);
            button7.TabIndex = 2;
            button7.Text = "Add a Product";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.TextImageRelation = TextImageRelation.ImageBeforeText;
            button7.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cart.png");
            imageList1.Images.SetKeyName(1, "check.png");
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 196F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 196F));
            tableLayoutPanel2.Location = new Point(8, 28);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel2.Size = new Size(796, 40);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(0, 0);
            button4.Margin = new Padding(0);
            button4.MaximumSize = new Size(190, 40);
            button4.MinimumSize = new Size(190, 40);
            button4.Name = "button4";
            button4.Padding = new Padding(4, 0, 0, 0);
            button4.Size = new Size(190, 40);
            button4.TabIndex = 2;
            button4.Text = "Add a Product";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(202, 0);
            button3.Margin = new Padding(0);
            button3.MaximumSize = new Size(190, 40);
            button3.MinimumSize = new Size(190, 40);
            button3.Name = "button3";
            button3.Padding = new Padding(4, 0, 0, 0);
            button3.Size = new Size(190, 40);
            button3.TabIndex = 6;
            button3.Text = "Delete";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(404, 0);
            button2.Margin = new Padding(0);
            button2.MaximumSize = new Size(190, 40);
            button2.MinimumSize = new Size(190, 40);
            button2.Name = "button2";
            button2.Padding = new Padding(4, 0, 0, 0);
            button2.Size = new Size(190, 40);
            button2.TabIndex = 7;
            button2.Text = "Check as Bought";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
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
            MinimumSize = new Size(842, 0);
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
        private TableLayoutPanel tableLayoutPanel2;
        private Button button4;
        private Button button3;
        private Button button2;
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
        private Button button5;
        private Button button6;
        private Button button7;
        private DataGridViewCheckBoxColumn colSelect;
        private DataGridViewTextBoxColumn colIndex;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewButtonColumn colBuy;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewCheckBoxColumn colSelectBought;
        private DataGridViewTextBoxColumn colIndexBought;
        private DataGridViewTextBoxColumn colNameBought;
        private DataGridViewTextBoxColumn colQuantityBought;
        private DataGridViewButtonColumn colBuyBought;
        private DataGridViewButtonColumn colEditBought;
        private DataGridViewButtonColumn colDeleteBought;
    }
}