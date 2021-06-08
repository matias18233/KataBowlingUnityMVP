using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script.Presentador
{
    interface IVista
    {
        void MostrarResultadoTotal(string resultado);
        string[,] ObtenerValoresDesdeInput();
    }
}
