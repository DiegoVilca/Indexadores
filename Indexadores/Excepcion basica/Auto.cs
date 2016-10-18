using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_basica
{
    public class Auto
    {
        public string marca;
        public int numero;
        public List<Rueda> listaRuedas;


        //constructor

        public Auto(string marca, int numero)
        {
            this.marca = marca;
            this.numero = numero;
            listaRuedas = new List<Rueda>();
        }


        //metodo

        public void Andar()
        {
            if (listaRuedas.Count < 4)
            {
                throw new Exception();
            }
            else
            {
                

                try
                {

                    foreach (Rueda item in this.listaRuedas)
                    {
                        item.Rodar();
                    }


                }
                catch (PinchaduraException ex)
                {

                    throw new AutoException(ex.textoHoraDeLaExcepcion, ex.horaDeLaExcepcion, this, ex);
                }
            }


        }



    }
}
