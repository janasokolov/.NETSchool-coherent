using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrixes
{
    public class DiagonalMatrix
    {
        private int[] diagonalMatrixElements;
        public int Size { get; }

        public DiagonalMatrix(params int[] diagonalElements)
        {
            if (diagonalElements == null)
            {
                Size = 0;
                diagonalElements = new int[Size];
            }
            else
            {
                Size = diagonalElements.Length;
                diagonalMatrixElements = new int[Size];
                Array.Copy(diagonalElements, diagonalMatrixElements, Size);
            }
        }

        public int Track()
        {
            int sum = 0;
            foreach (var element in diagonalMatrixElements)
            {
                sum += element;
            }

            return sum;
        }

        public override bool Equals(object? obj)
        {
            if(obj is DiagonalMatrix compareMatrix && compareMatrix.Size == Size)
            {
                for (int i = 0; i < Size; i++)
                {
                    if (diagonalMatrixElements[i] != compareMatrix.diagonalMatrixElements[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
