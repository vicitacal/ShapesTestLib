using ShapesTestLib;
using ShapesTestLib.Shapes;

namespace ExampleProject;

public class Program {

    public static void Main() {
        Console.WriteLine(AreaCalculator.GetArea(new Circle(33.88)));
        Console.WriteLine(AreaCalculator.GetArea(new Circle(12.35)));
        //Console.WriteLine(AreaCalculator.GetArea(new Triangle(10, 10, 10)));
        Console.WriteLine(AreaCalculator.GetArea(new Triangle(0, 5, 10)));
    }

}
