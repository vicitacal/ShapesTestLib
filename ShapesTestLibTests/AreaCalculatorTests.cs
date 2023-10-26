using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesTestLib.Shapes;

namespace ShapesTestLib.Tests {
    [TestClass()]
    public class AreaCalculatorTests {
        [TestMethod()]
        [DataRow(10, 314.159)]
        [DataRow(58, 10568.318)]
        public void GetAreaCircleTest(double radius, double expected) {
            var targetShape = new Circle(radius);
            
            var result = Math.Round(AreaCalculator.GetArea(targetShape), 3);
            var expectedValue = Math.Round(expected, 3);

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod()]
        [DataRow(10, 10, 10, 43.301)]
        [DataRow(19, 37, 21, 140.382)]
        [DataRow(21, 19, 37, 140.382)]
        [DataRow(21, 19, -1, -1)]
        [DataRow(21, 19, 1000, -1)]
        public void GetAreaTriangleTest(double side1, double side2, double side3, double expected) {
            if (expected == -1) {
                Assert.ThrowsException<ArgumentException>(() => {
                    var targetShape = new Triangle(side1, side2, side3);
                });
            } else {
                var targetShape = new Triangle(side1, side2, side3);
                var actual = Math.Round(AreaCalculator.GetArea(targetShape), 3);
                var expectedValue = Math.Round(expected, 3);

                Assert.AreEqual(expectedValue, actual);
            }
        }
    }
}