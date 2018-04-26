using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 輸入並讀取身高，把字串轉為數值
            Console.WriteLine("請輸入身高");
            string height = Console.ReadLine();
            double h = double.Parse(height);

            // 輸入並讀取體重，把字串轉為數值
            Console.WriteLine("請輸入體重");
            string weight = Console.ReadLine();
            double w = double.Parse(weight);

            // 計算BMI
            double bmi = (w / ((h*h)/10000));

            // 顯示結果
            Console.WriteLine("您的BMI為" + bmi.ToString());

            // 判斷並顯示其他結果
            if (bmi < 18.5)
            {
                Console.WriteLine("過輕");
            }
            if (bmi > 24)
            {
                Console.WriteLine("過重");
            }

            // 暫停螢幕
            Console.ReadLine();

        }
    }
}
