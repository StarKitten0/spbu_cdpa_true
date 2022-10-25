using System;

namespace MatrixMultiplier
{
    public class Matrix
    {
        private int[,] Array;
        public int height => Array.GetLength(0);
        public int width => Array.GetLength(1);
        public int this[int index1, int index2] { get { return Array[index1, index2]; } set { Array[index1, index2] = value; } }

        public Matrix(int height, int width)
        {
            Array = new int[height, width];
        }

        public Matrix(int[,] Array)
        {
            this.Array = Array;
        }

        public static Matrix operator *(Matrix operand1, Matrix operand2)
        {
            if (operand1.width != operand2.height)
                throw new ArgumentException("size incompatibility");
            Matrix result = new Matrix(operand1.height, operand2.width);
            for (int i = 0; i < operand1.height; i++)
                for (int j = 0; j < operand2.width; j++)
                    for (int t = 0; t < operand1.width; t++)
                        result[i, j] += operand1[i, t] * operand2[t, j];
            return result;
        }

        public static Matrix operator +(Matrix operand1, Matrix operand2)
        {
            if (operand1.width != operand2.width || operand1.height != operand2.width)
                throw new ArgumentException("size incompatibility");
                Matrix result = new Matrix(operand1.width, operand1.height);
                for (int i = 0; i < operand1.height; i++)
                    for (int j = 0; j < operand1.width; j++)
                        result[i, j] = operand1[i, j] + operand2[i, j];
                return result;
        }

        public int[,] GetBody() => Array;

        public override bool Equals(object obj)
        {
            if (!(obj is Matrix))
                throw new ArgumentException("Object is not Matrix");
            Matrix objToCompare = obj as Matrix;
            if (objToCompare.width != this.width || objToCompare.height != this.height)
                return false;
            for (int i = 0; i < objToCompare.height; i++)
                for (int j = 0; j < objToCompare.width; j++)
                    if (this.Array[i, j] != objToCompare[i, j])
                        return false;
            return true;
        }

        public override int GetHashCode()
        {
            return Array.GetHashCode();
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                    result += Array[i, j] + " ";
                result += '\n';
            }
            return result;
        }
    }
}
