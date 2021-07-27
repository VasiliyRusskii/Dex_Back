using System;
using System.Collections.Generic;
using System.Text;

namespace RusskiiDexLesson2GeometricFigure
{
    public class Figure
    {
        public int countOfEdge { get; set; }
        public double lenghtOfEdge { get; set; }
        public double square { get; set; }

        public Figure(int countOfEdge, double lenghtOfEdge)
        {
            this.countOfEdge = countOfEdge;
            this.lenghtOfEdge = lenghtOfEdge;
        }

        public Figure(int countOfEdge, double lenghtOfEdge, double square)
        {
            this.countOfEdge = countOfEdge;
            this.lenghtOfEdge = lenghtOfEdge;
            this.square = square;
        }
    }
}
