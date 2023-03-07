using System;

namespace unit001_结构体函数
{
    
    class Program
    {
        struct Position
        {
            public double x;
            public double y;
            public double z;
            public void PrintPosition()
            {
                Console.WriteLine(x + "," + y + "," + z);
            }
        }
        struct Name
        {
            public string FristName;
            public string LastName;
            public string  PrintName()
            {
                return FristName + LastName;
            }
        }
        static void PrintPosition(Position p)
        {
            Console.WriteLine(p.x + "," + p.y + "," + p.z);
        }
        static void Main(string[] args)
        {
            //声明一个坐标
            Position p1;
            p1.x = 12;
            p1.y = 122;
            p1.z = 12.34;
            //输出坐标的x y z
            PrintPosition(p1);
            Position p2;
            p2.x = 13;
            p2.y = 12.2;
            p2.z = 114.4;
            p2.PrintPosition();

            Name test;
            test.FristName = "好";
            test.LastName = "ren";
            Console.WriteLine(test.PrintName());
        }
    }
}
