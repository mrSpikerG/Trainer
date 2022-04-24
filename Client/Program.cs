using System;
using System.Collections.Generic;

namespace Client
{
    class Program
    {

        static void Main(string[] args)
        {
            System sys = new System();

            Dictionary<string, List<string>> MuscleGroup;
            List<string> list;
            sys.showAll();

            Console.Write("Выберите день интересующий вас: ");
            string chose = Console.ReadLine();
            if (sys.Training.TryGetValue(chose, out MuscleGroup))
            {
                Console.Write("Выберите группу мышц интересующую вас: ");
                string choseGroup = Console.ReadLine();
                if (MuscleGroup.TryGetValue(choseGroup, out list))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        Console.WriteLine(list[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Данной группы нет в выбранном дне");
                }
            }
            else
            {
                Console.WriteLine("В данный день нет тренировок");
            }
        }
    }
}
