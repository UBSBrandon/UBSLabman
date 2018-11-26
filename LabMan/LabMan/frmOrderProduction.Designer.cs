namespace LabMan
{
    partial class frmOrderProduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderProduction));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.grdOrdersProduction = new System.Windows.Forms.DataGridView();
            this.oRDERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANTNUMBERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATNRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wORKCENTERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANNEDQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEALQTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANNEDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rEALDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYXPALLETDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTATUSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bATCHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATIONDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATIONUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTCHANGEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTCHANGEUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.tORDERPRODUCTIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdersProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tORDERPRODUCTIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnBack.BackgroundImage = global::LabMan.Properties.Resources.left_arrow;
            resources.ApplyResources(this.btnBack, "btnBack");
            this.btnBack.Name = "btnBack";
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LabMan.Properties.Resources.btnOrderProduction;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(152)))), ((int)(((byte)(125)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.grdOrdersProduction, 1, 1);
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // tableLayoutPanel5
            // 
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddOrder);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // btnAddOrder
            // 
            resources.ApplyResources(this.btnAddOrder, "btnAddOrder");
            this.btnAddOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnAddOrder.BackgroundImage = global::LabMan.Properties.Resources.btnAdd;
            this.btnAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddOrder.FlatAppearance.BorderSize = 0;
            this.btnAddOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // grdOrdersProduction
            // 
            this.grdOrdersProduction.AllowUserToAddRows = false;
            this.grdOrdersProduction.AutoGenerateColumns = false;
            this.grdOrdersProduction.BackgroundColor = System.Drawing.Color.White;
            this.grdOrdersProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOrdersProduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oRDERIDDataGridViewTextBoxColumn,
            this.pLANTNUMBERDataGridViewTextBoxColumn,
            this.mATNRDataGridViewTextBoxColumn,
            this.wORKCENTERIDDataGridViewTextBoxColumn,
            this.pLANNEDQTYDataGridViewTextBoxColumn,
            this.rEALQTYDataGridViewTextBoxColumn,
            this.pLANNEDDATEDataGridViewTextBoxColumn,
            this.rEALDATEDataGridViewTextBoxColumn,
            this.qTYXPALLETDataGridViewTextBoxColumn,
            this.sTATUSDataGridViewTextBoxColumn,
            this.bATCHDataGridViewTextBoxColumn,
            this.cREATIONDATEDataGridViewTextBoxColumn,
            this.cREATIONUSERDataGridViewTextBoxColumn,
            this.lASTCHANGEDATEDataGridViewTextBoxColumn,
            this.lASTCHANGEUSERDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.grdOrdersProduction.DataSource = this.tORDERPRODUCTIONBindingSource;
            resources.ApplyResources(this.grdOrdersProduction, "grdOrdersProduction");
            this.grdOrdersProduction.Name = "grdOrdersProduction";
            // 
            // oRDERIDDataGridViewTextBoxColumn
            // 
            this.oRDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDERID";
            resources.ApplyResources(this.oRDERIDDataGridViewTextBoxColumn, "oRDERIDDataGridViewTextBoxColumn");
            this.oRDERIDDataGridViewTextBoxColumn.Name = "oRDERIDDataGridViewTextBoxColumn";
            // 
            // pLANTNUMBERDataGridViewTextBoxColumn
            // 
            this.pLANTNUMBERDataGridViewTextBoxColumn.DataPropertyName = "PLANTNUMBER";
            resources.ApplyResources(this.pLANTNUMBERDataGridViewTextBoxColumn, "pLANTNUMBERDataGridViewTextBoxColumn");
            this.pLANTNUMBERDataGridViewTextBoxColumn.Name = "pLANTNUMBERDataGridViewTextBoxColumn";
            // 
            // mATNRDataGridViewTextBoxColumn
            // 
            this.mATNRDataGridViewTextBoxColumn.DataPropertyName = "MATNR";
            resources.ApplyResources(this.mATNRDataGridViewTextBoxColumn, "mATNRDataGridViewTextBoxColumn");
            this.mATNRDataGridViewTextBoxColumn.Name = "mATNRDataGridViewTextBoxColumn";
            this.mATNRDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // wORKCENTERIDDataGridViewTextBoxColumn
            // 
            this.wORKCENTERIDDataGridViewTextBoxColumn.DataPropertyName = "WORKCENTERID";
            resources.ApplyResources(this.wORKCENTERIDDataGridViewTextBoxColumn, "wORKCENTERIDDataGridViewTextBoxColumn");
            this.wORKCENTERIDDataGridViewTextBoxColumn.Name = "wORKCENTERIDDataGridViewTextBoxColumn";
            this.wORKCENTERIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // pLANNEDQTYDataGridViewTextBoxColumn
            // 
            this.pLANNEDQTYDataGridViewTextBoxColumn.DataPropertyName = "PLANNEDQTY";
            resources.ApplyResources(this.pLANNEDQTYDataGridViewTextBoxColumn, "pLANNEDQTYDataGridViewTextBoxColumn");
            this.pLANNEDQTYDataGridViewTextBoxColumn.Name = "pLANNEDQTYDataGridViewTextBoxColumn";
            this.pLANNEDQTYDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // rEALQTYDataGridViewTextBoxColumn
            // 
            this.rEALQTYDataGridViewTextBoxColumn.DataPropertyName = "REALQTY";
            resources.ApplyResources(this.rEALQTYDataGridViewTextBoxColumn, "rEALQTYDataGridViewTextBoxColumn");
            this.rEALQTYDataGridViewTextBoxColumn.Name = "rEALQTYDataGridViewTextBoxColumn";
            // 
            // pLANNEDDATEDataGridViewTextBoxColumn
            // 
            this.pLANNEDDATEDataGridViewTextBoxColumn.DataPropertyName = "PLANNEDDATE";
            resources.ApplyResources(this.pLANNEDDATEDataGridViewTextBoxColumn, "pLANNEDDATEDataGridViewTextBoxColumn");
            this.pLANNEDDATEDataGridViewTextBoxColumn.Name = "pLANNEDDATEDataGridViewTextBoxColumn";
            // 
            // rEALDATEDataGridViewTextBoxColumn
            // 
            this.rEALDATEDataGridViewTextBoxColumn.DataPropertyName = "REALDATE";
            resources.ApplyResources(this.rEALDATEDataGridViewTextBoxColumn, "rEALDATEDataGridViewTextBoxColumn");
            this.rEALDATEDataGridViewTextBoxColumn.Name = "rEALDATEDataGridViewTextBoxColumn";
            // 
            // qTYXPALLETDataGridViewTextBoxColumn
            // 
            this.qTYXPALLETDataGridViewTextBoxColumn.DataPropertyName = "QTYXPALLET";
            resources.ApplyResources(this.qTYXPALLETDataGridViewTextBoxColumn, "qTYXPALLETDataGridViewTextBoxColumn");
            this.qTYXPALLETDataGridViewTextBoxColumn.Name = "qTYXPALLETDataGridViewTextBoxColumn";
            // 
            // sTATUSDataGridViewTextBoxColumn
            // 
            this.sTATUSDataGridViewTextBoxColumn.DataPropertyName = "STATUS";
            resources.ApplyResources(this.sTATUSDataGridViewTextBoxColumn, "sTATUSDataGridViewTextBoxColumn");
            this.sTATUSDataGridViewTextBoxColumn.Name = "sTATUSDataGridViewTextBoxColumn";
            // 
            // bATCHDataGridViewTextBoxColumn
            // 
            this.bATCHDataGridViewTextBoxColumn.DataPropertyName = "BATCH";
            resources.ApplyResources(this.bATCHDataGridViewTextBoxColumn, "bATCHDataGridViewTextBoxColumn");
            this.bATCHDataGridViewTextBoxColumn.Name = "bATCHDataGridViewTextBoxColumn";
            // 
            // cREATIONDATEDataGridViewTextBoxColumn
            // 
            this.cREATIONDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATIONDATE";
            resources.ApplyResources(this.cREATIONDATEDataGridViewTextBoxColumn, "cREATIONDATEDataGridViewTextBoxColumn");
            this.cREATIONDATEDataGridViewTextBoxColumn.Name = "cREATIONDATEDataGridViewTextBoxColumn";
            // 
            // cREATIONUSERDataGridViewTextBoxColumn
            // 
            this.cREATIONUSERDataGridViewTextBoxColumn.DataPropertyName = "CREATIONUSER";
            resources.ApplyResources(this.cREATIONUSERDataGridViewTextBoxColumn, "cREATIONUSERDataGridViewTextBoxColumn");
            this.cREATIONUSERDataGridViewTextBoxColumn.Name = "cREATIONUSERDataGridViewTextBoxColumn";
            // 
            // lASTCHANGEDATEDataGridViewTextBoxColumn
            // 
            this.lASTCHANGEDATEDataGridViewTextBoxColumn.DataPropertyName = "LASTCHANGEDATE";
            resources.ApplyResources(this.lASTCHANGEDATEDataGridViewTextBoxColumn, "lASTCHANGEDATEDataGridViewTextBoxColumn");
            this.lASTCHANGEDATEDataGridViewTextBoxColumn.Name = "lASTCHANGEDATEDataGridViewTextBoxColumn";
            // 
            // lASTCHANGEUSERDataGridViewTextBoxColumn
            // 
            this.lASTCHANGEUSERDataGridViewTextBoxColumn.DataPropertyName = "LASTCHANGEUSER";
            resources.ApplyResources(this.lASTCHANGEUSERDataGridViewTextBoxColumn, "lASTCHANGEUSERDataGridViewTextBoxColumn");
            this.lASTCHANGEUSERDataGridViewTextBoxColumn.Name = "lASTCHANGEUSERDataGridViewTextBoxColumn";
            // 
            // Edit
            // 
            resources.ApplyResources(this.Edit, "Edit");
            this.Edit.Image = global::LabMan.Properties.Resources.iconEdit;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Delete
            // 
            resources.ApplyResources(this.Delete, "Delete");
            this.Delete.Image = global::LabMan.Properties.Resources.iconDelete;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tORDERPRODUCTIONBindingSource
            // 
            this.tORDERPRODUCTIONBindingSource.DataMember = "TORDERPRODUCTION";
            // 
            // uBSLABMN_MXOrderProd
            // 
            // 
            // tORDERPRODUCTIONTableAdapter
            // 
            // 
            // dataGridViewImageColumn1
            // 
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = global::LabMan.Properties.Resources.iconEdit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewImageColumn2
            // 
            resources.ApplyResources(this.dataGridViewImageColumn2, "dataGridViewImageColumn2");
            this.dataGridViewImageColumn2.Image = global::LabMan.Properties.Resources.iconDelete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // frmOrderProduction
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrderProduction";
            this.Sizable = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrderProduction_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrdersProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tORDERPRODUCTIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grdOrdersProduction;
        private System.Windows.Forms.BindingSource tORDERPRODUCTIONBindingSource;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANTNUMBERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wORKCENTERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANNEDQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEALQTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLANNEDDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rEALDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYXPALLETDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTATUSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bATCHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATIONDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATIONUSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTCHANGEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTCHANGEUSERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Label label1;
    }
}