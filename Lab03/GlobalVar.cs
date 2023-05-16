using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03.Models;

namespace Lab03
{
    public class GlobalVar
    {
        public static Dictionary<string, Person> PersonDict = new Dictionary<string, Person>();

        public static Dictionary<string, Student> StudentDict = new Dictionary<string, Student>();
    }
}