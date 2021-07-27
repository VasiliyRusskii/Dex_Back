using System;

namespace RusskiiDexLesson2GeometricFigure
{
    class Program
    {
        //Рассмотрим на примере куба 
        public static int countOfSquares = 6; 
        public static int countOfEdges = 12;
        public static double lenghtOfEdge = 8;

        static void Main(string[] args)
        {
            Figure figure = new Figure(countOfEdges, lenghtOfEdge);
            Console.WriteLine("Исходное значение количество граней: " + figure.countOfEdge
                + " Длина граней: " + figure.lenghtOfEdge);

            figure = counting(figure);
            Console.WriteLine("Полученное значение количество граней: " + figure.countOfEdge
                + " Длина граней: " + figure.lenghtOfEdge + "\nПлощадь фигуры: " + figure.square);
        }

        static Figure counting(Figure figure)
        {
            return new Figure(figure.countOfEdge, figure.lenghtOfEdge, Math.Pow(figure.lenghtOfEdge, 2) * countOfSquares);
        }


    }
}
