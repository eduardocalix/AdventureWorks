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
using System.Data.Sql;

namespace AdventureWorkDepartamento
{
    public partial class frmCrearDepartamentos : Form
    {
        public frmCrearDepartamentos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Crear la conexión
            SqlConnection conn = new SqlConnection(@"server = (local);
                integrated security = true; database = AdventureWorks2014;");

            // Crear el comando
 
            SqlCommand cmd = new SqlCommand("SP_InsertarArea", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                using (cmd)
                {
                    cmd.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50));
                    cmd.Parameters["@name"].Value = txtNombre.Text;
                    cmd.Parameters.Add(new SqlParameter("@groupName", SqlDbType.NVarChar,50));
                    cmd.Parameters["@groupName"].Value = txtGrupo.Text;
                    cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.Date));
                    cmd.Parameters["@date"].Value = dtpFechaModificacion.Text;
                    cmd.ExecuteNonQuery();
  
                    // Mostrar mensaje satisfactorio al usuario
                    lblEstado.Text = "¡Nuevo grupo agregado satisfactoriamente!";
                    Limpiar();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "¡Detalles de la excepción!");
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }
        //Funcion que se encarga de limpiar el Formulario
        public void Limpiar()
        {
            txtNombre.Clear();
            txtGrupo.Clear();
            lblEstado.Text = "";
            dtpFechaModificacion.Text = "";
            txtNombre.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //se manda a llamar la funcion de limpiar todo el formulario
            Limpiar();
            
        }
    }
}
