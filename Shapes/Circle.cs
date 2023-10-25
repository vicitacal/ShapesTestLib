namespace ShapesTestLib.Shapes {
    internal class Circle : Shape {
        protected Circle(double radius) : base() {
            _radius = radius;
        }

        public override double GetArea() => Math.PI * Math.Pow(2, _radius);

        private readonly double _radius;
    }
}
