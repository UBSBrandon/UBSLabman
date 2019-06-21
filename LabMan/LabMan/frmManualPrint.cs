using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMan
{
    public partial class frmManualPrint : MaterialForm
    {
        string message = "No se puso establecer conexión a la base de datos.";
        string connStrg = ConfigurationManager.ConnectionStrings["LabMan.Properties.Settings.UBSLABMN_MXConnectionString"].ConnectionString;
        public frmManualPrint()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            GetOpList();
        }

        private void GetOpList()
        {
            SqlConnection conn = new SqlConnection(connStrg);
            if (string.IsNullOrEmpty(conn.ToString())) {
                throw new Exception(message);
            }
            SqlCommand commd = new SqlCommand("Sp_SelectOrders", conn) { CommandType = CommandType.StoredProcedure };
            SqlDataAdapter sqlap = new SqlDataAdapter(commd);
            DataTable dt = new DataTable();
            selOrderProduction.Items.Clear();
            selOrderProduction.Text = string.Empty;
            try
            {
                conn.Open();
                sqlap.Fill(dt);
                foreach (DataRow row in dt.Rows)
                    selOrderProduction.Items.Add(row.ItemArray[0]);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
    }
}
