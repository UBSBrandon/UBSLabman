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
    public partial class frmSubMain : MaterialForm
    {
        public frmSubMain()
        {
            InitializeComponent();
        }

        private void frmSubMain_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 newChild = new Form1();
            newChild.MdiParent = this;

            newChild.Dock = DockStyle.Fill;
            newChild.Show();
        }


    }

}
