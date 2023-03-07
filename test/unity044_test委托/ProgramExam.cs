using System;

namespace unity044_test委托
{
    class ProgramExam
    {
        static int LengthOfLongestSubstring(string s)
        {
            int Result = -1;
            //int i = 0;
            ///获取输入的字符串并改成数组
            char[] InputArr = s.ToCharArray();
            //用来处理是否大家都一样
            bool Same = false;
            int Lastsuoyin = InputArr.Length-1;
            int Firstsuoyin = 0;
            //首位与末尾值是否相等；相等则首位+1//不等
            //从前位循环到末位
            for (int i = 0; i < InputArr.Length; i++)
            {
                if (InputArr[Firstsuoyin] == InputArr[Lastsuoyin])
                {                    
                    //未改变last索引值
                    Same = true;
                    Console.WriteLine(Firstsuoyin+"!"+Lastsuoyin+"[same]");
                    Firstsuoyin += 1;
                }
                else//此时前一个与后一个不等
                {
                    Same = false;                    
                    Console.WriteLine("第"+ Firstsuoyin + "个没有和最后一位相等" + Lastsuoyin);

                    if (Firstsuoyin < InputArr.Length)
                    {
                        Firstsuoyin += 1;

                    }
                }
            }
            Console.WriteLine("第一个for循环结束了" );
            if (Same == true&&Firstsuoyin==0)// 前边的值都等于末尾,且是从第一位相等到结束
            {
                Console.WriteLine("大家都一样");
                return 1;
            }
            else//第二位开始与末尾不一样了
            {
                Console.WriteLine("当前的前位值" + Firstsuoyin + ":" + InputArr[Firstsuoyin]+ "当前的末位值" + Lastsuoyin + ":" + InputArr[Lastsuoyin]);

                while (Same == false)
                {
                    if (Lastsuoyin >= 0)
                    {
                        Lastsuoyin -= 1;

                        for (int j = 0; j < InputArr.Length - Firstsuoyin; j++)
                        {
                            if (InputArr[Firstsuoyin] == InputArr[Lastsuoyin])
                            {
                                //未改变last索引值

                                Same = true;
                                Console.WriteLine(Firstsuoyin + "!" + Lastsuoyin + "[same]");
                                Console.WriteLine("当前的前位值" + Firstsuoyin + ":" + InputArr[Firstsuoyin] + "当前的末位值" + Lastsuoyin + ":" + InputArr[Lastsuoyin]);
                                if (Firstsuoyin < InputArr.Length)
                                {
                                    Firstsuoyin += 1;
                                }
                                else
                                {
                                    Console.WriteLine("大失败");
                                    return 0000;
                                }

                            }
                            else//此时前一个与后一个不等
                            {
                                Same = false;
                                Console.WriteLine("大失败");
                                Console.WriteLine("当前的前位值" + Firstsuoyin + ":" + InputArr[Firstsuoyin] + "当前的末位值" + Lastsuoyin + ":" + InputArr[Lastsuoyin]);
                                return 0000;
                            }
                        }
                        Lastsuoyin -= 1;


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
