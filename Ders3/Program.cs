using System;
using System.Linq;

namespace Ders3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = Add(4, 5);
            //Console.WriteLine(result);
            //int number1 = 20;
            //int number2 = 56;
            // ref: değer tipi taşıyan değişkenleri referans tip olarak göndermemize yarar...
            //int result2 = Add2(ref number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);
            // out: ref ile aynı mantıktadır. gönderilen değerin girilme zorunluluğu yoktur...
            int result = Multiply(4, 5,6);
            Console.WriteLine(result);
            int sum = Add3(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine(sum);
        }
        static int Add(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
        //ref ve out...
        static int Add2(ref int number1,int number2)
        {
            number1 = 33;
            return number1 + number2;
        }
        //Overloading Methods...
        static int Multiply(int num1,int num2)
        {
            return num1 * num2;
        }
        static int Multiply(int num1,int num2,int num3)
        {
            return num1 * num2 * num3;
        }
        //Params...
        static int Add3(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
