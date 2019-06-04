using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] array = new int[,] { { 1, 1, 1 }, { 2, -3, 4 } };
            int[,] expected = new int[,] { { 1, 1, 1 }, { 2, -3, 4 }, { 6, 6, 6 } };
            int n = 2;
            int m = 3;

            Program c = new Program();

            int[,] ij_elem = c.Search(array, n, m);
            int[,] actual = c.Change(array, ij_elem, n, m);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Change_2()
        {
            int[,] array = new int[,] { { 1, 1, 1 }, { 2, 3, 4 }, { 5, 6, -8 } };
            int[,] expected = new int[,] { { 1, 1, 1 }, { 2, 3, 4 }, { 5, 6, -8 }, { 11, 11, 11 } };
            int n = 3;
            int m = 3;

            Program c = new Program();

            int[,] ij_elem = c.Search(array, n, m);
            int[,] actual = c.Change(array, ij_elem, n, m);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Change_3()
        {
            int[,] array = new int[,] { { 1, -1, 1 }, { 2, -3, 4 } };
            int[,] expected = new int[,] { { 1, -1, 1 }, { 2, 2, 2 }, { 2, -3, 4 }, { 6, 6, 6 } };
            int n = 2;
            int m = 3;

            Program c = new Program();

            int[,] ij_elem = c.Search(array, n, m);
            int[,] actual = c.Change(array, ij_elem, n, m);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
