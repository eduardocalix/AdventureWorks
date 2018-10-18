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
    public partial class frmEliminarDepartamentos : Form
    {
        public frmEliminarDepartamentos()
        {
            InitializeComponent();
        }
        // Crear la conexión
        SqlConnection conn = new SqlConnection(@"server = (local);
                  integrated security = true; database = AdventureWorks2014;");
        private void frmEliminarDepartamentos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            //Se hace la variable "ID" que almacene y convierta el contenido del txtId que esta en string 
            int id = Convert.ToInt16(txtId.Text);
            
         
            //Se realiza la busqueda segun el ID del departamento
            string sqlBus = @"SELECT Name,GroupName,ModifiedDate FROM HumanResources.Department
                                WHERE DepartmentID =  '" + id + "';";

            SqlCommand cmd = new SqlCommand(sqlBus, conn);
            try
            {
                conn.Open();
                //Se muestra en cada campo segun su tipo
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtNombre.Text = dr.GetString(0);
                    txtGrupo.Text = dr.GetString(1);
                    dtpFechaModificacion.Text = Convert.ToString(dr.GetDateTime(2));
                }
                txtId.Enabled = false;
                txtNombre.Enabled = false;
                txtGrupo.Enabled = false;
                dtpFechaModificacion.Enabled = false;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // DML Eliminacion 
            //llamar al storeProcedure y la conexion 
            SqlCommand cmd = new SqlCommand("sp_EliminarDepartamento", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conn.Open();
                using (cmd)
                {
                    cmd.Parameters.Add(new SqlParameter("@departmentID", SqlDbType.SmallInt));
                    cmd.Parameters["@departmentID"].Value = txtId.Text;
                    // Eliminación de la moneda
                    if (txtId.Text == "")
                    {
                        MessageBox.Show("Debe buscar un dato que si esté en la base para eliminar", "Información");
                    }
                    else
                    {
                        //se le pregunta si desea eliminar
                        DialogResult Respuesta= MessageBox.Show("¿Está seguro que desea eliminar el registro seleccionado ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if(Respuesta == DialogResult.Yes){
                            cmd.ExecuteNonQuery();
                            lblEstado.Text = "¡Grupo eliminado satisfactoriamente!";
                            Limpiar();
                        }
                        else { Limpiar(); }
                    }
                }
      
            }
            catch(SqlException ex) { MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepción"); }
            finally
            { // Cerrar la conexión
                conn.Close();
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void Limpiar() {
            //Limpia todos los campos que almacenan texto
            txtNombre.Clear();
            txtId.Text = "";
            txtGrupo.Clear();
            lblEstado.Text = "";
            dtpFechaModificacion.Text = "";
            txtId.Focus();
            txtId.Enabled = true;
            txtNombre.Enabled = true;
            txtGrupo.Enabled = true;
            dtpFechaModificacion.Enabled = true;
        }
    }
}
