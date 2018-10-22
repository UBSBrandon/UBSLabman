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
    public partial class frmMain : MaterialForm
    {
        Boolean bandera = true;
        public frmMain()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }
        
        private void CallForm(String formName)
        {
            string formToCall = formName;

            var type = Type.GetType("LabMan." + formToCall);
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog;
            if (bandera)
            {
                dialog = MessageBox.Show("Estás a punto de cerrar sesión ¿Deseas continuar?", "Exit", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.No)
                {
                    bandera = true;
                    e.Cancel = true;
                }
                else
                {
                    bandera = false;
                    //frmLogin nuevo = new frmLogin();
                    //nuevo.Show();
                    Program.rsltt = DialogResult.Yes;
                    this.ParentForm.Close();
                }
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchButton(this);         
        }

        private void searchButton(Control parent)
        {
            if (parent != null)
            {
                foreach (Control child in parent.Controls)
                {
                    if (child is Button)
                    {
                        String nombreBoton, accesibilidad;
                        nombreBoton = child.Name.ToString().ToUpper();
                        accesibilidad = child.AccessibleName.ToString().ToUpper();

                        if (accesibilidad.Contains(txtSearch.Text.ToUpper()))
                        {
                            //child.BackgroundImage = System.Drawing.Image.FromFile("C:/Users/alonso.gomez/source/repos/LabMan/LabMan/Resources/" + nombreBoton + ".png");
                            child.Visible = true;
                            child.Enabled = true;
                        }
                        else
                        {
                            //child.BackgroundImage = System.Drawing.Image.FromFile("C:/Users/alonso.gomez/source/repos/LabMan/LabMan/Resources/" + nombreBoton + "_disabled.png");
                            child.Visible = false;
                            child.Enabled = false;
                        }
          
                    }
                    else 
                    {
                        searchButton(child);
                    }
                }
            }
        }

        private void btnDevicesTypes_Click(object sender, EventArgs e)
        {
            CallForm("frmDevicesTypes");
        }

        private void btnOrderProduction_Click(object sender, EventArgs e)
        {
            CallForm("frmOrderProduction");
        }

        private void btnManualPrint_Click(object sender, EventArgs e)
        {
            CallForm("frmManualPrint");
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            CallForm("frmProducts");
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            CallForm("frmUsers");
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            CallForm("frmUserGroup");
        }

        private void btnPlants_Click(object sender, EventArgs e)
        {
            CallForm("frmPlants");
        }

        private void btnProductionLines_Click(object sender, EventArgs e)
        {
            CallForm("frmProductionLines");
        }

        private void btnDevices_Click(object sender, EventArgs e)
        {
            CallForm("frmDevices");
        }

        private void btnParameters_Click(object sender, EventArgs e)
        {
            CallForm("frmParameters");
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            CallForm("frmConnection");
        }

        private void btnDevicesTypes_Click_1(object sender, EventArgs e)
        {
            CallForm("frmDevicesTypes");
        }

        private void btnDevicesGroups_Click(object sender, EventArgs e)
        {
            CallForm("frmDevicesGroups");
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            CallForm("frmSchedule");
        }

        private void btnOrderAssignation_Click(object sender, EventArgs e)
        {
            CallForm("frmOrderAssignation");
        }
        
    }
}
