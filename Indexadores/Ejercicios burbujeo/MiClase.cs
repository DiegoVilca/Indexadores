using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_burbujeo
{
    public class MiClase
    {
        public string nombre;

        public MiClase()
        {
            
        }

        public MiClase(string nombre)
        {
            this.nombre = nombre;
            throw new Exception("Parti del constructor");
        }

        public void Mostrar(string nombre)
        {
            try
            {
                
                MiClase unaClase = new MiClase(nombre);
            }
            catch (Exception ex)
            {
                Exception excInstancia = new Exception("Instancia");

                throw new Exception(ex.InnerException.Message + excInstancia.Message);
            }
        }

    }
}
