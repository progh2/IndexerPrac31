using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructPrac
{
    struct Point
    {
        public int x;
        public int y;

        public Point(int a)
        {
            x = 0;
            y = 0;
        }
    } 

    class PointClass
    {
        public int x;
        public int y;

        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    struct PointStruct
    {
        public int x;
        public int y;
        public PointStruct(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point;
            //point.x = 10;
            //point.y = 10;
            point = new Point();
            Console.WriteLine("x:" + point.x);
            Console.WriteLine("y:" + point.y);
            ///

            PointClass pointClassA = new PointClass(10, 100);
            PointClass pointClassB = pointClassA;
            pointClassB.x = 20;
            pointClassB.y = 200;
            Console.WriteLine("pointClassA: " + pointClassA.x
                + " / " + pointClassA.y);
            Console.WriteLine("pointClassB: " + pointClassB.x
                + " / " + pointClassB.y);

            PointStruct pointStructA = new PointStruct(10, 100);
            PointStruct pointStructB = pointStructA;
            pointStructB.x = 20;
            pointStructB.y = 200;
            Console.WriteLine("pointStructA: " + pointStructA.x
                + " / " + pointStructA.y);
            Console.WriteLine("pointStructB: " + pointStructB.x
                + " / " + pointStructB.y);
        }
    }
}
