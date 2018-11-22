using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRelationDemo
{
    public class Point
    {
        private int _x, _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public Point(Point oth)
        {
            _x = oth._x;
            _y = oth._y;
        }
        ~Point()
        {
            Console.WriteLine("Dector ~Point()");
        }
        public override string ToString()
        {
            return string.Format("({0}, {1}) ", _x, _y);
        }
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Point other = (Point)obj;
            return (this._x.Equals(other._x)) && (_y == other._y);// && (_y= other._y);
        }
        public int Y
        {
            get { return _y; }
        }
    }

    
}
