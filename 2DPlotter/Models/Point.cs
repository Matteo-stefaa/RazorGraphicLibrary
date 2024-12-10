using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGraphicLibrary._2DPlotter.Models
{
    public class Point
    {
        public Point(double x = 0, double y = 0) 
        {
            X = x; Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
    }
}
