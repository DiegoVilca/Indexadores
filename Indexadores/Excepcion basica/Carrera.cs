using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_basica
{
    public class Carrera
    {
        public List<Auto> listaAutos;
        public string autodromo;

        //constructor
        public Carrera(string nombreAutodromo)
        {
            this.autodromo = nombreAutodromo;
            listaAutos = new List<Auto>();
        }


        //metodo 

        public void CorrerCarrera()
        {
            if (this.listaAutos.Count > 0)
            {
                foreach (Auto item in this.listaAutos)
                {
                    item.Andar();
                }
            }
            else
            {
                throw new Exception(); 
            }
        }

    }
}
