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
    public partial class frmAddUser : MaterialForm
    {
        string g_Message = "No se puso establecer conexión a la base de datos.";
        string g_ConnStrg = ConfigurationManager.ConnectionStrings["LabMan.Properties.Settings.UBSLABMN_MXConnectionString"].ConnectionString;
        public frmAddUser()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            //this.selGroupId.Click -= new System.EventHandler(this.selGroupId_SelectedIndexChanged);
            this.selSecretAskId_SelectedIndexChanged();
            this.selGroupId_SelectedIndexChanged();
            this.selPlant_SelectedIndexChanged();
            //this.selPlant.Click += new EventHandler(this.selPlant_SelectedIndexChanged);
            //this.selPlant.Click += new System.EventHandler(this.selPlant_SelectedIndexChanged);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var type = Type.GetType("LabMan.frmUsers");
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

        private void CreateUserAccount()
        {
            int count = 0;
            SqlConnection conn = new SqlConnection(g_ConnStrg);
            if (conn == null)
                throw new Exception(g_Message);
            SqlCommand commd = new SqlCommand("Sp_CreateUser", conn) { CommandType = CommandType.StoredProcedure };
            try
            {
                conn.Open();
                commd.Parameters.Add("UserID", SqlDbType.VarChar, 10);
                commd.Parameters.Add("GroupID", SqlDbType.VarChar, 20);
                commd.Parameters.Add("PassworD", SqlDbType.VarChar, 128);
                commd.Parameters.Add("FirsName", SqlDbType.VarChar, 20);
                commd.Parameters.Add("LastName", SqlDbType.VarChar, 20);
                commd.Parameters.Add("Plant", SqlDbType.Char, 4);
                //commd.Parameters.Add("FailedAccessAccount", SqlDbType.Int);
                commd.Parameters.Add("SecretID", SqlDbType.Char, 2);
                commd.Parameters.Add("SecretAnswer", SqlDbType.VarChar,30);
                commd.Parameters.Add("Mail", SqlDbType.VarChar, 50);
                commd.Parameters.Add("LogginUser", SqlDbType.VarChar, 50);
                commd.Parameters.Add("Count", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;

                var itemGroup = selGroupId.SelectedItem.ToString();
                var list = itemGroup.Split('-');
                string objGroup = list[0].ToString().Trim();

                var itemPant = selPlant.SelectedItem.ToString();
                var item = itemPant.Split('-');
                string objPlant = item[0].ToString().Trim();

                var itemSecret = selSecretAskId.SelectedItem.ToString();
                var array = itemSecret.Split('-');
                string objSecrect = array[0].ToString().Trim();

               // byte[] encrypt = System.Text.Encoding.ASCII.GetBytes(txtPassword.Text.ToString()); 

                commd.Parameters["UserID"].Value =  txtUserId.Text.ToString();
                commd.Parameters["GroupID"].Value = objGroup.ToString();
                commd.Parameters["PassworD"].Value = txtPassword.Text.ToString();
                commd.Parameters["FirsName"].Value = txtFirstName.Text.ToString();
                commd.Parameters["LastName"].Value = txtLastName.Text.ToString();
                commd.Parameters["Plant"].Value = objPlant.ToString();
                commd.Parameters["SecretID"].Value = objSecrect.ToString();
                commd.Parameters["SecretAnswer"].Value = txtSecretAnswer.Text.ToString();
                commd.Parameters["Mail"].Value = "N/A";
                commd.Parameters["LogginUser"].Value = "UserTest";
                commd.ExecuteNonQuery();
                count = int.Parse(commd.Parameters["Count"].Value.ToString());
                if (count > 0)
                    MessageBox.Show(String.Format("Ya existe el USUARIO: {0}, favor de ingresar otro álias!!", txtUserId.Text.ToString()), "!! ALERTA !!", MessageBoxButtons.OK);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            object obj = new object();
            EventArgs evnt = new EventArgs();
            if (!string.Equals(txtPassword.Text.ToString(), txtPasswordConfirm.Text.ToString()))
            {
                lbnpwd1.Visible = true;
                lbnpwd2.Visible = true;
            }
            else
            {
                this.lbnpwd1.Visible = false;
                this.lbnpwd2.Visible = false;
                this.CreateUserAccount();
                btnBack_Click(obj, evnt);
                MessageBox.Show(String.Format("El USUARIO: {0}, Se creó EXITOSAMENTE!!", txtUserId.Text.ToString()), "!! ALERTA !!", MessageBoxButtons.OK);
            }
        }

        private void selSecretAskId_SelectedIndexChanged()
        {
            SqlConnection conn = new SqlConnection(g_ConnStrg);
            if (conn == null)
                throw new Exception(g_Message);
            SqlCommand commd = new SqlCommand("Sp_SelecSecrettAsk", conn) { CommandType = CommandType.StoredProcedure };
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            selSecretAskId.Items.Clear();
            try
            {
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                    selSecretAskId.Items.Add("Sin datos...");
                else
                {
                    //selProduct.Items.Add("Seleccione...");
                    //selProduct.SelectedText = selProduct.Items[0].ToString();
                    foreach (DataRow row in dt.Rows)
                        selSecretAskId.Items.Add(row.ItemArray[1]);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            conn.Close();
            conn.Dispose();
        }

        private void selGroupId_SelectedIndexChanged()
        {
            SqlConnection conn = new SqlConnection(g_ConnStrg);
            if (conn == null)
                throw new Exception(g_Message);
            SqlCommand commd = new SqlCommand("Sp_SelectUserGroup", conn) { CommandType = CommandType.StoredProcedure };
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            selGroupId.Items.Clear();
            try
            {
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                    selGroupId.Items.Add("Sin datos...");
                else
                {
                    //selProduct.Items.Add("Seleccione...");
                    //selProduct.SelectedText = selProduct.Items[0].ToString();
                    foreach (DataRow row in dt.Rows)
                        selGroupId.Items.Add(row.ItemArray[1]);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            conn.Close();
            conn.Dispose();
        }

        private void selPlant_SelectedIndexChanged()
        {
            SqlConnection conn = new SqlConnection(g_ConnStrg);
            if (conn == null)
                throw new Exception(g_Message);
            SqlCommand commd = new SqlCommand("Sp_SelectPlant", conn) { CommandType = CommandType.StoredProcedure };
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            //selProduct.Text = "";
            selPlant.Items.Clear();
            try
            {
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                    selPlant.Items.Add("Sin datos...");
                else
                {
                    //selProduct.Items.Add("Seleccione...");
                    //selProduct.SelectedText = selProduct.Items[0].ToString();
                    foreach (DataRow row in dt.Rows)
                        selPlant.Items.Add(row.ItemArray[0]);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            conn.Close();
            conn.Dispose();
        }
    }
}
