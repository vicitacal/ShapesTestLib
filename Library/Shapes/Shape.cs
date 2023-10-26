using System.Runtime.CompilerServices;

namespace ShapesTestLib.Shapes
{
    public abstract class Shape
    {

        protected Shape(string name)
        {
            Name = name;
        }

        public string Name { get; }
        internal abstract double GetArea();

        public override string ToString()
        {
            return $"Shape: {Name}, Area: {GetArea()}";
        }
    }
}
