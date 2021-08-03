using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RusskiiDexLesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Stopwatch stopWatchList = new Stopwatch();
            Stopwatch stopWatchDict = new Stopwatch();
            Figure figureForList;
            int countForDictionary = 1;

            List<Figure> figuresList = new List<Figure>();

            Console.WriteLine("Происходит генерация фигур в List, пожалуйста подождите");
            for (int i = 0; i < 10000; i++)
            {
                figureForList = new Figure(sideCount: random.Next(3, 50), sideLenght: random.Next(1, 100));
                if (!figuresList.Contains(figureForList))
                {
                    figuresList.Add(figureForList);
                }

            }
            stopWatchList = Stopwatch.StartNew();
            foreach (var item in figuresList)
            {
                figuresList.Contains(item);
            }
            stopWatchList.Stop();

            Dictionary<Figure, int> figuresDict = new Dictionary<Figure, int>();
            Figure figureForDictionary;

            Console.WriteLine("Происходит генерация фигур в Dictionary, пожалуйста подождите");
            for (int i = 0; i < 10000; i++)
            {
                figureForDictionary = new Figure(sideCount: random.Next(3, 1000), sideLenght: random.Next(1, 1000));
                if (!figuresDict.ContainsKey(figureForDictionary))
                {
                    figuresDict.Add(figureForDictionary, countForDictionary++);
                }
            }
            stopWatchDict = Stopwatch.StartNew();
            foreach (var item in figuresDict)
            {
                figuresDict.ContainsKey(item.Key);
            }
            stopWatchDict.Stop();

            TimeSpan timeSpanForList = stopWatchList.Elapsed;
            string elapsedTimeForList = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                timeSpanForList.Hours, timeSpanForList.Minutes, timeSpanForList.Seconds, timeSpanForList.Milliseconds * 10);
            TimeSpan timeSpanForDictionary = stopWatchDict.Elapsed;
            string elapsedTimeForDictionary = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                timeSpanForDictionary.Hours, timeSpanForDictionary.Minutes, timeSpanForDictionary.Seconds, timeSpanForDictionary.Milliseconds * 10);

            string elapsedTimeResult = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                timeSpanForList.Hours, timeSpanForList.Minutes, timeSpanForList.Seconds, timeSpanForList.Milliseconds * 10 - timeSpanForDictionary.Milliseconds * 10);
            Console.WriteLine($"Время выполнения операции поиска для листа: {elapsedTimeForList}");
            Console.WriteLine($"Время выполнения операции поиска для словаря: {elapsedTimeForDictionary}");


            Console.WriteLine($"Поиск в словаре быстрее листа на {elapsedTimeResult}");

            Console.ReadLine();

        }
    }
}
