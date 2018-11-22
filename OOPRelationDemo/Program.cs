using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRelationDemo
{
    class Program
    {
        const int DEFAULT_NUM_OF_POINT = 10;
        static void Main(string[] args)
        {
            //DemoPoint();
            //DemoLine();
            //DemoCircle();
            //DemoPoligone();
            DemoStructPoint();
            
            Console.ReadKey();
           

        }

        private static void DemoStructPoint()
        {
            var p1 = new StructPoint(3, 6);
            Console.WriteLine(p1);
            var p2 = new StructPoint(23, 16);
            var p3 = new StructPoint(33, 16);
            Console.WriteLine(p2);
            p2.X = 33;
            Console.WriteLine(p2);
            StructPoint[] points = new StructPoint[DEFAULT_NUM_OF_POINT];
            points[0] = p1;
            points[1] = p2;
            points[2] = new StructPoint(3, 6);

            int searchResultIndex = Array.IndexOf(points, p3);
            Console.WriteLine("First index of {0} = {1}", p3, searchResultIndex);
            for (int i = 0; i < DEFAULT_NUM_OF_POINT; i++)
                if (points[i] != new StructPoint())
                    Console.WriteLine("[{0}] : {1}", i, points[i]);

            StructPoint searchingPoint = new StructPoint(3, 6);
            int searchResultLastIndex = Array.LastIndexOf(points, searchingPoint);
            Console.WriteLine("Last index of {0} = {1}", searchingPoint, searchResultLastIndex);

        }

        private static void DemoPoligone()
        {
            var poli = new Poligon();
            poli.Add(new Point(1, 5));
            poli.Add(new Point(15, 10));
            poli.Add(new Point(27, 42));
            Console.WriteLine(poli);
            poli[2].X = 0;
            int i = 0;
            foreach (var el in poli.Points)
            {
                Console.WriteLine("[{0}] - {1}", i++, el);
            }

        }

        public static void DemoPoint()
        {
            Point p1 = new Point(3, 6);
            Console.WriteLine(p1);
            var p2 = new Point(23, 16);
            var p3 = new Point(33, 16);
            Console.WriteLine(p2);
            p2.X = 33;
            Console.WriteLine(p2);
            Point[] points = new Point[DEFAULT_NUM_OF_POINT];
            points[0] = p1;
            points[1] = p2;
            points[2] = new Point(3, 6);

            int searchResultIndex = Array.IndexOf(points, p3);
            Console.WriteLine("First index of {0} = {1}", p3, searchResultIndex);
            for (int i = 0; i < DEFAULT_NUM_OF_POINT; i++)
                if (points[i] != null)
                    Console.WriteLine("[{0}] : {1}", i, points[i]);

            Point searchingPoint = new Point(3, 6);
            int searchResultLastIndex = Array.LastIndexOf(points, searchingPoint);
            Console.WriteLine("Last index of {0} = {1}", searchingPoint, searchResultLastIndex);
        }
        public static void DemoLine()
        {
            Line line = new Line(2, 3, 4, 5);
            Console.WriteLine(line);
            Point p1 = line.StartPoint;
            p1 = line[0];
            Point p2 = line.FinishPoint;
            p2 = line[1];
            p2.X = 29;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(line);
        }
        public static void DemoCircle()
        {
            Circle c = new Circle(13, 15, 5);
            Console.WriteLine(c);
        }
    }
}
