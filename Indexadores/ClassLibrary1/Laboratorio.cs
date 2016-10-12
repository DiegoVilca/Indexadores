using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Laboratorio
    {
        public string nombre;
        public List<Pc> listPc;

        public Laboratorio(string nombre)
        {
            this.nombre = nombre;
            listPc = new List<Pc>();
        }
        
        //indexador
        public Pc this[int indice]
        {
            get
            {

                if (indice > 0 || indice < this.listPc.Count)
                {
                    return this.listPc[indice];
                }
                else 
                {
                    return null;
                }
                
            }

            set
            {
                if (indice == this.listPc.Count)
                {
                    this.listPc.Add(value);
                }
                else
                {
                    if (indice >= 0 && indice < this.listPc.Count)
                    {
                        this.listPc[indice] = value;
                    }
                }
                
            }
        }
    }
}
