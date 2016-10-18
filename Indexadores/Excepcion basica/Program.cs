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

        //     //string dato;
        //     //int numero;

        //    //LanzarError();

        //    try
        //    {
        //        //Encierro solo lo que me puede dar error
        //        //dato = Console.ReadLine();
        //        //numero = int.Parse(dato);
        //        //numero = numero / numero;
        //        LanzarError();
        //        Operar();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        //throw;
        //    }
        //    finally  
        //    { 

        //    }
            
        //    //el ultimo catch debe ser el mas general de todos

        //    Console.ReadKey();
        //}

        //static void Operar()
        //{
        //    string dato;
        //    int numero;


        //    try
        //    {
        //        dato = Console.ReadLine();
        //        numero = int.Parse(dato);
        //        numero = numero / numero;

        //    }
        //    catch (Exception ex)
        //    {
        //        //Operaciones para guardar informacion de la excepcion

        //        throw new Exception("Se quedo sin internet");
        //    }
        //}

        //static void LanzarError()
        //{
        //    throw new Exception("Se quedo sin memoria ram");


            Carrera miCarrera = new Carrera("Autodromo 1");
            Auto miAuto1 = new Auto("Ford", 1);
            Auto miAuto2 = new Auto("Chevy", 2);
            Auto miAuto3 = new Auto("Fiat", 3);
            Auto miAuto4 = new Auto("Peugeot", 4);

            miCarrera.listaAutos.Add(miAuto1);
            miCarrera.listaAutos.Add(miAuto2);
            miCarrera.listaAutos.Add(miAuto3);
            miCarrera.listaAutos.Add(miAuto4);

            miAuto1.listaRuedas.Add(new Rueda("firestone"));
            miAuto1.listaRuedas.Add(new Rueda("michelin"));
            miAuto1.listaRuedas.Add(new Rueda("dunlop"));
            miAuto1.listaRuedas.Add(new Rueda("zarasa"));

            miAuto2.listaRuedas.Add(new Rueda("firestone"));
            miAuto2.listaRuedas.Add(new Rueda("michelin"));
            miAuto2.listaRuedas.Add(new Rueda("dunlop"));
            miAuto2.listaRuedas.Add(new Rueda("zarasa"));

            miAuto3.listaRuedas.Add(new Rueda("firestone"));
            miAuto3.listaRuedas.Add(new Rueda("michelin"));
            miAuto3.listaRuedas.Add(new Rueda("dunlop"));
            miAuto3.listaRuedas.Add(new Rueda("zarasa"));

            miAuto4.listaRuedas.Add(new Rueda("firestone"));
            miAuto4.listaRuedas.Add(new Rueda("michelin"));
            miAuto4.listaRuedas.Add(new Rueda("dunlop"));
            miAuto4.listaRuedas.Add(new Rueda("zarasa"));

            //miAuto1.Andar();
            //miCarrera.CorrerCarrera();


            try
            {
                miCarrera.CorrerCarrera();
            }
            catch (AutoException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (PinchaduraException ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (MiExcepcion ex)
            {

                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            



            Console.ReadKey();


            //1- constructor - instancia - program
            //2- static - instancia - program
            //3- instancia - static - constructor - program
            //4- 3 metodos static - program
            //5- 3 instancias- static- constructor- program

        }

    }
}
