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

            Console.WriteLine("Введите val_2 = ");
            double val_2 = double.Parse(Console.ReadLine());
        }
    }
}
