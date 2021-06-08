using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modelo
{
    int pasoAnterior;

    public int CalcularPuntuacionTotal(int[,] bolosTirados)
    {
        int puntajeTotal = 0;
        for (int bolosTiradosTurnoActual = 0; bolosTiradosTurnoActual < bolosTirados.GetLength(0); bolosTiradosTurnoActual++)
        {
            pasoAnterior = bolosTiradosTurnoActual - 1;
            // check if strike
            if (bolosTiradosTurnoActual > 0 && bolosTirados[pasoAnterior, 0] == 10)
                puntajeTotal += bolosTirados[bolosTiradosTurnoActual, 0] + bolosTirados[bolosTiradosTurnoActual, 1];

            // check if spare
            else if (bolosTiradosTurnoActual > 0 && bolosTirados[pasoAnterior, 0] + bolosTirados[pasoAnterior, 1] == 10)
                puntajeTotal += bolosTirados[bolosTiradosTurnoActual, 0];

            for (int lot = 0; lot < bolosTirados.GetLength(1); lot++)
                puntajeTotal += bolosTirados[bolosTiradosTurnoActual, lot];
        }
        return puntajeTotal;
    }
}