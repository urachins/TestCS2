using CSShapes;
namespace CSShapesTests
{
    public class ShapesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Circle_GetSquere10_return314()
        {
            //Arrange
            var circle = new Circle(10);
            int square = circle.GetSquare();
            Assert.That(square, Is.EqualTo(314) );
        }

        [Test]
        public void Circle_GetSquereMinos10_error()
        {
            var circle = new Circle(-10);
            Assert.Throws<Exception>(() => circle.GetSquare()); 
        }

        [Test]
        public void Triangle_GetSquare345_return6()
        {
            var triangle = new Triangle(3, 5, 4);
            var square = triangle.GetSquare();
            Assert.That(square, Is.EqualTo(6));
        }

        [Test]
        public void Triangle_GetSquare348_error()
        {
            Assert.Throws<Exception>(()=>{ var triangle = new Triangle(8, 3, 4); });
        }
    }
}