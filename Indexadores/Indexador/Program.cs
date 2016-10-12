using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Indexador
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pc pcUno = new Pc("Lg");
            //Pc pcDos = new Pc("Hp");
            Laboratorio miLab = new Laboratorio("lab1");

            //miLab[0] = pcUno;
            //miLab[1] = pcDos;

            miLab[0] = "LG";
            miLab[1] = "Exo";
            miLab[2] = "Toshiba";
            miLab[3] = "Vaio";

            for (int i = 0; i < miLab.listPc.Count; i++)
            {
                Console.WriteLine(miLab[i].marca +" "+miLab[i].numero );
            }

            Console.ReadKey();
        }
    }
}
