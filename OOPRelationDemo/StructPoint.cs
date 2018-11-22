using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRelationDemo
{
    public struct StructPoint
    {
        int _x, _y;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public StructPoint(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public override string ToString()
        {
            return string.Format("({0}, {1}) ", _x, _y);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            StructPoint other = (StructPoint)obj;
            return _x == other.X && _y == other.Y;
        }
        public static bool operator ==(StructPoint l, StructPoint r)
        {
            return l.X == r.X && l.Y == r.Y;
        }
        public static bool operator !=(StructPoint l, StructPoint r)
        {
            return !(l == r);
        }
        public override int GetHashCode()
        {
            return unchecked(_x ^ _y);
        }

    }
}
