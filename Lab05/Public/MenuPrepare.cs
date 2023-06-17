using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Lab05.Interface;

namespace Lab05.Public
{
    public class MenuPrepare
    {
        public static dynamic MenuDict<T>()
        {
            var exampleDictionary = new Dictionary<int, T>();
            var exampleInterfaceType = typeof(T);
            var exampleClasses = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(t => t.IsClass && !t.IsAbstract && typeof(T).IsAssignableFrom(t));
            foreach (var exampleClass in exampleClasses)
            {
                exampleDictionary.Add(exampleDictionary.Count, (T)Activator.CreateInstance(exampleClass));
            }
            return exampleDictionary;
        }

        public static void Print(dynamic exampleDictionary)
        {
            foreach (var item in exampleDictionary)
            {
                string strategyName = NameNormalization.CamelCase(item.Value.GetType().Name);
                Console.WriteLine($"{item.Key}. {strategyName}");
            }
        }

        public static void Input(dynamic exampleDictionary, dynamic context)
        {
            Console.Write("Enter your choice: ");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice == -1)
                {
                    return;
                }
                else if (choice > -1 && choice < exampleDictionary.Count)
                {
                    context.Strategy = exampleDictionary[choice];
                    context.RunStrategy();
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid choice!");
            }
        }
        public static void Prepare<T, R>() where R : new()
        {
            var context = new R();
            Dictionary<int, T> strategiesDict = MenuPrepare.MenuDict<T>();
            Console.WriteLine("Choose search strategy:");
            MenuPrepare.Print(strategiesDict);
            MenuPrepare.Input(strategiesDict, context);
        }
    }
}