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
    public partial class frmAddGroup : MaterialForm
    {
        /// <summary>
        /// Variables Globales
        /// </summary>
        string g_Message = "No se puso establecer conexión a la base de datos.";
        string g_ConnStrg = ConfigurationManager.ConnectionStrings["LabMan.Properties.Settings.UBSLABMN_MXConnectionString"].ConnectionString;
        string g_GroupDevice = frmDevicesGroups.g_GetGroupDevice;
        string g_DeviceName = frmDevicesGroups.g_GetDeviceName;
        public frmAddGroup()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            if ( g_GroupDevice != "")
            {
                this.numGroupID.Text = g_GroupDevice.ToString();
                this.txtGroupName.Text = g_DeviceName.ToString();
                lblFormTitle.Text = "Editar Grupos de dispositivos";
                this.btnAddGroup.Visible = false;
                this.btnSaveDe.Visible = true;
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var type = Type.GetType("LabMan.frmDevicesGroups");
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

        private void CreateDeviceGroup()
        {
            int count = 0;
            SqlConnection conn = new SqlConnection(g_ConnStrg);
            if (conn == null)
                throw new Exception(g_Message);
            SqlCommand commd = new SqlCommand("SP_CREATEDEVICEGRO", conn) { CommandType = CommandType.StoredProcedure };
            try
            {
                conn.Open();
                commd.Parameters.Add("DEVICEGROUP", SqlDbType.VarChar, 20);
                commd.Parameters.Add("COUNT", SqlDbType.Int).Direction = ParameterDirection.Output;
                commd.Parameters["DEVICEGROUP"].Value = txtGroupName.Text.ToString();
                commd.ExecuteNonQuery();
                count = int.Parse(commd.Parameters["COUNT"].Value.ToString());
                if (count > 0)
                    MessageBox.Show(String.Format("El Grupo de dispositivos {0} ya EXISTE, favor de ingresar uno nuevo!!", txtGroupName.Text.ToString()), "!! ALERTA !!", MessageBoxButtons.OK);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void numGroupID_ValueChanged(object sender, EventArgs e)
        {}
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            object sen = new object();
            EventArgs eve = new EventArgs();
            DialogResult msg = new DialogResult();
            msg = MessageBox.Show(String.Format("Se creara el Grupo de dispositivos {0}, ¿Desea continuar?", txtGroupName.Text.ToString()), "!! GUARDAR !!", MessageBoxButtons.YesNoCancel);
            if (msg == DialogResult.Yes)
            {
                this.CreateDeviceGroup();
                MessageBox.Show(String.Format("El Grupo de dispositivos {0} se creó exitosamente!!", txtGroupName.Text.ToString()), "!! ALERTA !!", MessageBoxButtons.OK);
                this.btnBack_Click(sen, eve);
            }
            else if (msg == DialogResult.No || msg == DialogResult.Cancel)
                return;
        }

        private void btnSaveDe_Click(object sender, EventArgs e)
        {
            object sen = new object();
            EventArgs eve = new EventArgs();
            this.UpdateGroupDevice();
            MessageBox.Show(String.Format("El Grupo de dispositivos {0} se MODIFICO exitosamente!!", txtGroupName.Text.ToString()), "!! ALERTA !!", MessageBoxButtons.OK);
            this.btnBack_Click(sen,eve);
        }

        private void UpdateGroupDevice()
        {
            SqlConnection conn = new SqlConnection(g_ConnStrg);
            if (conn == null)
                throw new Exception(g_Message);
            SqlCommand commd = new SqlCommand("Sp_UpdateGroupDevice", conn) { CommandType = CommandType.StoredProcedure };
            try
            {
                conn.Open();
                commd.Parameters.Add("DEVICEID", SqlDbType.VarChar, 3);
                commd.Parameters.Add("DEVICEGROUP", SqlDbType.VarChar, 20);

                commd.Parameters["DEVICEID"].Value = g_GroupDevice.ToString();
                commd.Parameters["DEVICEGROUP"].Value = txtGroupName.Text.ToString();
                commd.ExecuteNonQuery();

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
