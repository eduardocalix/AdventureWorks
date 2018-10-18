using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdventureWorkDepartamento
{
    public partial class frmListarDepartamentos : Form
    {
        public frmListarDepartamentos()
        {
            InitializeComponent();
        }

        private void frmListarDepartamentos_Load(object sender, EventArgs e)
        {
            // Conexión
            string conn = @"server = (local); database = AdventureWorks2014;
                integrated security = true;";

            // Query
            string sql = @"SELECT * From HumanResources.Department";

            // Crear la conexión
            SqlConnection connection = new SqlConnection(conn);

            try
            {
                // Establecer la conexión
                connection.Open();

                // Crear el DataAdapter
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                // Crear el DataSet
                DataSet ds = new DataSet();

                // Popular (llenar) el DataSet
                da.Fill(ds, "HumanResources.Department");

                gvDepartamentos.DataSource = ds.Tables["HumanResources.Department"];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                // Cerrar la conexión
                connection.Close();
            }
        }
    }
}
