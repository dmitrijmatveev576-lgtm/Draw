using System;

namespace DrawableProject
{
    public interface IDrawable
    {
        void Draw();
    }

    // 2. Клас Point
    public class Point : IDrawable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            Console.WriteLine($"[Точка] Малюємо піксель на координатах X: {X}, Y: {Y}");
        }
    }

    // 3. Клас Circle
    public class Circle : IDrawable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Circle(int x, int y, int radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"[Коло] Малюємо коло з центром у ({X}, {Y}) та радіусом {Radius}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо масив об'єктів, які реалізують інтерфейс IDrawable
            IDrawable[] drawables = new IDrawable[]
            {
                new Point(10, 20),
                new Circle(50, 50, 15),
                new Point(-3, 7)
            };
            foreach (var item in drawables)
            {
                item.Draw();
            }
        }
    }
}
