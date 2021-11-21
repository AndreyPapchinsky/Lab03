using System;

namespace Lab03
{
    public struct Distance
    {
        public int Feet;
        public int Inches;
    }
    class Struct
    {
        static void Main(string[] args)
        {
            Distance vOne = new ();
            Distance vTwo = new ();
            Distance vSum = new ();

            Console.WriteLine("Введите значение в дюймах для первой переменной: ");
            vOne.Inches = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение в дюймах для второй переменной: ");
            vTwo.Inches = int.Parse(Console.ReadLine());

            vSum.Feet = (vOne.Inches + vTwo.Inches) /12;
            vSum.Inches = (vOne.Inches + vTwo.Inches) % 12;

            Console.WriteLine(vSum.Feet + "-" + vSum.Inches);
        }
    }
}
