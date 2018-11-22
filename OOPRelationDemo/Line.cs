using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRelationDemo
{
    class Line
    {
        private Point _pStart, _pFinish;
        public Point StartPoint
        {
            get
            {
                //return _pFinish; ERR need copy
                //return new Point(_pStart); OK copy_ctor
                return new Point(_pStart.X, _pStart.Y);
            }
        }
        public Point FinishPoint
        {
            get { return new Point(_pFinish);  }
        }

        public Point this[int index]
        {
            get
            {
                Point Result = null;
                switch (index)
                {
                    case 0:
                        return Result = StartPoint;
                        break;
                    case 1:
                        return Result = FinishPoint;
                        break;
                }
                return Result;
            }
        }

        public Line(int xStart, int yStart, int xFinish, int yFinish)
        {
            _pStart = new Point(xStart, yStart);
            _pFinish = new Point(xFinish, yFinish);
        }
        public override string ToString()
        {
            return string.Format("{0} -{1}", _pStart, _pFinish );
        }
    }
}
