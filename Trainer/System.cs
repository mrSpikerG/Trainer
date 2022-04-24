using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainer
{
    class System
    {

        public System()
        {
            if (!Directory.Exists("TrainingApp"))
            {
                Directory.CreateDirectory("TrainingApp");
            }
        }
        public void addDay()
        {
            //Вывод тренировок которые уже есть
            Console.WriteLine("Расписание тренировок: ");
            showDays();
            Console.WriteLine();

            guide();

            //День недели в который теперь будет тренировка
            Console.Write("Введите в какой день будет тренировка: ");
            string day = Console.ReadLine();

            //проверка на наличие этой тренировки
            if (Directory.Exists($"TrainingApp/{day}"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Тренировка в данный день уже существует");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            Directory.CreateDirectory($"TrainingApp/{day}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Тренировка в данный день создана");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void addGroup()
        {
            //Вывод тренировок которые уже есть
            Console.WriteLine("Расписание тренировок: ");
            showDays();
            Console.WriteLine();

            guide();

            //День недели в который теперь будет тренировка
            Console.Write("Введите в какой день будет тренировка: ");
            string day = Console.ReadLine();

            //проверка на наличие этой тренировки
            if (Directory.Exists($"TrainingApp/{day}"))
            {

                //Вывод групп мышц которые уже есть
                Console.WriteLine("Группы мышц: ");
                showGroups(day);

                guide();

                //День недели в который теперь будет тренировка
                Console.Write("Введите какую группу мышц вы хотите добавить: ");
                string group = Console.ReadLine();

                //проверка на наличие этой тренировки
                if (Directory.Exists($"TrainingApp/{day}/{group}"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Данная группа мышц уже существует");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                {
                    Directory.CreateDirectory($"TrainingApp/{day}/{group}");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Группа мышц добавлена");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Тренировки в данный день не существует");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }
        public void addTask()
        {
            //Вывод тренировок которые уже есть
            Console.WriteLine("Расписание тренировок: ");
            showDays();
            Console.WriteLine();

            guide();

            //День недели в который теперь будет тренировка
            Console.Write("Введите в какой день будет тренировка: ");
            string day = Console.ReadLine();

            //проверка на наличие этой тренировки
            if (Directory.Exists($"TrainingApp/{day}"))
            {

                //Вывод групп мышц которые уже есть
                Console.WriteLine("Группы мышц: ");
                showGroups(day);

                guide();

                //День недели в который теперь будет тренировка
                Console.Write("Введите какую группу мышц вы хотите добавить: ");
                string group = Console.ReadLine();

                //проверка на наличие этой тренировки
                if (Directory.Exists($"TrainingApp/{day}/{group}"))
                {

                    //Вывод групп мышц которые уже есть
                    Console.WriteLine("Упражнения: ");
                    showTasks(day, group);

                    guide();

                    //День недели в который теперь будет тренировка
                    Console.Write("Введите какие упражнения вы хотите добавить: ");
                    string task = Console.ReadLine();
                    if (!File.Exists($"TrainingApp/{day}/{group}/{task}"))
                    {
                        Console.Write("Введите описание упражнению: ");
                        string taskTime = Console.ReadLine();

                        File.WriteAllText($"TrainingApp/{day}/{group}/{task}.txt", taskTime);

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Упражнение добавлено");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Данное упражнение уже существует");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
                else
                {
                    Directory.CreateDirectory($"TrainingApp/{day}/{group}");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Данной группы мышц не существует");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Тренировки в данный день не существует");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }
        public void removeDay()
        {
            //Вывод тренировок которые уже есть
            Console.WriteLine("Расписание тренировок: ");
            showDays();
            Console.WriteLine();

            guide();

            //День недели которй хотите удалить
            Console.Write("Введите в какой день будет тренировка: ");
            string day = Console.ReadLine();

            //проверка на наличие этой тренировки
            if (Directory.Exists($"TrainingApp/{day}"))
            {
                Directory.Delete($"TrainingApp/{day}");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Тренировка успешно удалена");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Тренировки в данный день не существует");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void removeGroup()
        {
            //Вывод тренировок которые уже есть
            Console.WriteLine("Расписание тренировок: ");
            showDays();
            Console.WriteLine();

            guide();

            //День недели в который теперь будет тренировка
            Console.Write("Введите в какой день будет тренировка: ");
            string day = Console.ReadLine();

            //проверка на наличие этой тренировки
            if (Directory.Exists($"TrainingApp/{day}"))
            {

                //Вывод групп мышц которые уже есть
                Console.WriteLine("Группы мышц: ");
                showGroups(day);

                guide();

                //День недели в который теперь будет тренировка
                Console.Write("Введите какую группу мышц вы хотите добавить: ");
                string group = Console.ReadLine();

                //проверка на наличие этой тренировки
                if (Directory.Exists($"TrainingApp/{day}/{group}"))
                {
                    Directory.Delete($"TrainingApp/{day}/{group}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Данная группа мышц удалена");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Группа мышц в данный день не существует");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Тренировки в данный день не существует");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }
        public void removeTask()
        {
            //Вывод тренировок которые уже есть
            Console.WriteLine("Расписание тренировок: ");
            showDays();
            Console.WriteLine();

            guide();

            //День недели в который теперь будет тренировка
            Console.Write("Введите в какой день будет тренировка: ");
            string day = Console.ReadLine();

            //проверка на наличие этой тренировки
            if (Directory.Exists($"TrainingApp/{day}"))
            {

                //Вывод групп мышц которые уже есть
                Console.WriteLine("Группы мышц: ");
                showGroups(day);

                guide();

                //День недели в который теперь будет тренировка
                Console.Write("Введите какую группу мышц вы хотите добавить: ");
                string group = Console.ReadLine();

                //проверка на наличие этой тренировки
                if (Directory.Exists($"TrainingApp/{day}/{group}"))
                {

                    //Вывод групп мышц которые уже есть
                    Console.WriteLine("Упражнения: ");
                    showTasks(day, group);

                    guide();

                    //День недели в который теперь будет тренировка
                    Console.Write("Введите какие упражнения вы хотите добавить: ");
                    string task = Console.ReadLine();
                    if (File.Exists($"TrainingApp/{day}/{group}/{task}"))
                    {
                        File.Delete($"TrainingApp/{day}/{group}/{task}");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Упражнение удалено");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Данное упражнение не существует");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                else
                {
                    Directory.CreateDirectory($"TrainingApp/{day}/{group}");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Данной группы мышц не существует");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Тренировки в данный день не существует");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }


        private void showDays()
        {
            foreach (string i in Directory.GetDirectories("TrainingApp"))
            {
                Console.WriteLine(i.Remove(0,12));
            }
            Console.WriteLine();
        }

        private void showGroups(string day)
        {
            foreach (string i in Directory.GetDirectories($"TrainingApp/{day}"))
            {
                Console.WriteLine(i.Remove(0, 12));
            }
            Console.WriteLine();
        }

        private void showTasks(string day, string group)
        {
            foreach (string i in Directory.GetFiles($"TrainingApp/{day}/{group}"))
            {
                Console.WriteLine(i.Remove(0, 12));
            }
            Console.WriteLine();
        }
        private void guide()
        {
            //Гайд для тренера по удалению тренеровки
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Данная система русифицирована поэтому вводите текст на русском");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
