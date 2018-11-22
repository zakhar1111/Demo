using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRelationDemo
{
    class Circle : Point
    {
        public Circle(int x, int y, int r) : base(x, y)
        {
            _r = r;
        }
        ~Circle()
        {
            Console.WriteLine("dctor ~Circle()");
        }
        private int _r;
        public override string ToString()
        {
            return string.Format("{0},{1}",base.ToString(), _r);
        }
    }
}
