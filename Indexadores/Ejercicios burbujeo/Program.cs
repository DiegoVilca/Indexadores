using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_burbujeo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            

            try
            {
                MiClase unaClase = new MiClase();
                unaClase.Mostrar("Diego");
                
            }
            catch (Exception ex)
            {
                Exception miExcp = new Exception("program");

                throw new Exception(ex.InnerException.Message + miExcp.Message);
            }


            Console.ReadKey();
        }
    }
}
