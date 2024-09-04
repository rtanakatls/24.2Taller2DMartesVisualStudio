using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVisualStudioMartesSemana1.TLS
{
    internal class TLSMenu
    {
        private List<Classroom> classrooms;

        public TLSMenu()
        {
            classrooms = new List<Classroom>();
        }

        public void Execute()
        {
            ShowClassroomMenu();
        }

        private void ShowClassroomMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la opción: ");
                Console.WriteLine("1. Crear salón");
                Console.WriteLine("2. Seleccionar salón");
                Console.WriteLine("0. Salir");
                string option= Console.ReadLine();
                switch(option)
                {
                    case "1":
                        ShowCreateClassroom();
                        break;
                    case "2":
                        ShowSelectClassroom();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                }
            }
        }

        private void ShowCreateClassroom()
        {
            Console.WriteLine("Introduce el nombre");
            string name= Console.ReadLine();
            classrooms.Add(new Classroom(name));
        }

        private void ShowSelectClassroom()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el número del salón a seleccionar");
                for(int i=0;i<classrooms.Count; i++)
                {
                    Console.WriteLine($"{i}. {classrooms[i].Name}");
                }
                int index = int.Parse(Console.ReadLine());
                if (index < 0 || index >= classrooms.Count)
                {
                    Console.WriteLine("El número no es válido");
                }
                else
                {
                    ShowStudentMenu(classrooms[index]);
                    continueFlag = false;
                }
            }
        }

        private void ShowStudentMenu(Classroom classroom)
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la opción");
                Console.WriteLine("1. Mostrar a los alumnos");
                Console.WriteLine("2. Añadir alumno");
                Console.WriteLine("3. Eliminar alumno");
                Console.WriteLine("4. Mostrar cantidad de aprobados");
                Console.WriteLine("5. Mostrar cantidad de desaprobados");
                Console.WriteLine("6. Mostrar lista de aprobados");
                Console.WriteLine("7. Mostrar lista de desaprobados");
                Console.WriteLine("8. Mostrar el promedio del salón");
                Console.WriteLine("0. Salir");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        ShowStudents(classroom.Students);
                        break;
                    case "2":
                        ShowAddStudent(classroom);
                        break;
                    case "3":
                        ShowRemoveStudent(classroom);
                        break;
                    case "4":
                        Console.WriteLine($"Cantidad de aprobados: {classroom.GetPassedStudentsAmount()}");
                        break;
                    case "5":
                        Console.WriteLine($"Cantidad de desaprobados: {classroom.GetFailedStudentsAmount()}");
                        break;
                    case "6":
                        ShowStudents(classroom.GetPassedStudentsList());    
                        break;
                    case "7":
                        ShowStudents(classroom.GetFailedStudentsList());
                        break;
                    case "8":
                        Console.WriteLine($"Promedio del salón: {classroom.GetAverageGrade()}");
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                }
            }
        }

        private void ShowStudents(List<Student> students)
        {
            for(int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i}. {students[i].Name}");
            }
        }

        private void ShowAddStudent(Classroom classroom)
        {
            Console.WriteLine("Introduce el nombre del alumno");
            string name = Console.ReadLine();
            Console.WriteLine("Introduce la nota 1");
            float grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota 2");
            float grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota 3");
            float grade3 = float.Parse(Console.ReadLine());
            classroom.AddStudent(new Student(name, grade1, grade2, grade3));
        }

        private void ShowRemoveStudent(Classroom classroom)
        {
            bool continueFlag = true;
            while(continueFlag)
            {
                Console.WriteLine("Introduce el número del alumno a remover");
                ShowStudents(classroom.Students);
                int option = int.Parse(Console.ReadLine());
                if (option < 0 || option >= classroom.Students.Count)
                {
                    Console.WriteLine("La opción no existe");
                }
                else
                {
                    classroom.RemoveStudent(option);
                    continueFlag = false;
                }
            }
        }
    }
}
