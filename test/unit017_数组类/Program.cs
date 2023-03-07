using System;

namespace unit017_数组类
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public  T  Sum<T>(T A)
        {
            return (T)A;
        }
        public T test<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            dynamic result = num1 + num2;
            return result;
        }
    }
}
