using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;


namespace WSubastas
{
    internal class clsParticipante : clsSubasta
    {
        public clsParticipante(string producto, double precioinicial, int duracion, string reglas)
           : base(producto, precioinicial, duracion, reglas)
        {


        }
    }
}
