namespace ShapesTestLib.Shapes {
    public class Circle : Shape {
        public Circle(double radius) : base(nameof(Circle)) {
            _radius = Math.Abs(radius);
        }

        internal override double GetArea() => Math.PI * Math.Pow(_radius, 2);

        private readonly double _radius;
    }
}
