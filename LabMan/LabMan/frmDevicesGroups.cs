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
    public partial class frmDevicesGroups : MaterialForm
    {
        /// <summary>
        /// Variable global
        /// </summary>
        public static string g_GetGroupDevice { get; set; }
        public static string g_GetDeviceName { get; set; }
        string g_Message = "No se puso establecer conexión a la base de datos.";
        string g_ConnStrg = ConfigurationManager.ConnectionStrings["LabMan.Properties.Settings.UBSLABMN_MXConnectionString"].ConnectionString;
        public frmDevicesGroups()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            this.grdGroupDevices.CellContentClick += grdDevicesGroups_CellContentClick;
        }

        private void frmDevicesGroups_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'uBSLABMN_MXDataSet3.TDEVICEGROUP' Puede moverla o quitarla según sea necesario.
            this.tDEVICEGROUPTableAdapter.Fill(this.uBSLABMN_MXDataSet3.TDEVICEGROUP);

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

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
           g_GetGroupDevice = string.Empty;
            var type = Type.GetType("LabMan.frmAddGroup");
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

        private void grdDevicesGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grdGroupDevices.SelectedCells[0].Style.SelectionBackColor = Color.DodgerBlue;
            string deviceId = grdGroupDevices.SelectedRows[0].Cells[2].Value.ToString();
            string deviceName = grdGroupDevices.SelectedRows[0].Cells[3].Value.ToString();
            object o = new object();
            EventArgs ea = new EventArgs();
            if (e.ColumnIndex == this.Edit.Index)
            {
                grdGroupDevices.SelectedCells[0].Style.SelectionBackColor = Color.Green;

                var response = MessageBox.Show("¿ Esta seguro que quiere Editar ?", "!! ALERTA !!", MessageBoxButtons.YesNo);
                if (Equals(response.ToString(), "Yes"))
                {
                    g_GetGroupDevice = deviceId.ToString();
                    g_GetDeviceName = deviceName.ToString();
                    this.editEvent_Click(o,ea);
                }
                else
                    return;
            }
            else if (e.ColumnIndex == this.Delete.Index)
            {
                grdGroupDevices.SelectedCells[1].Style.SelectionBackColor = Color.Red;
                var response = MessageBox.Show(String.Format("¿ Esta seguro que quiere ELIMINAR el Grupo {0} ?", deviceId), "!! ALERTA !!", MessageBoxButtons.YesNo);
                if (Equals(response.ToString(), "Yes"))
                {
                    g_GetGroupDevice = deviceId.ToString();
                    this.DeleteGroupDevices(g_GetGroupDevice);
                    grdGroupDevices.SelectedCells[1].Style.SelectionBackColor = Color.DodgerBlue;
                    frmDevicesGroups_Load(o, ea);
                    MessageBox.Show(String.Format("El Grupo {0} se Elimino Correctamente!!", deviceId), "!! ALERTA !!", MessageBoxButtons.OK);
                }
                else
                {
                    return;
                }
            }
        }

        private void DeleteGroupDevices(string id)
        {
            SqlConnection conn = new SqlConnection(g_ConnStrg);
            if (string.IsNullOrEmpty(conn.ToString()))
                throw new Exception(g_Message);
            SqlCommand commd = new SqlCommand("SP_DELETEDEVICEGROUP", conn) { CommandType = CommandType.StoredProcedure };
            try
            {
                // --------------------
                conn.Open();
                commd.Parameters.Add("DEVICEID", SqlDbType.VarChar, 3);
                commd.Parameters["DEVICEID"].Value = g_GetGroupDevice;
                commd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            conn.Dispose();
            conn.Close();
        }
        private void editEvent_Click(object sender, EventArgs e)
        {
            var type = Type.GetType("LabMan.frmAddGroup");
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
