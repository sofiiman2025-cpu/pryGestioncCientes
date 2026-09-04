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
    public partial class frmCargarClientes : Form
    {
        public frmCargarClientes()
        {
            InitializeComponent();
        }
        clsArchivoClientes objArchivo = new clsArchivoClientes();

        private void frmCargarClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
