using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Clases
{
    class ClsArchivo
    {
        public string[] LeerArchivo(string archivo)
        {
            String[] lineas = File.ReadAllLines(archivo, Encoding.Default);
            return lineas;
        }

        public string LeerTodoArchivo(string archivo)
        {
            string ContendioArchivo;

            using (StreamReader reader = new StreamReader(archivo, Encoding.UTF7))
            {
                ContendioArchivo = reader.ReadToEnd();
            }
            return ContendioArchivo;
        }
    }
}
