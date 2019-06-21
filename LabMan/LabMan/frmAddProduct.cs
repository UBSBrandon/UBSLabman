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
    public partial class frmAddProduct : MaterialForm
    {
        string g_Message = "No se puso establecer conexión a la base de datos.";
        string g_ConnStrg = ConfigurationManager.ConnectionStrings["LabMan.Properties.Settings.UBSLABMN_MXConnectionString"].ConnectionString;
        public frmAddProduct()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme((MaterialSkin.Primary)7000, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }



        private void CreateProducts(string codeProduct, string description, float quality, char uM, char uTime)
        {
            int countProd = 0;
            SqlConnection conn = new SqlConnection(g_ConnStrg);
            if (string.IsNullOrEmpty(conn.ToString()))
                throw new Exception(g_Message);
            SqlCommand commd = new SqlCommand("Sp_CreateProducts", conn) { CommandType = CommandType.StoredProcedure };
            try
            {
                conn.Open();
                commd.Parameters.Add("CodeProduct", SqlDbType.VarChar, 18);
                commd.Parameters.Add("ProductDescription", SqlDbType.VarChar, 50);
                commd.Parameters.Add("Quality", SqlDbType.Float);
                commd.Parameters.Add("UnitMessure", SqlDbType.Char, 3);
                commd.Parameters.Add("TimeUnit", SqlDbType.Char, 2);
                commd.Parameters.Add("CreationUser", SqlDbType.VarChar, 10);
                commd.Parameters.Add("Count", SqlDbType.Int).Direction = ParameterDirection.Output;

                commd.Parameters["CodeProduct"].Value = codeProduct;
                commd.Parameters["ProductDescription"].Value = description;
                commd.Parameters["Quality"].Value = quality;
                commd.Parameters["UnitMessure"].Value = uM;
                commd.Parameters["TimeUnit"].Value = uM;
                commd.Parameters["UnitMessure"].Value = uTime;
                commd.Parameters["CreationUser"].Value = "UserTest";
                countProd = int.Parse(commd.Parameters["Count"].Value.ToString());
                if (countProd > 0)
                    MessageBox.Show(String.Format("El Producto {0} ya EXISTE, favor de ingresar uno nuevo!!", codeProduct), "!! ALERTA !!", MessageBoxButtons.OK);
                else
                    commd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
    }
}
