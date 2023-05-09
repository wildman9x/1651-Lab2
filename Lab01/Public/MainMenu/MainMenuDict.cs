using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab01.Interface;

namespace Lab01.Public
{
    public class MainMenuDict
    {
        public static Dictionary<int, Type> GetDict()
        {
            var exampleDictionary = new Dictionary<int, Type>();
            var exampleInterfaceType = typeof(MainMenuItem);
            var exampleClasses = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => exampleInterfaceType.IsAssignableFrom(p) && p.IsClass);

            int key = 0;
            foreach (var exampleClass in exampleClasses)
            {
                exampleDictionary.Add(key, exampleClass);
                key++;
            }
            return exampleDictionary;
        }
    }
}