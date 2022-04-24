using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class System
    {
        public Dictionary<string, List<string>> MuscleGroup;
        public Dictionary<string, Dictionary<string, List<string>>> Training = new Dictionary<string, Dictionary<string, List<string>>>();
        public string FullPath { get; set; }
        public System()
        {
            //Нахождение полного пути
            #region
            string[] temp = Path.GetFullPath("ref").Split("\\");
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == "Client")
                {
                    for (int j = 0; j < i; j++)
                    {
                        FullPath += $"{temp[j]}\\";
                    }
                    break;
                }
            }
            #endregion
            FullPath += "Trainer\\bin\\Debug\\net5.0\\TrainingApp";
            init();
        }

        public void init()
        {
            foreach (string day in Directory.GetDirectories(FullPath))
            {
                MuscleGroup = new Dictionary<string, List<string>>();
                foreach (string group in Directory.GetDirectories($"{FullPath}{day.Replace($"{FullPath}", "")}"))
                {
                    MuscleGroup.Add(group.Replace($"{day}\\", ""), new List<string>());

                    foreach (string train in Directory.GetFiles($"{group}"))
                    {
                        MuscleGroup[group.Replace($"{day}\\", "")].Add(String.Format("{0}\n{1}", train.Replace($"{group}\\", "").Replace(".txt", ""), File.ReadAllText(train)));
                    }
                }
                Training.Add(day.Replace($"{FullPath}\\", ""), MuscleGroup);
            }
        }
        public void showAll()
        {
            foreach (string day in Directory.GetDirectories(FullPath))
            {
                Console.WriteLine(day.Replace($"{FullPath}\\", ""));
                foreach (string group in Directory.GetDirectories($"{FullPath}{day.Replace($"{FullPath}", "")}"))
                {
                    foreach (string train in Directory.GetFiles($"{group}"))
                    {
                        Console.WriteLine($" -- {train.Replace($"{group}\\", "").Replace(".txt", "")}");
                    }
                    Console.WriteLine(String.Format(" - {0}", group.Replace($"{FullPath}{day.Replace($"{FullPath}", "")}\\", "")));
                }
            }
        }
    }
}
