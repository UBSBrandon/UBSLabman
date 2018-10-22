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
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //frmParent nextForm = new frmParent();
            //this.Hide();

            //nextForm.ShowDialog();
            //this.Close();

            Program.rsltt = DialogResult.OK;
            this.Close();

        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            frmForgotPassword nextForm = new frmForgotPassword();
            //this.Hide();
            this.Close();
            nextForm.ShowDialog();
            
            
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.rsltt != DialogResult.OK)
            Program.rsltt = DialogResult.Abort;
        }
    }
}
