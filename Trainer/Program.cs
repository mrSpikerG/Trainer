using System;

namespace Trainer
{
    class Program
    {
        static void Main(string[] args)
        {
            System system = new System();

            Action[] act = new Action[6] { system.addDay, system.addGroup, system.addTask, system.removeDay, system.removeGroup, system.removeTask };


            ushort chose;
            do
            {
                Console.WriteLine("\tMenu");
                Console.WriteLine("1 - Добавить день");
                Console.WriteLine("2 - Добавить группу мышц");
                Console.WriteLine("3 - Добавить упражнение");
                Console.WriteLine("4 - Удалить день");
                Console.WriteLine("5 - Удалить группу мышц");
                Console.WriteLine("6 - Удалить упражнение");
                Console.WriteLine("0 - Выход\n");
                Console.Write("Ваш выбор:");
                chose = ushort.Parse(Console.ReadLine());

                Console.Clear();
                if (chose > 0 && chose < 7)
                {
                    act[chose-1]?.Invoke();
                }
            } while (chose != 0);
        }
}
}
