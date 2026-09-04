using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryGestioncCientes
{
    internal class clsArchivoClientes
    {
        public string NombreArchivo = "Clientes.csv";

        public void Grabar(String Cod, String Nom, String Deu, String Lim)
        { 
        StreamWriter AD = new StreamWriter(NombreArchivo);

            AD.Write(Cod + "," + Nom + "," + Deu + ",");
            AD.WriteLine(Lim);
             AD.Close();
            AD.Dispose();
        }
    }

}
