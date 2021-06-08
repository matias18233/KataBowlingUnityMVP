using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presentador
{
    public int CalcularPuntaje(int[,] turnos)
    {
        Modelo modelo = new Modelo();
        return modelo.GetScore(turnos);
    }
}
