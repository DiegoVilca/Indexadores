using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_basica
{
    class Program
    {
        static void Main(string[] args)
        {

             //string dato;
             //int numero;

            //LanzarError();

            try
            {
                //Encierro solo lo que me puede dar error
                //dato = Console.ReadLine();
                //numero = int.Parse(dato);
                //numero = numero / numero;
                LanzarError();
                Operar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            finally  
            { 

            }
            
            //el ultimo catch debe ser el mas general de todos

            Console.ReadKey();
        }

        static void Operar()
        {
            string dato;
            int numero;


            try
            {
                dato = Console.ReadLine();
                numero = int.Parse(dato);
                numero = numero / numero;

            }
            catch (Exception ex)
            {
                //Operaciones para guardar informacion de la excepcion

                throw new Exception("Se quedo sin internet");
            }
        }

        static void LanzarError()
        {
            throw new Exception("Se quedo sin memoria ram");
        }

    }
}
