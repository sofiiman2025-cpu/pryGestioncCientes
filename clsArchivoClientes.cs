using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGestioncCientes
{
    internal class clsArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";

        public void Grabar(String Cod, String Nom, String Deu, String Lim)
        { 
        StreamWriter AD = new StreamWriter(NombreArchivo, true);

            AD.Write(Cod + ";" + Nom + ";" + Deu + ";");
            AD.WriteLine(Lim);
            AD.Close();
            AD.Dispose();
        }

        public void Listar(DataGridView Grilla) 
        {
            string DatosLeidos = "";
            string[] VectorDatos = new string[4];

            StreamReader AD = new StreamReader(NombreArchivo);
        
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null) 
            {

                VectorDatos = DatosLeidos.Split(';');

                Grilla.Rows.Add(VectorDatos[0], VectorDatos[1], 
                    VectorDatos[2], VectorDatos[3]);

                DatosLeidos = AD.ReadLine();

            }

            AD.Close();
            AD.Dispose();

        }
    }

}
