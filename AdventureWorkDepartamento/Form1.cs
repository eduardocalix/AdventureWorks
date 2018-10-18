using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorkDepartamento
{
    public partial class frmOperaciones : Form
    {
        public frmOperaciones()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmListarDepartamentos listar = new frmListarDepartamentos();
            listar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCrearDepartamentos crear = new frmCrearDepartamentos();
            crear.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEliminarDepartamentos frmEliminar = new frmEliminarDepartamentos();
            frmEliminar.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            frmActualizar actualizar = new frmActualizar();
            actualizar.ShowDialog();
        }
    }
}
