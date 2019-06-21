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
using System.Data.SqlClient;
using System.Configuration;

namespace LabMan
{
    public partial class frmOrderProduction : MaterialForm
    {
        /// <summary>
        /// Variable global
        /// </summary>
        public static string GetOrder { get; set; }

        string message = "No se puso establecer conexión a la base de datos.";
        string connStrg = ConfigurationManager.ConnectionStrings["LabMan.Properties.Settings.UBSLABMN_MXConnectionString"].ConnectionString;
        public frmOrderProduction()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            //this.Load += new EventHandler(frmOrderProduction_Load);
            this.grdOrdersProduction.CellContentClick += grdOrdersProduction_CellContentClick;

        }

        public void frmOrderProduction_Load(object sender, EventArgs e)
        {
            this.grdOrdersProduction.AutoSize = true;
            // TODO: esta línea de código carga datos en la tabla 'uBSLABMN_MXOrderProd.TORDERPRODUCTION' Puede moverla o quitarla según sea necesario.
            
            SqlConnection conn = new SqlConnection(connStrg);
            if (string.IsNullOrEmpty(conn.ToString()))
                throw new Exception(message);
            SqlCommand commd = new SqlCommand("Sp_SelectOrders", conn) { CommandType = CommandType.StoredProcedure };
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            DataTable dt = new DataTable();
            //SqlDataReader reader;
            try
            {
                conn.Open();
                //reader = commd.ExecuteReader();
                //dt.Load(reader);
                adapter.Fill(dt);
                this.grdOrdersProduction.DataSource = dt;
                this.grdOrdersProduction.EnableHeadersVisualStyles = false;
                commd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            conn.Close();
            conn.Dispose();
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
            GetOrder = string.Empty;
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

        private void DeleteOrder(string order, string workcenter)
        {
            SqlConnection conn = new SqlConnection(connStrg);
            if (string.IsNullOrEmpty(conn.ToString()))
                throw new Exception(message);
            SqlCommand commd = new SqlCommand("Sp_DeleteOrders", conn) { CommandType = CommandType.StoredProcedure };
            try
            {
                conn.Open();
                commd.Parameters.Add("Order", SqlDbType.VarChar, 12);
                commd.Parameters.Add("Line", SqlDbType.Char, 20);
                // --------------------
                commd.Parameters["Order"].Value = order;
                commd.Parameters["Line"].Value = workcenter;
                commd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            conn.Dispose();
            conn.Close();
        }
        private void grdOrdersProduction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grdOrdersProduction.SelectedCells[0].Style.SelectionBackColor = Color.DodgerBlue;
            string order = grdOrdersProduction.SelectedRows[0].Cells["Orden"].Value.ToString();
            string line = grdOrdersProduction.SelectedRows[0].Cells["Linea"].Value.ToString();
            if (e.ColumnIndex == this.Editar.Index)
            {
                //grdOrdersProduction.SelectedRows[0].Cells["Editar"].Style.SelectionBackColor = Color.Green;
                grdOrdersProduction.SelectedCells[0].Style.SelectionBackColor = Color.Green;

                var response = MessageBox.Show("¿ Esta seguro que quiere Editar ?", "!! ALERTA !!", MessageBoxButtons.YesNo);
                if (Equals(response.ToString(), "Yes"))
                {
                    GetOrder = order.ToString();
                    this.editEvent_Click();
                }
                else {
                    return;
                }
            }
            else if (e.ColumnIndex == this.Eliminar.Index)
            {
                grdOrdersProduction.SelectedCells[1].Style.SelectionBackColor = Color.Red;
                var response = MessageBox.Show(String.Format("¿ Esta seguro que quiere ELIMINAR la ORDEN {0} ?", order), "!! ALERTA !!", MessageBoxButtons.YesNo);
                if (Equals(response.ToString(), "Yes"))
                {
                    object o = new object();
                    EventArgs ea = new EventArgs();
                    this.DeleteOrder(order, line);
                    grdOrdersProduction.SelectedCells[1].Style.SelectionBackColor = Color.DodgerBlue;
                    frmOrderProduction_Load(o,ea);
                    MessageBox.Show(String.Format("La ORDEN {0} se Elimino Correctamente!!", order), "!! ALERTA !!", MessageBoxButtons.OK);
                }
                else
                {
                    return;
                }
            }
        }
        private void editEvent_Click() {
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
        }

        private void grdOrdersProduction_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
