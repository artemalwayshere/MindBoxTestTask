namespace MindBoxTestTask.Library.GeometricFigures
{
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException($"{radius} радиус должен быть больше нуля", nameof(radius));
     
            _radius = radius;
        }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }
}
