using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace LabMan
{
    public partial class frmOrderProduction : MaterialForm
    {
        public frmOrderProduction()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void frmOrderProduction_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'uBSLABMN_MXOrderProd.TORDERPRODUCTION' Puede moverla o quitarla según sea necesario.
            try
            {
                //this.tORDERPRODUCTIONTableAdapter.Fill(this.uBSLABMN_MXOrderProd.TORDERPRODUCTION);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            btnAddOrder.BackgroundImage = global::LabMan.Properties.Resources.btnAddPress;
            var type = Type.GetType("LabMan.frmAddOrderProd");
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
            //btnAddOrder.BackgroundImage = global::LabMan.Properties.Resources.btnAdd;
        }

    }
}
