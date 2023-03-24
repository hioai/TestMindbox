using ClassLibraryFigures;

namespace TestFigures
{
    [TestClass]
    public class FigureTest
    {
        [TestMethod]
        public void TriangleSquare_Test_TriangleDosntExist()
        {

            var figure = new Figure();
            double[] triangle = new double[3] { 2, 2.4, 5 };
            double expected = -1;

            double result = figure.TriangleSquare(triangle);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TriangleSquare_Test_SquareRandom()
        {
            var figure = new Figure();
            double[] triangle = new double[3] { 3, 4, 5 };
            double expected = 6;
            

            double result = figure.TriangleSquare(triangle);
            Assert.AreEqual(expected, result);
        }





    }
}