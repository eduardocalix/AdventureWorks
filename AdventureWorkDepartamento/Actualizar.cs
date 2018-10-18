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
    public partial class frmActualizar : Form
    {
        public frmActualizar()
        {
            InitializeComponent();
        }
        // Crear la conexión
        SqlConnection conn = new SqlConnection(@"server = (local);
                integrated security = true; database = AdventureWorks2014;");


        private void btnActualizar_Click(object sender, EventArgs e)
        {

            
           
            //llamar al storeProcedure y la conexion 
            SqlCommand cmd = new SqlCommand("sp_actualizarDepartamentos", conn);

            // Crear el comando
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                // Establecer la conexión
                conn.Open();

                using (cmd)
                {
                    // Reemplazar los parámetros por los valores del formulario
                    cmd.Parameters.Add("@Id", SqlDbType.SmallInt).Value = txtId.Text;
                    cmd.Parameters.Add("@name", SqlDbType.NChar).Value = txtNombre.Text;
                    cmd.Parameters.Add("@groupName", SqlDbType.NVarChar).Value = txtGrupo.Text;
                    cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = dtpFechaModificacion.Value;

                    // Ejecutar el query de Actualizacion
                    cmd.ExecuteNonQuery();                   
                }
                // Mostrar mensaje satisfactorio al usuario
                lblEstado.Text = "¡Grupo Actualizado satisfactoriamente!";
                Limpiar();
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
            txtId.Text = "";
            txtGrupo.Clear();
            lblEstado.Text = "";
            dtpFechaModificacion.Text = "";
            txtId.Focus();
            txtId.Enabled = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16 (txtId.Text);
            // DML Modificacion 
           
            string sqlBus = @"SELECT Name,GroupName,ModifiedDate FROM HumanResources.Department
                                WHERE DepartmentID =  '" + id + "';";

            SqlCommand cmd = new SqlCommand(sqlBus, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtNombre.Text = dr.GetString(0);
                    txtGrupo.Text = dr.GetString(1);
                    dtpFechaModificacion.Text = Convert.ToString(dr.GetDateTime(2));
                }
                txtId.Enabled = false;
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción");
            }
            finally
            {
                // Cerrar la conexión
                conn.Close();
            }
        }
    }
}
