using System;

namespace BridgeMethod
{
    class Program
    {
        public abstract class Shape
        {
            protected IShapeRenderer renderer;

            public Shape(IShapeRenderer renderer)
            {
                this.renderer = renderer;
            }

            public abstract void Draw();
        }

        public interface IShapeRenderer
        {
            void RenderCircle(int x, int y, int radius);
            void RenderSquare(int x, int y, int sideLength);
        }

        public class Circle : Shape
        {
            private int x, y, radius;

            public Circle(int x, int y, int radius, IShapeRenderer renderer) : base(renderer)
            {
                this.x = x;
                this.y = y;
                this.radius = radius;
            }

            public override void Draw()
            {
                renderer.RenderCircle(x, y, radius);
            }
        }

        public class Square : Shape
        {
            private int x, y, sideLength;

            public Square(int x, int y, int sideLength, IShapeRenderer renderer) : base(renderer)
            {
                this.x = x;
                this.y = y;
                this.sideLength = sideLength;
            }

            public override void Draw()
            {
                renderer.RenderSquare(x, y, sideLength);
            }
        }

        public class ConsoleShapeRenderer : IShapeRenderer
        {
            public void RenderCircle(int x, int y, int radius)
            {
                Console.WriteLine($"Drawing circle at ({x}, {y}) with radius {radius} on Console");
            }

            public void RenderSquare(int x, int y, int sideLength)
            {
                Console.WriteLine($"Drawing square at ({x}, {y}) with side length {sideLength} on Console");
            }
        }

        public class VideoScreenShapeRenderer : IShapeRenderer
        {
            public void RenderCircle(int x, int y, int radius)
            {
                Console.WriteLine($"Drawing circle at ({x}, {y}) with radius {radius} Videoscreen");
            }

            public void RenderSquare(int x, int y, int sideLength)
            {
                Console.WriteLine($"Drawing square at ({x}, {y}) with side length {sideLength} Videoscreen");
            }
        }

        static void Main(string[] args)
        {
            Circle circle = new Circle(10, 20, 5, new ConsoleShapeRenderer());
            Square square = new Square(30, 40, 10, new VideoScreenShapeRenderer());

            circle.Draw(); 
            square.Draw(); 
        }
    }
}
