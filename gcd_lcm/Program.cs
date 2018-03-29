using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gcd_lcm
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = "1";
            while (start == "1")
            {
                Console.WriteLine("Please input first number：");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please input second number：");
                int num2 = int.Parse(Console.ReadLine());

                int num1temp = num1;
                int num2temp = num2;
                int remainder = 1;

                gcd(ref num1, ref num2, ref remainder);//取得最大公因數最後會放在num1裡面

                int lcm = num1temp * num2temp / num1;//直接計算最小公倍數

                Console.WriteLine($"gcd={num1}");
                Console.WriteLine($"lcm={lcm}");

                while (start == "1")
                {
                    Console.WriteLine("是否繼續?(1：YES/2：NO)");
                    start = Console.ReadLine();
                    if (!(start == "1" || start == "2"))
                    {
                        Console.WriteLine("母湯喔!");
                        start = "1";
                    }
                    else if (start == "1")
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            Console.WriteLine("Press any key to exit....");
            Console.ReadKey();
        }
        public static void MaxToLeft
            (ref int x, ref int y)
        {
            int temp = 0;
            if (x < y)
            {
                temp = x;
                x = y;
                y = temp;
            }
        }
        public static int Remainder(int x, int y)
        {
            while (x > y || x == y)
            {
                x -= y;
            }
            return x;
        }
        private static void gcd(ref int num1, ref int num2, ref int remainder)
        {
            while (remainder != 0)
            {
                remainder = 1;
                MaxToLeft(ref num1, ref num2);//大的數字一律放左邊
                remainder = Remainder(num1, num2);//減到不能減為止
                Console.WriteLine($"num1：{num1}，num2：{num2}，remainder：{remainder}");
                num1 = num2;
                num2 = remainder;
            }
        }
    }
}
