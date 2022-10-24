using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixMultiplier;


namespace MatrixTest
{
    [TestClass]
    public class MatrixTest
    {
        static int[,] tab1 = new int[,] { { 1, -1 },
                                            { 0, 0 },
                                            { -1, 1 } };

        static int[,] tab2 = new int[,] { { 1, 0, -1 },
                                            { -1, 0, 1 } };

        static int[,] tab3 = new int[,] { { 2, 0, -2 },
                                            { 0, 0, 0 },
                                            { -2, 0, 2 } };

        static Matrix matrix1 = new Matrix(tab1); 
        static Matrix matrix2 = new Matrix(tab2); 
        static Matrix matrix3 = new Matrix(tab3); 

        [TestMethod]
        public void GetBodyTest()
        {
            Assert.AreEqual(tab1, matrix1.GetBody());
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Assert.AreEqual(matrix1 * matrix2, matrix3);
        }

        [TestMethod]
        public void InvaldMatrixMultiplicationTest()
        {
            Assert.ThrowsException<ArgumentException>(delegate { Matrix result = matrix1 * matrix3; });
        }
    }
}
