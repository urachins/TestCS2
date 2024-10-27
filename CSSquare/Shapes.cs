namespace CSShapes
{
    //public interface IShape
    //{
    //    int GetSquare();
    //    void CheckValid();
    //}

    public abstract class Shapes 
    { 
        public abstract int GetSquare();
        public abstract void CheckValid();

    }

    public class Circle : Shapes
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public override void CheckValid()
        {
            if (Radius <= 0) throw new Exception("Radius should have a poditive value");
        }

        public override int GetSquare()
        {
            CheckValid();
            return (int)Math.Round(Math.PI * Radius * Radius, 0);
        }
    }

    public class Triangle : Shapes
    {
        private int[] _sides = new int[3];
        public int[] ArrSides 
        { 
            get { return _sides; }
        }

        public Triangle(int a, int b, int c)
        {
            _sides = new int[] { a, b, c };
            Array.Sort(ArrSides);
            CheckValid();
        }
        public override void CheckValid()
        {
            if (ArrSides.Any(x => x <= 0)) throw new Exception("All sides should have positive values");
            if (ArrSides[2] >= ArrSides[0] + ArrSides[1]) throw new Exception("The largest side should be less than sum of other");
        }
        public override int GetSquare()
        {
            float p = ArrSides.Sum() / 2;
            float s = p;
            Array.ForEach(ArrSides, x => s = s * (p - x));
            return (int)Math.Round(Math.Sqrt(s), 0);
        }
    }
}
