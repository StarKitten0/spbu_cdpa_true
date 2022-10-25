using System;

namespace MatrixProcessor.MatrixTools
{
    public static class TransitiveClosureProcessor
    {
        public static Matrix<MyBoolean> Process(Matrix<MyBoolean> matrix)
        {
            Matrix<MyBoolean> result = new Matrix<MyBoolean>(matrix.GetBody());

            for (int i = 0; i < matrix.Height; i++)
                for (int j = 0; j < matrix.Width; j++)
                    for (int k = 0; k < matrix.Height; k++)
                        result[i, j] = result[i, j].Add(result[i, k].Multip(result[k, j])) as MyBoolean;
            return result;
        }
    }
}
