using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Taller2DVisualStudioMartesSemana1
{
    internal class Menu
    {
        private List<Person> people;
        
        public Menu()
        {
            people = new List<Person>();
        }

        public void Execute()
        {
            PeopleMenu();
        }

        private void PeopleMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la opción a ejecutar:");
                Console.WriteLine("1. Crear persona");
                Console.WriteLine("2. Mostrar personas");
                Console.WriteLine("3. Mostrar nombre de personas");
                Console.WriteLine("0. Salir");
                string option= Console.ReadLine();
                switch (option)
                {
                    case "1":
                        CreatePersonMenu();
                        break;
                    case "2":
                        ShowPeopleMenu();
                        break;
                    case "3":
                        ShowPeopleNameMenu();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("La opción no existe");
                        break;
                }
            }
        }

        private void CreatePersonMenu()
        {
            string name = GetNameMenu();
            int age = GetAgeMenu();

            Person p = new Person(name, age);
            people.Add(p);
            Console.WriteLine(p.Name);
        }

        private void ShowPeopleMenu()
        {
            foreach(Person person in people)
            {
                Console.WriteLine(person.GetData());
            }
        }

        private void ShowPeopleNameMenu()
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.Name);
            }
        }

        private string GetNameMenu()
        {
            string name;
            Console.WriteLine("Introduce tu nombre");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");
            return name;

        }



        private int GetAgeMenu()
        {
            int age = 0;
            bool continueFlag;
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
            return age;

        }
    }
}
