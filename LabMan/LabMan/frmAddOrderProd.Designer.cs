namespace LabMan
{
    partial class frmAddOrderProd
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddOrderProd));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.frmPanel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblQuantityXPallet = new System.Windows.Forms.Label();
            this.lblWorkcenter = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.numQtyXPallet = new System.Windows.Forms.NumericUpDown();
            this.selWorkcenter = new System.Windows.Forms.ComboBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.selProduct = new System.Windows.Forms.ComboBox();
            this.frmPanel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPlannedDate = new System.Windows.Forms.Label();
            this.lblPlannedQty = new System.Windows.Forms.Label();
            this.lblPlant = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.numPlannedQty = new System.Windows.Forms.NumericUpDown();
            this.selPlant = new System.Windows.Forms.ComboBox();
            this.dpPlannedDate = new System.Windows.Forms.DateTimePicker();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.tPLANTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uBSLABMN_MXDataSet1 = new LabMan.UBSLABMN_MXDataSet1();
            this.tPLANTTableAdapter = new LabMan.UBSLABMN_MXDataSet1TableAdapters.TPLANTTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.frmPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtyXPallet)).BeginInit();
            this.frmPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlannedQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPLANTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnBack.BackgroundImage = global::LabMan.Properties.Resources.left_arrow;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(991, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 20);
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.34463F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.65537F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.2069F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.7931F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(354, 54);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LabMan.Properties.Resources.btnOrderProduction;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(205, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblFormTitle, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Inch);
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1024, 591);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.frmPanel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.frmPanel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(259, 91);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 407F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(506, 407);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // frmPanel2
            // 
            this.frmPanel2.BackColor = System.Drawing.Color.Transparent;
            this.frmPanel2.Controls.Add(this.pictureBox8);
            this.frmPanel2.Controls.Add(this.pictureBox7);
            this.frmPanel2.Controls.Add(this.pictureBox6);
            this.frmPanel2.Controls.Add(this.lblQuantityXPallet);
            this.frmPanel2.Controls.Add(this.lblWorkcenter);
            this.frmPanel2.Controls.Add(this.lblProduct);
            this.frmPanel2.Controls.Add(this.numQtyXPallet);
            this.frmPanel2.Controls.Add(this.selWorkcenter);
            this.frmPanel2.Controls.Add(this.btnAddOrder);
            this.frmPanel2.Controls.Add(this.selProduct);
            this.frmPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmPanel2.Location = new System.Drawing.Point(256, 3);
            this.frmPanel2.Name = "frmPanel2";
            this.frmPanel2.Size = new System.Drawing.Size(247, 401);
            this.frmPanel2.TabIndex = 1;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(19, 199);
            this.pictureBox8.MaximumSize = new System.Drawing.Size(20, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(20, 12);
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(19, 120);
            this.pictureBox7.MaximumSize = new System.Drawing.Size(20, 10);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 10);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(19, 44);
            this.pictureBox6.MaximumSize = new System.Drawing.Size(20, 10);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 10);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // lblQuantityXPallet
            // 
            this.lblQuantityXPallet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantityXPallet.AutoSize = true;
            this.lblQuantityXPallet.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblQuantityXPallet.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuantityXPallet.Location = new System.Drawing.Point(44, 172);
            this.lblQuantityXPallet.MaximumSize = new System.Drawing.Size(148, 18);
            this.lblQuantityXPallet.Name = "lblQuantityXPallet";
            this.lblQuantityXPallet.Size = new System.Drawing.Size(125, 18);
            this.lblQuantityXPallet.TabIndex = 0;
            this.lblQuantityXPallet.Text = "Cantidad por pallet";
            // 
            // lblWorkcenter
            // 
            this.lblWorkcenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorkcenter.AutoSize = true;
            this.lblWorkcenter.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblWorkcenter.ForeColor = System.Drawing.Color.DimGray;
            this.lblWorkcenter.Location = new System.Drawing.Point(44, 91);
            this.lblWorkcenter.MaximumSize = new System.Drawing.Size(118, 18);
            this.lblWorkcenter.Name = "lblWorkcenter";
            this.lblWorkcenter.Size = new System.Drawing.Size(40, 18);
            this.lblWorkcenter.TabIndex = 0;
            this.lblWorkcenter.Text = "Línea";
            // 
            // lblProduct
            // 
            this.lblProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblProduct.ForeColor = System.Drawing.Color.DimGray;
            this.lblProduct.Location = new System.Drawing.Point(44, 15);
            this.lblProduct.MaximumSize = new System.Drawing.Size(118, 18);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(64, 18);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Producto";
            // 
            // numQtyXPallet
            // 
            this.numQtyXPallet.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.numQtyXPallet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numQtyXPallet.BackColor = System.Drawing.SystemColors.Menu;
            this.numQtyXPallet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numQtyXPallet.Font = new System.Drawing.Font("Calibri", 11F);
            this.numQtyXPallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.numQtyXPallet.InterceptArrowKeys = false;
            this.numQtyXPallet.Location = new System.Drawing.Point(47, 195);
            this.numQtyXPallet.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.numQtyXPallet.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numQtyXPallet.MaximumSize = new System.Drawing.Size(100, 0);
            this.numQtyXPallet.Name = "numQtyXPallet";
            this.numQtyXPallet.Size = new System.Drawing.Size(49, 21);
            this.numQtyXPallet.TabIndex = 5;
            this.numQtyXPallet.TabStop = false;
            this.numQtyXPallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQtyXPallet.ThousandsSeparator = true;
            // 
            // selWorkcenter
            // 
            this.selWorkcenter.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.selWorkcenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selWorkcenter.BackColor = System.Drawing.SystemColors.Menu;
            this.selWorkcenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selWorkcenter.Font = new System.Drawing.Font("Calibri", 11F);
            this.selWorkcenter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.selWorkcenter.FormattingEnabled = true;
            this.selWorkcenter.Location = new System.Drawing.Point(47, 112);
            this.selWorkcenter.MaximumSize = new System.Drawing.Size(300, 0);
            this.selWorkcenter.Name = "selWorkcenter";
            this.selWorkcenter.Size = new System.Drawing.Size(161, 26);
            this.selWorkcenter.TabIndex = 3;
            this.selWorkcenter.TabStop = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.AccessibleName = "Orden de produccion";
            this.btnAddOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnAddOrder.BackgroundImage = global::LabMan.Properties.Resources.btnAcceptPress;
            this.btnAddOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrder.Enabled = false;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddOrder.Location = new System.Drawing.Point(47, 270);
            this.btnAddOrder.MaximumSize = new System.Drawing.Size(151, 28);
            this.btnAddOrder.MinimumSize = new System.Drawing.Size(151, 28);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(151, 28);
            this.btnAddOrder.TabIndex = 7;
            this.btnAddOrder.TabStop = false;
            this.btnAddOrder.Text = "Agregar";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // selProduct
            // 
            this.selProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.selProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selProduct.BackColor = System.Drawing.SystemColors.Menu;
            this.selProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selProduct.Font = new System.Drawing.Font("Calibri", 11F);
            this.selProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.selProduct.FormattingEnabled = true;
            this.selProduct.Location = new System.Drawing.Point(47, 36);
            this.selProduct.MaximumSize = new System.Drawing.Size(300, 0);
            this.selProduct.Name = "selProduct";
            this.selProduct.Size = new System.Drawing.Size(161, 26);
            this.selProduct.TabIndex = 1;
            this.selProduct.TabStop = false;
            // 
            // frmPanel1
            // 
            this.frmPanel1.BackColor = System.Drawing.Color.Transparent;
            this.frmPanel1.Controls.Add(this.pictureBox5);
            this.frmPanel1.Controls.Add(this.pictureBox4);
            this.frmPanel1.Controls.Add(this.pictureBox3);
            this.frmPanel1.Controls.Add(this.pictureBox1);
            this.frmPanel1.Controls.Add(this.lblPlannedDate);
            this.frmPanel1.Controls.Add(this.lblPlannedQty);
            this.frmPanel1.Controls.Add(this.lblPlant);
            this.frmPanel1.Controls.Add(this.lblOrderNumber);
            this.frmPanel1.Controls.Add(this.numPlannedQty);
            this.frmPanel1.Controls.Add(this.selPlant);
            this.frmPanel1.Controls.Add(this.dpPlannedDate);
            this.frmPanel1.Controls.Add(this.txtOrderNumber);
            this.frmPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmPanel1.Location = new System.Drawing.Point(3, 3);
            this.frmPanel1.Name = "frmPanel1";
            this.frmPanel1.Size = new System.Drawing.Size(247, 401);
            this.frmPanel1.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::LabMan.Properties.Resources.iconCalendar;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(21, 273);
            this.pictureBox5.MaximumSize = new System.Drawing.Size(20, 17);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 17);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(21, 199);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(20, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 12);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(21, 119);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(20, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 10);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::LabMan.Properties.Resources.iconText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(21, 38);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 12);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblPlannedDate
            // 
            this.lblPlannedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlannedDate.AutoSize = true;
            this.lblPlannedDate.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblPlannedDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlannedDate.Location = new System.Drawing.Point(44, 249);
            this.lblPlannedDate.MaximumSize = new System.Drawing.Size(118, 18);
            this.lblPlannedDate.Name = "lblPlannedDate";
            this.lblPlannedDate.Size = new System.Drawing.Size(104, 18);
            this.lblPlannedDate.TabIndex = 0;
            this.lblPlannedDate.Text = "Fecha planeada";
            // 
            // lblPlannedQty
            // 
            this.lblPlannedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlannedQty.AutoSize = true;
            this.lblPlannedQty.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblPlannedQty.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlannedQty.Location = new System.Drawing.Point(44, 172);
            this.lblPlannedQty.MaximumSize = new System.Drawing.Size(140, 18);
            this.lblPlannedQty.Name = "lblPlannedQty";
            this.lblPlannedQty.Size = new System.Drawing.Size(122, 18);
            this.lblPlannedQty.TabIndex = 0;
            this.lblPlannedQty.Text = "Cantidad planeada";
            // 
            // lblPlant
            // 
            this.lblPlant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPlant.AutoSize = true;
            this.lblPlant.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblPlant.ForeColor = System.Drawing.Color.DimGray;
            this.lblPlant.Location = new System.Drawing.Point(44, 91);
            this.lblPlant.MaximumSize = new System.Drawing.Size(118, 18);
            this.lblPlant.Name = "lblPlant";
            this.lblPlant.Size = new System.Drawing.Size(47, 18);
            this.lblPlant.TabIndex = 0;
            this.lblPlant.Text = "Planta";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.Font = new System.Drawing.Font("Calibri", 11F);
            this.lblOrderNumber.ForeColor = System.Drawing.Color.DimGray;
            this.lblOrderNumber.Location = new System.Drawing.Point(44, 13);
            this.lblOrderNumber.MaximumSize = new System.Drawing.Size(118, 18);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(118, 18);
            this.lblOrderNumber.TabIndex = 0;
            this.lblOrderNumber.Text = "Número de órden";
            // 
            // numPlannedQty
            // 
            this.numPlannedQty.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.numPlannedQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numPlannedQty.BackColor = System.Drawing.SystemColors.Menu;
            this.numPlannedQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPlannedQty.Font = new System.Drawing.Font("Calibri", 11F);
            this.numPlannedQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.numPlannedQty.InterceptArrowKeys = false;
            this.numPlannedQty.Location = new System.Drawing.Point(47, 195);
            this.numPlannedQty.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.numPlannedQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPlannedQty.MaximumSize = new System.Drawing.Size(100, 0);
            this.numPlannedQty.Name = "numPlannedQty";
            this.numPlannedQty.Size = new System.Drawing.Size(49, 21);
            this.numPlannedQty.TabIndex = 4;
            this.numPlannedQty.TabStop = false;
            this.numPlannedQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPlannedQty.ThousandsSeparator = true;
            // 
            // selPlant
            // 
            this.selPlant.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.selPlant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.selPlant.BackColor = System.Drawing.SystemColors.Menu;
            this.selPlant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selPlant.Font = new System.Drawing.Font("Calibri", 11F);
            this.selPlant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.selPlant.FormattingEnabled = true;
            this.selPlant.Location = new System.Drawing.Point(47, 112);
            this.selPlant.MaximumSize = new System.Drawing.Size(300, 0);
            this.selPlant.Name = "selPlant";
            this.selPlant.Size = new System.Drawing.Size(161, 26);
            this.selPlant.TabIndex = 2;
            this.selPlant.TabStop = false;
            this.selPlant.Click += new System.EventHandler(this.selProduct_SelectedIndexChanged);
            this.selPlant.SelectedIndexChanged += new System.EventHandler(this.selWorkcenter_SelectedIndexChanged);
            // 
            // dpPlannedDate
            // 
            this.dpPlannedDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dpPlannedDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dpPlannedDate.CalendarForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dpPlannedDate.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dpPlannedDate.Checked = false;
            this.dpPlannedDate.Font = new System.Drawing.Font("Calibri", 11F);
            this.dpPlannedDate.Location = new System.Drawing.Point(47, 270);
            this.dpPlannedDate.MaximumSize = new System.Drawing.Size(300, 25);
            this.dpPlannedDate.Name = "dpPlannedDate";
            this.dpPlannedDate.Size = new System.Drawing.Size(161, 25);
            this.dpPlannedDate.TabIndex = 6;
            this.dpPlannedDate.TabStop = false;
            this.dpPlannedDate.Value = new System.DateTime(2018, 7, 16, 11, 24, 36, 0);
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtOrderNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOrderNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.txtOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrderNumber.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtOrderNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.txtOrderNumber.Location = new System.Drawing.Point(47, 36);
            this.txtOrderNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtOrderNumber.MaximumSize = new System.Drawing.Size(300, 30);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(161, 18);
            this.txtOrderNumber.TabIndex = 0;
            this.txtOrderNumber.TabStop = false;
            this.txtOrderNumber.Text = "Dummie Text";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(143)))));
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFormTitle.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(259, 48);
            this.lblFormTitle.MinimumSize = new System.Drawing.Size(0, 40);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(506, 40);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Nueva órden de producción";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tPLANTBindingSource
            // 
            this.tPLANTBindingSource.DataMember = "TPLANT";
            this.tPLANTBindingSource.DataSource = this.uBSLABMN_MXDataSet1;
            // 
            // uBSLABMN_MXDataSet1
            // 
            this.uBSLABMN_MXDataSet1.DataSetName = "UBSLABMN_MXDataSet1";
            this.uBSLABMN_MXDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tPLANTTableAdapter
            // 
            this.tPLANTTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddOrderProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 651);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddOrderProd";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Órdenes de Producción";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.selPlant_SelectedIndexChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.frmPanel2.ResumeLayout(false);
            this.frmPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQtyXPallet)).EndInit();
            this.frmPanel1.ResumeLayout(false);
            this.frmPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlannedQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPLANTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel frmPanel2;
        private System.Windows.Forms.Panel frmPanel1;
        private System.Windows.Forms.TextBox txtOrderNumber;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lblQuantityXPallet;
        private System.Windows.Forms.Label lblWorkcenter;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblPlannedDate;
        private System.Windows.Forms.Label lblPlannedQty;
        private System.Windows.Forms.Label lblPlant;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox selProduct;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.NumericUpDown numQtyXPallet;
        private System.Windows.Forms.ComboBox selWorkcenter;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.NumericUpDown numPlannedQty;
        private System.Windows.Forms.ComboBox selPlant;
        private System.Windows.Forms.DateTimePicker dpPlannedDate;
        private UBSLABMN_MXDataSet1 uBSLABMN_MXDataSet1;
        private System.Windows.Forms.BindingSource tPLANTBindingSource;
        private UBSLABMN_MXDataSet1TableAdapters.TPLANTTableAdapter tPLANTTableAdapter;
    }
}