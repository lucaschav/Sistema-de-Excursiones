using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ex.system
{
    class Employee : people
    {
        private int sales, id, id_counter = 0;

        private static List<Employee> employees = new List<Employee>();

        public Employee(string name, string surname, int dni, int id, int sales)
        {
            Name = name;
            Surname = surname;
            Dni = dni;
            this.id = id;
            this.sales = sales;
        }

        public Employee()
        {
        }

        public int Sales { get => sales; set => sales = value; }
        public int Id { get => id; set => id = value; }
        public int Id_counter { get => id_counter; set => id_counter = value; }

        public List<Employee> Employees { get => employees; set => employees = value; }

        public void employee_dates()
        {
            Id = Id_counter;

            Id_counter++;

            Sales = 0;
        }

        public void new_employee()
        {
            basic_data();

            employee_dates();

            Employee n_employee = new Employee(Name, Surname, Dni, Id, Sales);

            Employees.Add(n_employee);
        }

        public void see_employee()
        {
            int i = 0;

            while (i < Employees.Count)
            {
                
                Console.WriteLine(i + ".Name: " + Employees[i].Name + " |Surname: " + Employees[i].Surname + " |Dni: " + Employees[i].Dni + " |Id: " + Employees[i].Id);
                i++;
            }

            Console.ReadKey();
        }

        public void delete_employee()
        {

            int indx_elim;
            
            Console.WriteLine("Type number of index the employee they want to eliminate");
            Console.WriteLine("");
            see_employee();
            Console.WriteLine("");
            indx_elim = int.Parse(Console.ReadLine());

            while(indx_elim > Employees.Count - 1)
            {
                Console.WriteLine("The number typed don't exist. Please try again");
                indx_elim = int.Parse(Console.ReadLine());
            }

            Employees.RemoveAt(indx_elim);
            Console.WriteLine("The employee has been successfully removed");

        }

        public void add_sell()
        {
            int indx_elim;
            Console.WriteLine("Select for index number what employee selled the excursion");
            Console.WriteLine("");
            see_employee();
            Console.WriteLine("");
            try
            {
                indx_elim = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("error to type index. please try again");
                indx_elim = int.Parse(Console.ReadLine());
            }
            while (indx_elim >= Employees.Count)
            {
                Console.WriteLine("The number typed don't exist. Please try again");
                indx_elim = int.Parse(Console.ReadLine());
            }

            Employees[indx_elim].Sales = Employees[indx_elim].Sales + 1;
        }
    }
}
