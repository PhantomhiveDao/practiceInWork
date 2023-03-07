using System;

namespace unit0001_practice
{
    class Program
    {
        static int LengthOfLongestSubstring(string s)
        {
            int Result = -1;
            //int i = 0;
            ///获取输入的字符串并改成数组
            char[] InputArr = s.ToCharArray();
            //用来处理是否大家都一样
            bool Same = false;
            //
            int Lastsuoyin = InputArr.Length - 1;
            int Firstsuoyin = 0;
            //首位与末尾值是否相等；相等则首位+1//不等
            int countSame = 0;
            //从前位循环到末位
            foreach (int i in InputArr)
            {
                if (InputArr[Lastsuoyin] == i)
                {
                    //未改变last索引值
                    Same = true;
                    Console.WriteLine(Firstsuoyin + "!" + Lastsuoyin + "[same]");
                    countSame += 1;                    
                }
                else//此时前一个与后一个不等
                {
                    Same = false;
                    Console.WriteLine("第" + Firstsuoyin + "个没有和最后一位相等" + Lastsuoyin);                    
                }
            }
            Console.WriteLine("第一个for循环结束了");
            // 前边的值都等于末尾,且是从第一位相等到结束
            if (Same == true && countSame==InputArr.Length)
            {
                Console.WriteLine("大家都一样");
                return 1;
            }
            else//第二位开始与末尾不一样了
            {
                //初始化第一个位索引
                Firstsuoyin = 0;
                int sameTime = 0;
                bool xiangTong = false;
                Console.WriteLine("当前的前位值" + Firstsuoyin + ":" + InputArr[Firstsuoyin] + "当前的末位值" + Lastsuoyin + ":" + InputArr[Lastsuoyin]);
                for (int i = 0; i<Lastsuoyin;i++)
                {
                    Console.WriteLine("前位值" + i + ":" + InputArr[i] + "，末位值" + Lastsuoyin + ":" + InputArr[Lastsuoyin] + "|sametime" + sameTime);
                    if (InputArr[i] == InputArr[Lastsuoyin])
                    {
                        Lastsuoyin -= 1;
                        i = 0;
                        sameTime += 1;                        
                        //Console.WriteLine("sametime" + sameTime);
                    }
                    else 
                    {
                        Console.WriteLine("---else---");
                        if (i == InputArr.Length-2 &&sameTime==0)
                        {
                            Lastsuoyin -= 1;
                            i = 0;
                            Console.WriteLine("---to-0--");

                        }

                    }
                    
                }

                

            }
            return 0000000;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLongestSubstring(Console.ReadLine()));

        }
    }
}
