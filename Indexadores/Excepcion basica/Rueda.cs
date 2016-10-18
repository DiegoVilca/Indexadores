using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_basica
{
    public class Rueda
    {
        public string marca;
        static Random numeroRandom;


        public Rueda(string marca)
        {
            this.marca = marca;
        }

        static Rueda()
        {
            numeroRandom = new Random();
        }

        //metodos

        public void Pinchar()
        {
            throw new PinchaduraException("Rueda pinchada", DateTime.Now, this.marca);
        }


        public void Rodar()
        {
            
            int rdm;

            rdm = numeroRandom.Next(1, 10);

            if (rdm == 5)
            {
                Pinchar();
            }

            Console.WriteLine(rdm.ToString());
        }

    }
}
