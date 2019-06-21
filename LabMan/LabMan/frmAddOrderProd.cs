using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabMan
{
    public partial class frmAddOrderProd : MaterialForm
    {
        string message = "No se puso establecer conexión a la base de datos.";
        string connStrg = ConfigurationManager.ConnectionStrings["LabMan.Properties.Settings.UBSLABMN_MXConnectionString"].ConnectionString;
        string _Order = frmOrderProduction.GetOrder;
        public frmAddOrderProd()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            //this.selPlant.SelectedIndexChanged += new System.EventHandler(this.selWorkcenter_SelectedIndexChanged);
            //this.selProduct_SelectedIndexChanged();
            if (!string.IsNullOrEmpty(_Order))
            {
                //this.Load += new EventHandler(LoadOrderEvent);
                this.LoadOrderEvent(_Order);
                this.txtOrderNumber.Enabled = false;
                this.txtOrderNumber.Text = _Order.ToString();
                lblFormTitle.Text = "Editar Orden de Producción";
                this.btnAddOrder.Visible = false;
                this.btnSave.Visible = true;
            }
            else
            {
                this.btnAddOrder.Visible = true;
                this.btnSave.Visible = false;
            }
            this.selPlant.SelectedIndexChanged -= new System.EventHandler(this.selWorkcenter_SelectedIndexChanged);
            this.selProduct_SelectedIndexChanged();
            //this.selPlant.Click += new EventHandler(this.selPlant_SelectedIndexChanged);
            this.selPlant.Click += new System.EventHandler(this.selPlant_SelectedIndexChanged);
            this.selWorkcenter.Click += new System.EventHandler(this.selWorkcenter_SelectedIndexChanged);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var type = Type.GetType("LabMan.frmOrderProduction");
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

        /// <summary>
        /// Method to built select item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selPlant_SelectedIndexChanged(object sender, EventArgs e) 
        {
            SqlConnection conn = new SqlConnection(connStrg);
            if (conn == null)
                throw new Exception(message);
            //string query = @"SELECT [PLANTNUMBER], [PLANTNUMBER] +' - ' + [PLANTDESCRIPTION] FROM [UBSLABMN_MX].[dbo].[TPLANT];";
            SqlCommand commd = new SqlCommand("Sp_SelectLineas", conn) { CommandType = CommandType.StoredProcedure };
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            selPlant.Text = "";
            selPlant.Items.Clear();
            try
            {
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                    selPlant.Items.Add("Sin datos...");
                else
                {
                    //selPlant.Text = "Seleccione...";
                    //selPlant.Items.Add("Seleccione...");
                    //selPlant.SelectedText = selPlant.Items[0].ToString();
                    foreach (DataRow row in dt.Rows)
                        selPlant.Items.Add(row.ItemArray[1]);
                }
            }
            catch (Exception ex){throw new Exception(ex.Message);}
            conn.Close();
            conn.Dispose();

        }

        /// <summary>
        /// Method to get all products in database 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selProduct_SelectedIndexChanged()
        {
            SqlConnection conn = new SqlConnection(connStrg);
            if (conn == null)
                throw new Exception(message);
            SqlCommand commd = new SqlCommand("Sp_SelectProducts", conn) { CommandType = CommandType.StoredProcedure};
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            //selProduct.Text = "";
            selProduct.Items.Clear();
            try
            {
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count == 0)
                    selProduct.Items.Add("Sin datos...");
                else {
                    //selProduct.Items.Add("Seleccione...");
                    //selProduct.SelectedText = selProduct.Items[0].ToString();
                    foreach (DataRow row in dt.Rows)
                        selProduct.Items.Add(row.ItemArray[1]);
                }
            }
            catch (Exception ex) {throw new Exception(ex.Message); }
            conn.Close();
            conn.Dispose();
        }

        /// <summary>
        /// Method to get all workcenters where  plant have it relation in workcenter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selWorkcenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connStrg);
            if (conn == null)
                throw new Exception(message);
            SqlCommand commd = new SqlCommand("Sp_SelectWorkcenters", conn) { CommandType = CommandType.StoredProcedure };
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            selWorkcenter.Text = "";
            selWorkcenter.Items.Clear();
            try
            {
                conn.Open();
                adapter.Fill(dt);
                if (selPlant.Items.Count == 0)
                    return;
                var item= selPlant.SelectedItem.ToString();
                item = item.Substring(0,4);
                var query = from i in dt.AsEnumerable() where i.ItemArray[1].ToString() == item.Trim() select i; // LinQ
                if (query.Count() == 0) {
                    selWorkcenter.Items.Add("Sin datos...");
                    return;
                }
                DataTable copyData = query.CopyToDataTable(); // Conviertó el query generico en otra tabla ya filtrado
                if (copyData.Rows.Count == 0)
                    selWorkcenter.Items.Add("Sin datos...");
                else {
                    //selWorkcenter.Items.Add("Seleccione...");
                    //selWorkcenter.SelectedText = selWorkcenter.Items[0].ToString();
                    foreach (DataRow row in copyData.Rows)
                        selWorkcenter.Items.Add(row.ItemArray[2]);
                }
                btnAddOrder.Enabled = true;

                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            conn.Close();
            conn.Dispose();
        }

        /// <summary>
        /// Method to add new order in data base
        /// </summary>
        private void CreateOrder() 
        {
            SqlConnection conn = new SqlConnection(connStrg);
            if (conn == null)
                throw new Exception(message);
            SqlCommand commd = new SqlCommand("Sp_CreateOrder", conn) { CommandType = CommandType.StoredProcedure };
            try
            {
                conn.Open();
                commd.Parameters.Add("Order", SqlDbType.VarChar, 12);
                commd.Parameters.Add("Plant", SqlDbType.Char, 4);
                commd.Parameters.Add("Mat", SqlDbType.VarChar, 18);
                commd.Parameters.Add("Workcenter", SqlDbType.VarChar, 20);
                commd.Parameters.Add("PngQty", SqlDbType.Int);
                commd.Parameters.Add("PngDate", SqlDbType.DateTime);
                commd.Parameters.Add("PalletxQty", SqlDbType.Int);
                commd.Parameters.Add("User", SqlDbType.VarChar, 10);

                var itemPant = selPlant.SelectedItem.ToString();
                itemPant = itemPant.Substring(0,4);

                var itemProduct = selProduct.SelectedItem.ToString();
                var array = itemProduct.Split('-');
                string objProduct = array[0].ToString().Trim();

                var itemWorkcenter = selWorkcenter.SelectedItem.ToString();
                itemWorkcenter = itemWorkcenter.Substring(0, 7);

                commd.Parameters["Order"].Value =  txtOrderNumber.Text;
                commd.Parameters["Plant"].Value = itemPant;
                commd.Parameters["Mat"].Value = objProduct;
                commd.Parameters["Workcenter"].Value = itemWorkcenter;
                commd.Parameters["PngQty"].Value = numPlannedQty.Value;
                commd.Parameters["PngDate"].Value = dpPlannedDate.Value.Date + dpPlannedDate.Value.TimeOfDay;
                commd.Parameters["PalletxQty"].Value = numQtyXPallet.Value;
                commd.Parameters["User"].Value = "Test";
                commd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            conn.Close();
            conn.Dispose();
        }

        private void ClearForm(object sender, EventArgs e) {
            txtOrderNumber.Text = "";
            selProduct.Text = "";
            selProduct.Items.Clear();
            selWorkcenter.Text = "";
            selWorkcenter.Items.Clear();
            numPlannedQty.Value = 0;
            numQtyXPallet.Value = 0;
            dpPlannedDate.Value = DateTime.Now;
            selPlant.Text = "";
            selPlant_SelectedIndexChanged(sender, e);
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            this.CreateOrder();
            MessageBox.Show(String.Format("La Orden  '{0}'  se ha creado exitosamente.",txtOrderNumber.Text));
            ClearForm(sender,e);

            var type = Type.GetType("LabMan.frmOrderProduction");
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

        private void lblFormTitle_Click(object sender, EventArgs e)
        {
        }
        public void LoadOrderEvent(string orderForm) {
            SqlConnection conn = new SqlConnection(connStrg);
            object _tb = "TORDERPRODUCTION";
            if (conn == null)
                throw new Exception(message);
            SqlCommand commd = new SqlCommand("Sp_GetCriteria", conn) { CommandType = CommandType.StoredProcedure };
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(commd);
            try
            {
                conn.Open();
                commd.Parameters.Add("Table", SqlDbType.VarChar, 50);
                commd.Parameters["Table"].Value = _tb.ToString();
                commd.ExecuteNonQuery();
                adapter.Fill(dt);

                var queryLinQ = from i in dt.AsEnumerable()
                                        where i.ItemArray[0].ToString() == orderForm
                                            select i; // LinQ
                DataTable copyData = queryLinQ.CopyToDataTable(); // LinQ data copy to DataTable 
                this.selPlant.Text = "";
                this.selPlant.Text = copyData.Rows[0].ItemArray[1].ToString(); // Plant number
                this.selProduct.Text = "";
                this.selProduct.Text = copyData.Rows[0].ItemArray[2].ToString(); // Material
                this.selWorkcenter.Text = copyData.Rows[0].ItemArray[3].ToString(); // Linea
                this.numPlannedQty.Value = int.Parse(copyData.Rows[0].ItemArray[5].ToString()); // Cantidad planeada
                this.dpPlannedDate.Text = "";
                dpPlannedDate.Value = new DateTime(DateTime.Parse(copyData.Rows[0].ItemArray[7].ToString()).Year, DateTime.Parse(copyData.Rows[0].ItemArray[7].ToString()).Month, DateTime.Parse(copyData.Rows[0].ItemArray[7].ToString()).Day); // Fecha planeada
                //this.dpPlannedDate.Value.Refresh();
                
                this.numQtyXPallet.Value = int.Parse(copyData.Rows[0].ItemArray[8].ToString()); // Cantidad x pallet

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
            conn.Close();
            conn.Dispose();
        }
    }


}
