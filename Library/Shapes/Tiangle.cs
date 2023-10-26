namespace ShapesTestLib.Shapes {
    public class Triangle : Shape {

        public Triangle(double sideOne, double sideTwo, double sideThree) : base(nameof(Triangle)) {
            if (sideOne < 0 || sideTwo < 0 || sideThree < 0) {
                throw new ArgumentException("Triangle sides length must be positive");
            }
            if (sideOne + sideTwo <= sideThree || sideTwo + sideThree <= sideOne || sideThree + sideOne <= sideTwo) {
                throw new ArgumentException("Any side of triangle must be grate than sum of other two");
            }
            _sideOne = sideOne;
            _sideTwo = sideTwo;
            _sideThree = sideThree;
        }

        internal override double GetArea() {
            if (_sideOne == 0 || _sideTwo == 0 || _sideThree == 0) { return 0; }
            var p = (_sideOne + _sideTwo + _sideThree) / 2;
            return Math.Sqrt(p * (p - _sideOne) * (p - _sideTwo) * (p - _sideThree));
        }

        private readonly double _sideOne;
        private readonly double _sideTwo;
        private readonly double _sideThree;
    }
}
