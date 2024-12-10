using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorGraphicLibrary._2DPlotter.Models
{
    public class Line
    {
        public Line(Point start, Point end, string color)
        {
            PointStart = start;
            PointEnd = end;
            Color = color;
        }

        public Point PointStart { get; set; }
        public Point PointEnd { get; set; }
        public string Color { get; set; }
    }
}
