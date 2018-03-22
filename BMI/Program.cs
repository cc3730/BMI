using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            // 背景以及字體顏色
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            // 標題
            Console.WriteLine("   ═ BMI計算機═   ");

            // 內容及變數設定
            Console.Write("請輸入身高(公尺)");
            string height = Console.ReadLine();

            Console.Write("請輸入體重(公斤)");
            string weight = Console.ReadLine();

            // BMI值計算
            double total = double.Parse(weight) / (Math.Pow( double.Parse(height), 2));
            Console.WriteLine("您的BMI數值為:" + total);
            Console.WriteLine();

            // BMI結果判斷條件
            if (total < 18.5)
            {
                Console.WriteLine("您的BMI指數過低。");
            }
            else if (total >= 24)
            {
                Console.WriteLine("您的BMI指數過高。");
            }
            else
                Console.WriteLine("您的BMI在正常範圍。");

            // BMI結果是否免役判斷條件
            if (total < 16.5)
            {
                Console.WriteLine("您因為BMI過低,所以免役了。");
            }
            else if (total > 31.5)
            {
                Console.WriteLine("您因為BMI過高,所以免役了。");
            }
            else if (total >= 17 && total <= 31)
            {
                Console.WriteLine("您的BMI符合標準,屬於常備役體位。");
            }
            else
                Console.WriteLine("您的BMI符合標準,屬於替代役體位。");

            // 畫面暫停
            Console.ReadLine();
            
        }
    }
}
