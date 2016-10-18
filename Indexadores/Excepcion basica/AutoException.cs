using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_basica
{
    public class AutoException :MiExcepcion
    {

        Auto unAuto;

        public AutoException(string mensaje, DateTime hora,Auto auto, Exception excAnterior) :base(mensaje, hora, excAnterior)
        {
            this.unAuto = auto;
        }
    }
}
