﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BorodulinMS.Sprint6.Review.V6.Lib;

namespace Tyuiu.BorodulinMS.Sprint6.Review.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            int[,] array = {
            { 2, 1, 3 },
            { 4, 1, 6 },
            { 7, 1, 9 }
        };
            int n1 = 1;
            int n2 = 10;
            int k = 0;
            int l = 2;
            int c = 2;


            int result = ds.GetMatrix(array, n1, n2, c, k, l);
            Assert.AreEqual(2, result);

        }
    }
}
