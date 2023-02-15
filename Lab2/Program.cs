namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2 - Наследование");

            Rectangle a = new Rectangle()
            {
                Name = "Прямоугольник A", Width = 15.2, Height = 13.7
            };

            Rectangle b = new Rectangle()
            {
                Name = "Прямоугольник Б", Width = 5.1, Height = 2.8
            };

            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Площадь фигуры: {0}", a.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Площадь фигуры: {0}", b.GetArea());
        }
    }
}