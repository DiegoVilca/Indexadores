using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_basica
{
    public class MiExcepcion :Exception
    {
        public DateTime horaDeLaExcepcion;
        public string textoHoraDeLaExcepcion;


        public MiExcepcion(string mensaje, DateTime hora) :base(mensaje)
        {
            this.horaDeLaExcepcion = hora;
        }

        public MiExcepcion(string mensaje, DateTime hora, Exception excAnterior) :base(mensaje, excAnterior)
        {
            this.horaDeLaExcepcion = hora;
        }



        
    }
}
