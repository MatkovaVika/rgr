using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
  
            int[,] array = new int[,] { { 1, 1, 1 }, { 2, -3, 4 } };
            int[,] expected = new int[,] { { 1, 6, 0, 0 } };
            int n = 2;
            int m = 3;

            Program s = new Program();

            int[,] ij_elem = s.Search(array, n, m);

            CollectionAssert.AreEqual(expected, ij_elem);
        }

        [TestMethod]
        public void Search_11_1234__23_returned02()
        {
            int[,] array = new int[,] { { 1, -1, 1 }, { 2, 3, 4 } };
            int[,] expected = new int[,] { { 0, 2, 0, 0 } };
            int n = 2;
            int m = 3;

            Program s = new Program();

            int[,] ij_elem = s.Search(array, n, m);

            CollectionAssert.AreEqual(expected, ij_elem);
        }

        [TestMethod]
        public void Search_11_12_34__23_returned02_16()
        {
            int[,] array = new int[,] { { 1, 1, -1 }, { 2, -3, 4 } };
            int[,] expected = new int[,] { { 0, 2 }, { 1, 6, }, { 0, 0 } };
            int n = 2;
            int m = 3;

            Program s = new Program();

            int[,] ij_elem = s.Search(array, n, m);

            CollectionAssert.AreEqual(expected, ij_elem);
        }
    }
}
