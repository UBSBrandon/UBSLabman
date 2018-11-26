using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMan
{
    public partial class frmProducts : MaterialForm
    {
        #region "Variables"
        string message = "No se puso establecer conexión a la base de datos.";
        string connStrg = ConfigurationManager.ConnectionStrings["LabMan.Properties.Settings.UBSLABMN_MXConnectionString"].ConnectionString;
        Boolean bandera = true;
        #endregion

        public frmProducts()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'uBSLABMN_MXTProd.TPRODUCT' Puede moverla o quitarla según sea necesario.
            this.tPRODUCTTableAdapter.Fill(this.uBSLABMN_MXTProd.TPRODUCT);
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var type = Type.GetType("LabMan.frmMain");
            var form = Activator.CreateInstance(type) as Form;
            if (form != null)
            {
                form.MdiParent = this.ParentForm;
                form.BackColor = Color.AliceBlue;
                form.Dock = DockStyle.Fill;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.WindowState = FormWindowState.Normal;
                this.Dispose();
                form.Show();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var type = Type.GetType("LabMan.frmAddProduct");
            var form = Activator.CreateInstance(type, "0") as Form;
            if (form != null)
            {
                form.MdiParent = this.ParentForm;
                form.BackColor = Color.AliceBlue;
                form.Dock = DockStyle.Fill;
                form.MinimizeBox = false;
                form.MaximizeBox = false;
                form.WindowState = FormWindowState.Normal;
                this.Dispose();
                form.Show();
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String IdProduct = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString();
            String Descripcion = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();

            if (e.ColumnIndex == 0){
                var type = Type.GetType("LabMan.frmAddProduct");
                var form = Activator.CreateInstance(type, IdProduct) as Form;
                if (form != null)
                {
                    form.MdiParent = this.ParentForm;
                    form.BackColor = Color.AliceBlue;
                    form.Dock = DockStyle.Fill;
                    form.MinimizeBox = false;
                    form.MaximizeBox = false;
                    form.WindowState = FormWindowState.Normal;
                    this.Dispose();
                    form.Show();
                }
            }
            else if (e.ColumnIndex == 1){
                DialogResult dialog;
                if (bandera)
                {
                    dialog = MessageBox.Show("Estas por eliminar el producto: " + IdProduct + " - " + Descripcion + ".\n¿Deseas continuar?", "Exit", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.No)
                    {
                        bandera = true;
                    }
                    else
                    {
                        bandera = false;
                        Program.rsltt = DialogResult.Yes;
                        //Eliminar este producto
                        MessageBox.Show("Ya bailó este producto");
                    }
                }
            }
        }
    }
}
