using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ModeloTest
    {
        Modelo modelo;

        [SetUp]
        public void Setup()
        {
            modelo = new Modelo();
        }

        [Test]
        public void PointsWithoutStrikeAndSpare()
        {
            int[,] bolosTirados = new int[10, 2] {
                { 5, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            int puntajeTotal = modelo.CalcularPuntuacionTotal(bolosTirados);
            Assert.AreEqual(53, puntajeTotal);
        }

        [Test]
        public void PointsWithoutStrikeAndSpareAgain()
        {
            int[,] bolosTirados = new int[10, 2] {
                { 5, 3 }, { 5, 0 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            int puntajeTotal = modelo.CalcularPuntuacionTotal(bolosTirados);
            Assert.AreEqual(52, puntajeTotal);
        }

        [Test]
        public void PointsWithSpare()
        {
            int[,] bolosTirados = new int[10, 2] {
                { 5, 5 }, { 5, 0 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            int puntajeTotal = modelo.CalcularPuntuacionTotal(bolosTirados);
            Assert.AreEqual(59, puntajeTotal);
        }

        [Test]
        public void PointsWithStrike()
        {
            int[,] bolosTirados = new int[10, 2] {
                { 10, 0 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            int puntajeTotal = modelo.CalcularPuntuacionTotal(bolosTirados);
            Assert.AreEqual(61, puntajeTotal);
        }

        [Test]
        public void PointsSpareInLastThrow()
        {
            int[,] bolosTirados = new int[11, 2] {
                { 4, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 5, 5 }, { 1, 0 }
            };
            int puntajeTotal = modelo.CalcularPuntuacionTotal(bolosTirados);
            Assert.AreEqual(57, puntajeTotal);
        }

        [Test]
        public void PointsStrikeInLastThrow()
        {
            int[,] bolosTirados = new int[11, 2] {
                { 4, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 10, 0 }, { 5, 3 }
            };
            int puntajeTotal = modelo.CalcularPuntuacionTotal(bolosTirados);
            Assert.AreEqual(71, puntajeTotal);
        }
    }
}
