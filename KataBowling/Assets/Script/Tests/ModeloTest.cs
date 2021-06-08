using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class ModeloTest
    {
        Modelo modelo1;
        [SetUp]
        public void Setup()
        {
            modelo1 = new Modelo();

        }
        [Test]
        public void PointsWithoutStrikeAndSpare()
        {
            int[,] scores = new int[10, 2] {
                { 5, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            int points = modelo1.GetScore(scores);
            Assert.AreEqual(53, points);
        }
        [Test]
        public void PointsWithoutStrikeAndSpareAgain()
        {
            int[,] scores = new int[10, 2] {
                { 5, 3 }, { 5, 0 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            int points = modelo1.GetScore(scores);
            Assert.AreEqual(52, points);
        }
        [Test]
        public void PointsWithSpare()
        {
            int[,] scores = new int[10, 2] {
                { 5, 5 }, { 5, 0 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            int points = modelo1.GetScore(scores);
            Assert.AreEqual(59, points);
        }
        [Test]
        public void PointsWithStrike()
        {
            int[,] scores = new int[10, 2] {
                { 10, 0 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 4, 3 }
            };
            int points = modelo1.GetScore(scores);
            Assert.AreEqual(61, points);
        }
        [Test]
        public void PointsSpareInLastThrow()
        {
            int[,] scores = new int[11, 2] {
                { 4, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 5, 5 }, { 1, 0 }
            };
            int points = modelo1.GetScore(scores);
            Assert.AreEqual(57, points);
        }
        [Test]
        public void PointsStrikeInLastThrow()
        {
            int[,] scores = new int[11, 2] {
                { 4, 3 }, { 5, 1 }, { 5, 0 }, { 3, 4 }, { 0, 0 }, { 1, 2 }, { 3, 6 }, { 0, 1 }, { 4, 3 }, { 10, 0 }, { 5, 3 }
            };
            int points = modelo1.GetScore(scores);
            Assert.AreEqual(71, points);
        }
    }
}
