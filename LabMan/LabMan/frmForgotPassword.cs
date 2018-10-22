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
    public partial class frmForgotPassword : MaterialForm
    {
        public frmForgotPassword()
        {
            InitializeComponent();
            
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            frmLogin nextForm = new frmLogin();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}
