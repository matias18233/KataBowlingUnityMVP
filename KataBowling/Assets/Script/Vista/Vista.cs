﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vista : MonoBehaviour
{
    [SerializeField] private Text campo1;
    [SerializeField] private Text campo2;
    [SerializeField] private Text campo3;
    [SerializeField] private Text campo4;
    [SerializeField] private Text campo5;
    [SerializeField] private Text campo6;
    [SerializeField] private Text campo7;
    [SerializeField] private Text campo8;
    [SerializeField] private Text campo9;
    [SerializeField] private Text campo10;
    [SerializeField] private Text campo11;
    [SerializeField] private Text campo12;
    [SerializeField] private Text campo13;
    [SerializeField] private Text campo14;
    [SerializeField] private Text campo15;
    [SerializeField] private Text campo16;
    [SerializeField] private Text campo17;
    [SerializeField] private Text campo18;
    [SerializeField] private Text campo19;
    [SerializeField] private Text campo20;
    [SerializeField] private Text campo21;
    [SerializeField] private Text campo22;
    [SerializeField] private Text puntajeTotal;

    private void Start()
    {
        campo21.text = "0";
        //campo21.enabled = false;
        campo22.text = "0";
        //campo22.enabled = false;
    }
    private void Update()
    {

    }

    public void btnCalcular()
    {
        string[,] turnosCadena = new string[11, 2] {
            { campo1.text, campo2.text },
            { campo3.text, campo4.text },
            { campo5.text, campo6.text },
            { campo7.text, campo8.text },
            { campo9.text, campo10.text },
            { campo11.text, campo12.text },
            { campo13.text, campo14.text },
            { campo15.text, campo16.text },
            { campo17.text, campo18.text },
            { campo19.text, campo20.text },
            { campo21.text, campo22.text }
        };
        int[,] turnos = new int[turnosCadena.GetLength(0), turnosCadena.GetLength(1)];

        for (int f = 0; f < turnosCadena.GetLength(0); f++)
        {
            for (int c = 0; c < turnosCadena.GetLength(1); c++)
            {
                int number;
                if (int.TryParse(turnosCadena[f, c], out number)) turnos[f, c] = number;
            }
        }
        Presentador presentador = new Presentador();
        puntajeTotal.text = presentador.CalcularPuntaje(turnos).ToString();
    }
}