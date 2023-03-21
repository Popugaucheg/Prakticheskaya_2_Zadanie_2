using System;

namespace Prakticheskaya_2_Zadanie_2
{
    class MyClass
    {
        private int n = 0;

        public bool SetNumber(int number)
        {
            if (number == n + 1)
            {
                n = number;
                return true;
            }
            else
            {
                n = 0;
                return false;
            }
        }

        public int GetExpectedNumber()
        {
            return n + 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            while (true)
            {
                Console.WriteLine("Введите число " + myClass.GetExpectedNumber() + ":");
                int number = Convert.ToInt32(Console.ReadLine());

                if (myClass.SetNumber(number))
                {
                    Console.WriteLine("Правильно! Можете продолжить.");
                }
                else
                {
                    Console.WriteLine("Неправильно! Начните сначала.");
                }
            }
        }
    }
}
