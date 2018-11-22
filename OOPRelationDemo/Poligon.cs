using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRelationDemo
{
    class Poligon
    {
        List<Point> _Points = new List<Point>();
        public IEnumerable<Point> Points
        {
            get { return _Points; }
        }
        public override string ToString()
        {
           var resultAllPoints = new StringBuilder();
           foreach (var p in _Points)
                resultAllPoints.Append(p + " ");
           return resultAllPoints.ToString();
        }

        public void Add(Point newPoint)
        {
            _Points.Add(newPoint);
        }

        public Point this[int index]
        {
            get
            {
                return _Points[index];
            }
        }

    }
}
