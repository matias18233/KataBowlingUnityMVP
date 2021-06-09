using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.UI;

namespace Assets.Script.Presentador
{
    interface IVista
    {
        string[,] ObtenerValoresDesdeInput();
        void MostrarResultadoTotal(string resultado);
    }
}
