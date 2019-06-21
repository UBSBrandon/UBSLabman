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

namespace LabMan
{
    public partial class frmOrderAssignation : MaterialForm
    {
        public frmOrderAssignation()
        {
            InitializeComponent(); ;
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
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

        private void selPlant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selWorkcenter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selDevice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmOrderAssignation_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'oP1.TORDERPRODUCTION' Puede moverla o quitarla según sea necesario.
            this.tORDERPRODUCTIONTableAdapter.Fill(this.oP1.TORDERPRODUCTION);
            // TODO: esta línea de código carga datos en la tabla 'oP.TORDERPRODUCTION' Puede moverla o quitarla según sea necesario.
            this.tORDERPRODUCTIONTableAdapter.Fill(this.oP.TORDERPRODUCTION);

        }
    }
}
