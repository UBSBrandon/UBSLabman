namespace LabMan
{
    partial class frmDevicesGroups
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.grdGroupDevices = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dEVICEGROUPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEVICEGROUPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATIONDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cREATIONUSERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDEVICEGROUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uBSLABMN_MXDataSet3 = new LabMan.UBSLABMN_MXDataSet3();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.uBSLABMN_MXDataSet = new LabMan.UBSLABMN_MXDataSet();
            this.uBSLABMNMXDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uBSLABMN_MXDataSet2 = new LabMan.UBSLABMN_MXDataSet2();
            this.uBSLABMNMXDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tDEVICEGROUPTableAdapter = new LabMan.UBSLABMN_MXDataSet3TableAdapters.TDEVICEGROUPTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdGroupDevices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDEVICEGROUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXDataSet3)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMNMXDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMNMXDataSet2BindingSource)).BeginInit();
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
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.21469F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.78531F));
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
            this.pictureBox2.BackgroundImage = global::LabMan.Properties.Resources.btnDevicesGroups;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox2.Location = new System.Drawing.Point(202, 22);
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
            this.tableLayoutPanel4.Controls.Add(this.grdGroupDevices, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Inch);
            this.tableLayoutPanel4.ForeColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 157);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1024, 494);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(207, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(608, 68);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddGroup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(212, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 28);
            this.panel1.TabIndex = 0;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.AccessibleName = "Orden de produccion";
            this.btnAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnAddGroup.BackgroundImage = global::LabMan.Properties.Resources.btnAdd;
            this.btnAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup.FlatAppearance.BorderSize = 0;
            this.btnAddGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroup.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddGroup.Location = new System.Drawing.Point(0, 0);
            this.btnAddGroup.MaximumSize = new System.Drawing.Size(184, 28);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(184, 28);
            this.btnAddGroup.TabIndex = 16;
            this.btnAddGroup.Text = "        Nuevo Grupo";
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // grdGroupDevices
            // 
            this.grdGroupDevices.AllowUserToAddRows = false;
            this.grdGroupDevices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.grdGroupDevices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grdGroupDevices.AutoGenerateColumns = false;
            this.grdGroupDevices.BackgroundColor = System.Drawing.Color.White;
            this.grdGroupDevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdGroupDevices.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.grdGroupDevices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdGroupDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete,
            this.dEVICEGROUPIDDataGridViewTextBoxColumn,
            this.dEVICEGROUPDataGridViewTextBoxColumn,
            this.cREATIONDATEDataGridViewTextBoxColumn,
            this.cREATIONUSERDataGridViewTextBoxColumn});
            this.grdGroupDevices.DataSource = this.tDEVICEGROUPBindingSource;
            this.grdGroupDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGroupDevices.Location = new System.Drawing.Point(207, 77);
            this.grdGroupDevices.Name = "grdGroupDevices";
            this.grdGroupDevices.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.grdGroupDevices.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.grdGroupDevices.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.grdGroupDevices.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grdGroupDevices.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.grdGroupDevices.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.grdGroupDevices.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.grdGroupDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGroupDevices.ShowCellErrors = false;
            this.grdGroupDevices.ShowCellToolTips = false;
            this.grdGroupDevices.ShowRowErrors = false;
            this.grdGroupDevices.Size = new System.Drawing.Size(608, 339);
            this.grdGroupDevices.TabIndex = 1;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::LabMan.Properties.Resources.Editv2;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::LabMan.Properties.Resources.delete;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dEVICEGROUPIDDataGridViewTextBoxColumn
            // 
            this.dEVICEGROUPIDDataGridViewTextBoxColumn.DataPropertyName = "DEVICEGROUPID";
            this.dEVICEGROUPIDDataGridViewTextBoxColumn.HeaderText = "Código";
            this.dEVICEGROUPIDDataGridViewTextBoxColumn.Name = "dEVICEGROUPIDDataGridViewTextBoxColumn";
            // 
            // dEVICEGROUPDataGridViewTextBoxColumn
            // 
            this.dEVICEGROUPDataGridViewTextBoxColumn.DataPropertyName = "DEVICEGROUP";
            this.dEVICEGROUPDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.dEVICEGROUPDataGridViewTextBoxColumn.Name = "dEVICEGROUPDataGridViewTextBoxColumn";
            // 
            // cREATIONDATEDataGridViewTextBoxColumn
            // 
            this.cREATIONDATEDataGridViewTextBoxColumn.DataPropertyName = "CREATIONDATE";
            this.cREATIONDATEDataGridViewTextBoxColumn.HeaderText = "Fecha de creación";
            this.cREATIONDATEDataGridViewTextBoxColumn.Name = "cREATIONDATEDataGridViewTextBoxColumn";
            // 
            // cREATIONUSERDataGridViewTextBoxColumn
            // 
            this.cREATIONUSERDataGridViewTextBoxColumn.DataPropertyName = "CREATIONUSER";
            this.cREATIONUSERDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.cREATIONUSERDataGridViewTextBoxColumn.Name = "cREATIONUSERDataGridViewTextBoxColumn";
            // 
            // tDEVICEGROUPBindingSource
            // 
            this.tDEVICEGROUPBindingSource.DataMember = "TDEVICEGROUP";
            this.tDEVICEGROUPBindingSource.DataSource = this.uBSLABMN_MXDataSet3;
            // 
            // uBSLABMN_MXDataSet3
            // 
            this.uBSLABMN_MXDataSet3.DataSetName = "UBSLABMN_MXDataSet3";
            this.uBSLABMN_MXDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1024, 97);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(152)))), ((int)(((byte)(125)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(156, 57);
            this.label1.MinimumSize = new System.Drawing.Size(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestión de grupos de dispositivos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uBSLABMN_MXDataSet
            // 
            this.uBSLABMN_MXDataSet.DataSetName = "UBSLABMN_MXDataSet";
            this.uBSLABMN_MXDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uBSLABMNMXDataSetBindingSource
            // 
            this.uBSLABMNMXDataSetBindingSource.DataSource = this.uBSLABMN_MXDataSet;
            this.uBSLABMNMXDataSetBindingSource.Position = 0;
            // 
            // uBSLABMN_MXDataSet2
            // 
            this.uBSLABMN_MXDataSet2.DataSetName = "UBSLABMN_MXDataSet2";
            this.uBSLABMN_MXDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uBSLABMNMXDataSet2BindingSource
            // 
            this.uBSLABMNMXDataSet2BindingSource.DataSource = this.uBSLABMN_MXDataSet2;
            this.uBSLABMNMXDataSet2BindingSource.Position = 0;
            // 
            // tDEVICEGROUPTableAdapter
            // 
            this.tDEVICEGROUPTableAdapter.ClearBeforeFill = true;
            // 
            // frmDevicesGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 651);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDevicesGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos de dispositivos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDevicesGroups_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdGroupDevices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tDEVICEGROUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXDataSet3)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMNMXDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMN_MXDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBSLABMNMXDataSet2BindingSource)).EndInit();
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
        private System.Windows.Forms.Button btnAddGroup;
        private System.Windows.Forms.DataGridView grdGroupDevices;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private UBSLABMN_MXDataSet uBSLABMN_MXDataSet;
        private System.Windows.Forms.BindingSource uBSLABMNMXDataSetBindingSource;
        private UBSLABMN_MXDataSet2 uBSLABMN_MXDataSet2;
        private System.Windows.Forms.BindingSource uBSLABMNMXDataSet2BindingSource;
        private UBSLABMN_MXDataSet3 uBSLABMN_MXDataSet3;
        private System.Windows.Forms.BindingSource tDEVICEGROUPBindingSource;
        private UBSLABMN_MXDataSet3TableAdapters.TDEVICEGROUPTableAdapter tDEVICEGROUPTableAdapter;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEVICEGROUPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEVICEGROUPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATIONDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cREATIONUSERDataGridViewTextBoxColumn;
    }
}