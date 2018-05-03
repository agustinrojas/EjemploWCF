using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MiServcio
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class ServicioLibros : IServicioLibros
    {
        static List<string> lista = new List<string>();
        public void AddLibros(string nombre)
        {
            lista.Add(nombre);
        }

        public void BorrarLibros(string nombre)
        {
            lista.Remove(nombre);
        }

        public string[] ListaLibros()
        {
            return lista.ToArray();
        }
    }
}
