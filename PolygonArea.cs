using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonArea
{
    public sealed class PolygonArea
    {
        private static readonly PolygonArea _instance = new PolygonArea();
        private PolygonArea() { }
        public static PolygonArea Instance
        {
            get { return _instance; }
        }
        public double CalculatePolygonArea(List<(double x, double y)> vertices)
        {
            int n = vertices.Count;
            if (n < 3) throw new ArgumentException("A polygon vertices must be bigger than 3");

            double area = 0;
            for (int i = 0; i < n; i++)
            {
                double x1 = vertices[i].x;
                double y1 = vertices[i].y;
                double x2 = vertices[(i + 1) % n].x;
                double y2 = vertices[(i + 1) % n].y;

                area += (x1 * y2) - (y1 * x2);
            }

            return Math.Abs(area) / 2.0;
        }
    }
}
