using System.Runtime.CompilerServices;

namespace ShapesTestLib.Shapes
{
    public abstract class Shape
    {

        protected Shape([CallerMemberName]string name = "")
        {
            Name = name;
        }

        public string Name { get; }
        public abstract double GetArea();

        public override string ToString()
        {
            return $"Shape: {Name}, Area: {GetArea()}";
        }
    }
}
