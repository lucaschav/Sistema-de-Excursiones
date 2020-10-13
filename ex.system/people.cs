using System;
using System.Collections.Generic;
using System.Text;

namespace ex.system
{
    public class people
    {
        private string name, surname;
        private int dni;

        private static List<int> documents = new List<int>();
        public int Dni { get => dni; set => dni = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }


        public static List<int> Documents { get => documents; set => documents = value; }

        public void basic_data()
        {

            Console.WriteLine("REGISTER");
            Console.WriteLine("");

            //collect basic data from people

            Console.WriteLine("Name");
            Name = Console.ReadLine();

            Console.WriteLine("SurName");
            Surname = Console.ReadLine();

            Console.WriteLine("DNI");
            Dni = int.Parse(Console.ReadLine());

            while (Documents.IndexOf(Dni) > -1)
            {
                Console.WriteLine("This DNI already exist. Please type a DNI don't are registered");
                Dni = int.Parse(Console.ReadLine());
            }
                
            

            Documents.Add(Dni);
        }
    }
}
