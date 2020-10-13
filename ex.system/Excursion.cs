using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ex.system
{
    class Excursion
    {

        private string name_excur, travel, start_time, duration, day_excur;
        private int capacity_excur, total_excu_sells, visits;

        private static List<Excursion> trips = new List<Excursion>();

        public Excursion(string name_excur, string travel, string start_time, string duration, string day_excur, int capacity_excur, int visits)
        {
            this.name_excur = name_excur;
            this.travel = travel;
            this.start_time = start_time;
            this.duration = duration;
            this.day_excur = day_excur;
            this.capacity_excur = capacity_excur;
        }

        public Excursion()
        {
        }

        public string Name_excur { get => name_excur; set => name_excur = value; }
        public string Travel { get => travel; set => travel = value; }
        public string Start_time { get => start_time; set => start_time = value; }
        public string Duration { get => duration; set => duration = value; }
        public string Day_excur { get => day_excur; set => day_excur = value; }
        public int Capacity_excur { get => capacity_excur; set => capacity_excur = value; }
        public int Total_excu_sells { get => total_excu_sells; set => total_excu_sells = value; }
        public int Visits { get => visits; set => visits = value; }

        internal List<Excursion> Trips { get => trips; set => trips = value; }

        Client clnt = new Client();

        Employee emp = new Employee();

        Bus bus = new Bus();


        public void create_excursion()
        {
            int unit_select;

            Console.WriteLine("Name of excursion");
            Name_excur = Console.ReadLine();

            Console.WriteLine("Passenger collection points");
            Travel = Console.ReadLine();

            Console.WriteLine("Start time");
            Start_time = Console.ReadLine();

            Console.WriteLine("Duration");
            Duration = Console.ReadLine();

            Console.WriteLine("Day of excursion");
            Day_excur = Console.ReadLine();

            Console.WriteLine("Type the number of index for add the bus at a excursion");
            Console.WriteLine("");
            bus.see_free_buses();
            Console.WriteLine("");
            try
            {
                unit_select = int.Parse(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("error to insert data.please try again");
                unit_select = int.Parse(Console.ReadLine());
            }
            while (unit_select > bus.Buses.Count - 1)
            {
                Console.WriteLine("The unit number joined not exist. Please type other number unit");
                unit_select = int.Parse(Console.ReadLine());
            }

            Capacity_excur = bus.Buses[unit_select].Capacity;
            bus.Buses[unit_select].State = "Occupied";
            Visits = 0;

            Excursion new_excur = new Excursion(Name_excur, Travel, Start_time, Duration, Day_excur, Capacity_excur,Visits);
            Trips.Add(new_excur);
            Console.WriteLine("Successfully created trip");

        }

        public void see_excursions()
        {
            int i = 0;

            while (i < Trips.Count)
            {
                
                Console.WriteLine(i + ".Trip Name: " + Trips[i].Name_excur + " |Trip Day: " + Trips[i].Day_excur + " |Trip Start Time " + Trips[i].Start_time + " |Remaining Tickets " + Trips[i].Capacity_excur);
                i++;
            }

        }

        public void remove_excursion()
        {

            int indx_remove;

            Console.WriteLine("Select index number of the excursion want to remove");
            Console.WriteLine("");
            see_excursions();
            Console.WriteLine("");
            indx_remove = int.Parse(Console.ReadLine());
            while (indx_remove > Trips.Count)
            {
                Console.WriteLine("The number typed don't exist. Please try again");
                indx_remove = int.Parse(Console.ReadLine());
            }

            Trips.RemoveAt(indx_remove);
            bus.Buses[indx_remove].State = "Free";

            Console.Clear();
            Console.WriteLine("Excursion correctly removed");

        }

        public void buy_ticket()
        {
            int  tickets, indx_exc, id_log = 0;
            Boolean log = false;

            (log,id_log) = clnt.login();

            if (log == false)
            {
                Console.WriteLine("Error logging into account");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Hello, " + clnt.Customers[id_log].Name);
                Console.WriteLine("");
                Console.WriteLine("Type index number of the trip");
                Console.WriteLine("");
                see_excursions();
                try
                {
                    indx_exc = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("error to insert data.please try again");
                    indx_exc = int.Parse(Console.ReadLine());
                }
                while (indx_exc > Trips.Count)
                {
                    Console.WriteLine("The number typed not exist. Please try again");
                    indx_exc = int.Parse(Console.ReadLine());
                }

                Console.Clear();
                Console.WriteLine("Type how many ticket you buying");
                tickets = int.Parse(Console.ReadLine());

                while (tickets > Trips[indx_exc].Capacity_excur)
                {
                    Console.WriteLine("Max tickets available for trip is " + Trips[indx_exc].Capacity_excur + ". Please try again");
                    tickets = int.Parse(Console.ReadLine());
                }

                Console.Clear();
                Trips[indx_exc].Visits += 1;
                Trips[indx_exc].Capacity_excur -= tickets;
                emp.add_sell();
                Console.WriteLine("transaction complete");

            }
        }
    }
}
