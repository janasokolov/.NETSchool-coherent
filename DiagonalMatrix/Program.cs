namespace DiagonalMatrixes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiagonalMatrix diagonalMatrix1 = new DiagonalMatrix(1, 3, 5);
            DiagonalMatrix diagonalMatrix2 = new DiagonalMatrix(2, 4, 6);

            int diagonalMatrix1Sum = diagonalMatrix1.Track();
            int diagonalMatrix2Sum = diagonalMatrix2.Track();

            Console.WriteLine("Are equal? " + diagonalMatrix1.Equals(diagonalMatrix2));
        }
    }
}

