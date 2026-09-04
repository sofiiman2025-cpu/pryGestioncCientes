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
        StreamWriter AD = new StreamWriter(NombreArchivo, true);

            AD.Write(Cod + ";" + Nom + ";" + Deu + ";");
            AD.WriteLine(Lim);
             AD.Close();
            AD.Dispose();
        }

        public void Listar() 
        {
            string DatosLeidos = "";


            StreamReader AD = new StreamReader(NombreArchivo);
        
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null) 
            {


                DatosLeidos = AD.ReadLine();

            }

            AD.Close();
            AD.Dispose();

        }
    }

}
