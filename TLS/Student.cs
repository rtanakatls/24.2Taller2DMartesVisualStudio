using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioMartesSemana1.TLS
{
    internal class Student
    {
        private string name;
        private float grade1;
        private float grade2;
        private float grade3;

        public string Name { get { return name; } }

        public Student(string name, float grade1, float grade2, float grade3)
        {
            this.name = name;
            this.grade1 = grade1;
            this.grade2 = grade2;
            this.grade3 = grade3;
        }

        public float GetFinalGrade()
        {
            return (grade1 + grade2 + 2 * grade3) / 4;
        }
    }
}
