using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab02.Public
{
    public class MenuDict
    {
        public static Dictionary<int, Type> GetMenu(Type type)
        {
            var exampleDictionary = new Dictionary<int, Type>();
            var exampleInterfaceType = type;
            var exampleClasses = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => exampleInterfaceType.IsAssignableFrom(p) && p.IsClass);

            foreach (var exampleClass in exampleClasses)
            {
                exampleDictionary.Add(exampleDictionary.Count, exampleClass);
            }
            return exampleDictionary;
        }

        public static void PrepareMenu(Dictionary<int, Type> exampleDictionary, bool pressKey = true)
        {
            PrintMenu.Run(exampleDictionary);
            Option.Choose(exampleDictionary, pressKey);
        }
    }
}