using System;

namespace unit040_委托
{
    class Program
    {
        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }
        static double Division(double param1, double param2)
        {
            return param1 / param2;
        }

        //定义委托
        delegate double Mydelegate(double param1, double param2);
        static void Main(string[] args)
        {
            Console.WriteLine(Division(2, 3));
            //利用委托声明了一个变量，变量必须指向一个函数才能使用。指向的函数类型应该是【返回值里和参数列表内的类型一致】
            //小括号内部分一致。返回值一致。
            Mydelegate delegate1;
            delegate1 = Multiply;
            //
            Mydelegate deletate2 = Division;
            //指向的函数可以修改。
            Console.WriteLine(delegate1(1, 4));


        }
    }
}
