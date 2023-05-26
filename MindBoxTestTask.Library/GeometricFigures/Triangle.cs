namespace MindBoxTestTask.Library.GeometricFigures
{
    public class Triangle : IFigure
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        /// <exception cref="ArgumentException"></exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0) throw new ArgumentException($"{sideA} сторна должна быть больше нуля", nameof(sideA));

            if (sideB <= 0) throw new ArgumentException($"{sideB} сторна должна быть больше нуля", nameof(sideB));

            if (sideC <= 0) throw new ArgumentException($"{sideC} must be greater then 0", nameof(sideC));

            if ((sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA) == false)
            {
                throw new ArgumentException("Треугольник с указанными сторонами не может существовать");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double GetSquare()
        {
            var halfPerimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(halfPerimeter
                             * (halfPerimeter - _sideA)
                             * (halfPerimeter - _sideB)
                             * (halfPerimeter - _sideC));
        }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsRightTriangle()
        {
            double maxLengthSide = Math.Max(Math.Max(_sideA, _sideB), _sideC);
            double minLengthSide = Math.Min(Math.Min(_sideA, _sideB), _sideC);
            double midLengthSide = _sideA + _sideB + _sideC - maxLengthSide - minLengthSide;

            return ((minLengthSide * minLengthSide + midLengthSide * midLengthSide) == maxLengthSide * maxLengthSide);
        }
    }
}
