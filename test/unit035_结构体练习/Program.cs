using System;

namespace unit035_结构体练习
{
    /// 定义⼀个Vector3的类（这个类可以⽤来表⽰坐标，可以表⽰向量），在⾥⾯定义⼀个Distance⽅法，⽤来取得⼀个向量的⻓度的
    class Program
    {
        struct Vector3
        {
            public double x;
            public double y;
            public double z;
            public double Distance ()
            {
                double result = Math.Sqrt(x*x+y*y+z*z);
                return result;
            }
        }
        static void Main(string[] args)
        {
            Vector3 v3;
            v3.x = 1;
            v3.y = 2;
            v3.z = 3;

            Console.WriteLine(v3.Distance());
        }
    }
}
