using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioMartesSemana1
{
    internal class Menu
    {
        public void Execute()
        {
            string name;
            int age;
            bool continueFlag;
            Console.WriteLine("Introduce tu nombre");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");
            continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce tu edad");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tienes {age} años");
                if (age < 0)
                {
                    Console.WriteLine("No puedes tener menos de 0 años");
                }
                else if (age < 18)
                {
                    continueFlag = false;
                    Console.WriteLine("Aún no puedes tomar alcohol");
                }
                else
                {
                    continueFlag = false;
                    Console.WriteLine("Puedes tomar todo el alcohol que quieras");
                }
            }
        }
    }
}
