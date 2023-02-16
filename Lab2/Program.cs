namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2 - Наследование");

            var a = new Rectangle()
            {
                Name = "Прямоугольник A", Width = 15.2, Height = 13.7
            };

            var b = new Rectangle()
            {
                Name = "Прямоугольник Б", Width = 5.1, Height = 2.8
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}", a.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Площадь фигуры: {0}", b.GetArea());

            var list = new List<Figure>()
            {
                new Circle(5) { Name = "Круг" },
                new Square(10) { Name = "Квадрат" },
                new Triangle(1, 1, Math.Sqrt(2)) { Name = "Треугольник" },
                new Trapezoid(3, 4, 5) { Name = "Трапеция" },
                new Rhombus(2, 4) { Name = "Ромб" },
                new Parallelogram(4, 2) { Name = "Параллелограмм" },
                new RegularPentagon(4) { Name = "Правильный пятиугольник" },
                new RegularDecagon(3) { Name = "Правильный десятиугольник" }
            };

            foreach (var figure in list)
            {
                Console.WriteLine("\nНазвание фигуры: {0}", figure.Name);
                Console.WriteLine("Площадь фигуры: {0} \n", figure.GetArea());
            }
        }
    }
}