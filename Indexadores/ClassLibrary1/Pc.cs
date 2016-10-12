using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pc
    {
        public string marca;
        public string so;
        public static int contadorPc;
        public int numero;



        static Pc ()
	    {
            contadorPc = 1;
	    }

        private Pc(string marca)
        {
            this.marca = marca;
            this.so = "Windows";
            this.numero = contadorPc;
            contadorPc++;
        }

        

        //public Pc(string marca, string so) :this(marca)
        //{
        //    this.so = so;
        //}

        public static implicit operator Pc(string marca)
        {
            return new Pc(marca);
        }

    }
}
