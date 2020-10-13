using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex.system
{
    class Statistic
    {

        Client clnt = new Client();

        Employee emp = new Employee();

        Client cln = new Client();

        Excursion exc = new Excursion();

        public void top_Trips()
        {
            int i = 0;

            exc.Trips = exc.Trips.OrderByDescending(x => x.Visits).ToList();

            while (i <= exc.Trips.Count)
            {
                Console.WriteLine(i + ".Trip Name: " + exc.Trips[i].Name_excur + " |Trip Day: " + exc.Trips[i].Day_excur + " |Trip Start Time: " + exc.Trips[i].Start_time + " |Trip Capacity: " + exc.Trips[i].Capacity_excur);
                i++;
            }
        }

        public void top_employees()
        {
            int i = 0;

            emp.Employees = emp.Employees.OrderByDescending(x => x.Sales).ToList();

            while (i < emp.Employees.Count)
            {

                Console.WriteLine(i + ".Name: " + emp.Employees[i].Name + " |Surname: " + emp.Employees[i].Surname + " |Dni: " + emp.Employees[i].Dni + " |Id: " + emp.Employees[i].Id + " |Sales: " + emp.Employees[i].Sales);
                i++;
            }
        }

        public void top_client()
        {
            int i = 0;

            cln.Customers = cln.Customers.OrderByDescending(x => x.Shopping).ToList();

            while (i <= cln.Customers.Count)
            {

                Console.WriteLine(i + ".Name: " + cln.Customers[i].Name + " |Surname: " + cln.Customers[i].Surname + " |Dni: " + cln.Customers[i].Dni + " |Id: " + cln.Customers[i].Id + " |Shopping: " + cln.Customers[i].Shopping);
                i++;
            }
        }
    }
}
