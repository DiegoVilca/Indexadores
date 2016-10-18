using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_basica
{
    public class PinchaduraException :MiExcepcion
    {
        
        public string marca;

        public PinchaduraException(string mensaje, DateTime hora, string marca, Exception excAnterior) :base(mensaje, hora, excAnterior)
        {
            this.marca = marca;
        }

        public PinchaduraException(string mensaje, DateTime hora, string marca) :base(mensaje, hora)
        {
            this.marca = marca;
        }
    }
}
