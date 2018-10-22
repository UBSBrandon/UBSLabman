namespace LabMan
{
    partial class frmProducts
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.grdOrdersProduction = new System.Windows.Forms.DataGridView();
            this.mATNRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAKTXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUANTITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIMEUNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATIONDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATIONUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTCHANGEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTCHANGEUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tPRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uBSLABMN_MXDataSet = new LabMan.UBSLABMN_MXDataSet();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.uBSLABMN_MXOrderProd = new LabMan.UBSLABMN_MXOrderProd();
            this.uBSLABMNMXOrderProdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tPRODUCTTableAdapter = new LabMan.UBSLABMN_MXDataSetTableAdapters.TPRODUCTTableAdapter();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdersProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXDataSet)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXOrderProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMNMXOrderProdBindingSource)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 60);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnBack.BackgroundImage = global::LabMan.Properties.Resources.left_arrow;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(975, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 20);
            this.btnBack.TabIndex = 0;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.50847F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.49152F));
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
            this.pictureBox2.BackgroundImage = global::LabMan.Properties.Resources.btnProducts;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(110, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.grdOrdersProduction, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Inch);
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 157);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1008, 455);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(204, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(598, 62);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(207, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 25);
            this.panel1.TabIndex = 0;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AccessibleName = "Orden de produccion";
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BackgroundImage = global::LabMan.Properties.Resources.btnAdd;
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddProduct.Location = new System.Drawing.Point(0, -2);
            this.btnAddProduct.MaximumSize = new System.Drawing.Size(184, 28);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(184, 28);
            this.btnAddProduct.TabIndex = 16;
            this.btnAddProduct.Text = "   Agregar Producto";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // grdOrdersProduction
            // 
            this.grdOrdersProduction.AllowUserToAddRows = false;
            this.grdOrdersProduction.AutoGenerateColumns = false;
            this.grdOrdersProduction.BackgroundColor = System.Drawing.Color.White;
            this.grdOrdersProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrdersProduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mATNRDataGridViewTextBoxColumn,
            this.mAKTXDataGridViewTextBoxColumn,
            this.qUANTITYDataGridViewTextBoxColumn,
            this.uOMDataGridViewTextBoxColumn,
            this.tIMEUNITDataGridViewTextBoxColumn,
            this.cREATIONDATEDataGridViewTextBoxColumn,
            this.cREATIONUSERDataGridViewTextBoxColumn,
            this.lASTCHANGEDATEDataGridViewTextBoxColumn,
            this.lASTCHANGEUSERDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.grdOrdersProduction.DataSource = this.tPRODUCTBindingSource;
            this.grdOrdersProduction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrdersProduction.Location = new System.Drawing.Point(204, 71);
            this.grdOrdersProduction.Name = "grdOrdersProduction";
            this.grdOrdersProduction.Size = new System.Drawing.Size(598, 312);
            this.grdOrdersProduction.TabIndex = 1;
            // 
            // mATNRDataGridViewTextBoxColumn
            // 
            this.mATNRDataGridViewTextBoxColumn.DataPropertyName = "MATNR";
            this.mATNRDataGridViewTextBoxColumn.HeaderText = "MATNR";
            this.mATNRDataGridViewTextBoxColumn.Name = "mATNRDataGridViewTextBoxColumn";
            // 
            // mAKTXDataGridViewTextBoxColumn
            // 
            this.mAKTXDataGridViewTextBoxColumn.DataPropertyName = "MAKTX";
            this.mAKTXDataGridViewTextBoxColumn.HeaderText = "MAKTX";
            this.mAKTXDataGridViewTextBoxColumn.Name = "mAKTXDataGridViewTextBoxColumn";
            // 
            // qUANTITYDataGridViewTextBoxColumn
            // 
            this.qUANTITYDataGridViewTextBoxColumn.DataPropertyName = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.HeaderText = "QUANTITY";
            this.qUANTITYDataGridViewTextBoxColumn.Name = "qUANTITYDataGridViewTextBoxColumn";
            // 
            // uOMDataGridViewTextBoxColumn
            // 
            this.uOMDataGridViewTextBoxColumn.DataPropertyName = "UOM";
            this.uOMDataGridViewTextBoxColumn.HeaderText = "UOM";
            this.uOMDataGridViewTextBoxColumn.Name = "uOMDataGridViewTextBoxColumn";
            // 
            // tIMEUNITDataGridViewTextBoxColumn
            // 
            this.tIMEUNITDataGridViewTextBoxColumn.DataPropertyName = "TIMEUNIT";
            this.tIMEUNITDataGridViewTextBoxColumn.HeaderText = "TIMEUNIT";
            this.tIMEUNITDataGridViewTextBoxColumn.Name = "tIMEUNITDataGridViewTextBoxColumn";
            // 
            // cREATIONDATEDataGridViewTextBoxColumn
            // 
            this.cREATIONDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATIONDATE";
            this.cREATIONDATEDataGridViewTextBoxColumn.HeaderText = "CREATIONDATE";
            this.cREATIONDATEDataGridViewTextBoxColumn.Name = "cREATIONDATEDataGridViewTextBoxColumn";
            // 
            // cREATIONUSERDataGridViewTextBoxColumn
            // 
            this.cREATIONUSERDataGridViewTextBoxColumn.DataPropertyName = "CREATIONUSER";
            this.cREATIONUSERDataGridViewTextBoxColumn.HeaderText = "CREATIONUSER";
            this.cREATIONUSERDataGridViewTextBoxColumn.Name = "cREATIONUSERDataGridViewTextBoxColumn";
            // 
            // lASTCHANGEDATEDataGridViewTextBoxColumn
            // 
            this.lASTCHANGEDATEDataGridViewTextBoxColumn.DataPropertyName = "LASTCHANGEDATE";
            this.lASTCHANGEDATEDataGridViewTextBoxColumn.HeaderText = "LASTCHANGEDATE";
            this.lASTCHANGEDATEDataGridViewTextBoxColumn.Name = "lASTCHANGEDATEDataGridViewTextBoxColumn";
            // 
            // lASTCHANGEUSERDataGridViewTextBoxColumn
            // 
            this.lASTCHANGEUSERDataGridViewTextBoxColumn.DataPropertyName = "LASTCHANGEUSER";
            this.lASTCHANGEUSERDataGridViewTextBoxColumn.HeaderText = "LASTCHANGEUSER";
            this.lASTCHANGEUSERDataGridViewTextBoxColumn.Name = "lASTCHANGEUSERDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.Image = global::LabMan.Properties.Resources.iconEdit;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Eliminar";
            this.Delete.Image = global::LabMan.Properties.Resources.iconDelete;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tPRODUCTBindingSource
            // 
            this.tPRODUCTBindingSource.DataMember = "TPRODUCT";
            this.tPRODUCTBindingSource.DataSource = this.uBSLABMN_MXDataSet;
            // 
            // uBSLABMN_MXDataSet
            // 
            this.uBSLABMN_MXDataSet.DataSetName = "UBSLABMN_MXDataSet";
            this.uBSLABMN_MXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1008, 97);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(152)))), ((int)(((byte)(125)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(154, 57);
            this.label1.MinimumSize = new System.Drawing.Size(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uBSLABMN_MXOrderProd
            // 
            this.uBSLABMN_MXOrderProd.DataSetName = "UBSLABMN_MXOrderProd";
            this.uBSLABMN_MXOrderProd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uBSLABMNMXOrderProdBindingSource
            // 
            this.uBSLABMNMXOrderProdBindingSource.DataSource = this.uBSLABMN_MXOrderProd;
            this.uBSLABMNMXOrderProdBindingSource.Position = 0;
            // 
            // tPRODUCTTableAdapter
            // 
            this.tPRODUCTTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::LabMan.Properties.Resources.iconEdit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::LabMan.Properties.Resources.iconDelete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 612);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdersProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tPRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXDataSet)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXOrderProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMNMXOrderProdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView grdOrdersProduction;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private UBSLABMN_MXOrderProd uBSLABMN_MXOrderProd;
        private System.Windows.Forms.BindingSource uBSLABMNMXOrderProdBindingSource;
        private UBSLABMN_MXDataSet uBSLABMN_MXDataSet;
        private System.Windows.Forms.BindingSource tPRODUCTBindingSource;
        private UBSLABMN_MXDataSetTableAdapters.TPRODUCTTableAdapter tPRODUCTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAKTXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUANTITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIMEUNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATIONDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATIONUSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTCHANGEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTCHANGEUSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}