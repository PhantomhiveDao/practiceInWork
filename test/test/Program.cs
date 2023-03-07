using System;

namespace test
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string temps = Console.ReadLine();
            string[] tempArr = temps.Split(" ");
            //int[] tempArr = new int[str.tempArrs];
            int count = 0;
            int j = 0;
            int max = 1;
            for (int i = 0; i < tempArr.Length-1; i++)
            {
              
                if (Convert.ToInt32(tempArr[i]) < Convert.ToInt32(tempArr[i + 1]))
                {
                    count++;

                }
                else
                {
                    if (count > max)
                    {
                        max = count;

                    }
                    count = 1;
                }
                
            }
            if (count > max)
            {
                max = count;

            }
            Console.WriteLine("连续增加的days"+ max);
          
        }

        

    }
}
