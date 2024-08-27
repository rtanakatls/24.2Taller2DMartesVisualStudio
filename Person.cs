using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioMartesSemana1
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name { get { return name; } }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string GetData()
        {
            return $"{name} - {age}";
        }
    }
}
