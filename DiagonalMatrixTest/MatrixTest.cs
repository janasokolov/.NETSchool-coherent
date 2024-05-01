using DiagonalMatrixes;

namespace DiagonalMatrixTest;

[TestClass]
public class MatrixTest
{
    [TestMethod]
    public void DiagonalMatrix_ReturnSum()
    {
        DiagonalMatrix diagonalMatrix1 = new DiagonalMatrix(1, 3, 5);
        int sum = diagonalMatrix1.Track();
        Assert.AreEqual(9, sum);
    }

    [TestMethod]
    public void DiagonalMatrix_AreEqual_Positive()
    {
        DiagonalMatrix diagonalMatrix1 = new DiagonalMatrix(1, 3, 5);
        DiagonalMatrix diagonalMatrix2 = new DiagonalMatrix(1, 3, 5);
        Assert.IsTrue(diagonalMatrix1.Equals(diagonalMatrix2));
    }

    [TestMethod]
    public void DiagonalMatrix_AreEqual_Negative()
    {
        DiagonalMatrix diagonalMatrix1 = new DiagonalMatrix(1, 3, 2);
        DiagonalMatrix diagonalMatrix2 = new DiagonalMatrix(1, 3, 5);
        Assert.IsFalse(diagonalMatrix1.Equals(diagonalMatrix2));
    }
}