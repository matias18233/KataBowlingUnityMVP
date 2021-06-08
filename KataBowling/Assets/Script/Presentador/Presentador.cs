using Assets.Script.Presentador;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Presentador
{
    private Modelo modelo = new Modelo();
    private IVista vista;

    public int[,] ConvertirArregloStringAInt(string[,] arregloString)
    {
        int[,] bolosTirados = new int[arregloString.GetLength(0), arregloString.GetLength(1)];

        for (int f = 0; f < arregloString.GetLength(0); f++)
        {
            for (int c = 0; c < arregloString.GetLength(1); c++)
            {
                int number;
                if (int.TryParse(arregloString[f, c], out number)) bolosTirados[f, c] = number;
            }
        }
        return bolosTirados;
    }

    public void ObtenerPuntajeTotal(IVista vista)
    {
        this.vista = vista;
        string[,] bolosTiradosString = this.vista.ObtenerValoresDesdeInput();
        int[,] bolosTirados = ConvertirArregloStringAInt(bolosTiradosString);
        int puntosTotal = modelo.CalcularPuntuacionTotal(bolosTirados);
        PresentarPuntosTotal(puntosTotal);
    }

    public void PresentarPuntosTotal(int puntosTotal)
    {
        this.vista.MostrarResultadoTotal(puntosTotal.ToString());
    }
}
