using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MatrixProcessor.MatrixTools
{
    public static class MatrixWriter<T> 
        where T: class, ISerializable, ISemiRing, new()
    {
        public static void Write(Matrix<T> matrix, string output)
        {
            List<string> lines = new List<string>();
            List<string> line = new List<string>();
            StringBuilder build = new StringBuilder();

            for (int i = 0; i < matrix.Height; i++)
            {
                line.Clear();
                build.Clear();
                for (int j = 0; j < matrix.Width; j++)
                    line.Add(matrix[i,j].ToWord());
                build.AppendJoin(' ', line);
                lines.Add(build.ToString());
            }
            File.WriteAllLines(output+".txt", lines);
        }
    }
}
