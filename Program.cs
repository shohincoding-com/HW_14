using System;
using HW_14CalcHelper;

namespace HW_14
{
    class Program
    {
        delegate S DelegateCalc <S> (S val_1, S val_2);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите val_1 = ");
            double val_1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Вибырите математическую функцию:  ");
            var MathFunc = Console.ReadLine();

            Console.WriteLine("Введите val_2 = ");
            double val_2 = double.Parse(Console.ReadLine());

            if (MathFunc == "-")
            {
                DelegateCalc<double> minus = CalcHelper.MINUS;
                Console.WriteLine($"{val_1} - {val_2} = {minus.Invoke(val_1,val_2)}");
            }

            if (MathFunc == "+")
            {
                DelegateCalc<double> plus = CalcHelper.PLUS;
                Console.WriteLine($"{val_1} + {val_2} = {plus.Invoke(val_1,val_2)}");
            }

            if (MathFunc == "/")
            {
                DelegateCalc<double> divis = CalcHelper.DIVIS;
                Console.WriteLine($"{val_1} / {val_2} = {divis.Invoke(val_1,val_2)}");
            }

            if (MathFunc == "*")
            {
                DelegateCalc<double> milt = CalcHelper.MILT;
                Console.WriteLine($"{val_1} * {val_2} = {milt.Invoke(val_1,val_2)}");
            }
            else
            {
                Console.WriteLine("Error!");
            }



        }
    }
}
