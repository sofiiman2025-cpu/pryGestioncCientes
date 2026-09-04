using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestioncCientes
{
    public partial class frmListadodeClientes : Form
    {
        public frmListadodeClientes()
        {
            InitializeComponent();
        }
        clsArchivoClientes objArchivo = new clsArchivoClientes();


        private void grpConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmListadodeClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            objArchivo.Listar(dgvDatos);
        }
    }
}
