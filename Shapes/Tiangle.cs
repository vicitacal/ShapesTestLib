namespace ShapesTestLib.Shapes {
    internal class Triangle : Shape {

        public Triangle(double sideOne, double sideTwo, double sideThree) : base() {
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
        }

        public override double GetArea() {
            var p = (_sideOne + _sideTwo + _sideThree) / 2;
            return Math.Sqrt(p * (p - _sideOne) * (p - _sideTwo) * (p - _sideThree));
        }

        private readonly double _sideOne;
        private readonly double _sideTwo;
        private readonly double _sideThree;
    }
}
