using System;
using System.Collections.Generic;
using System.Text;

namespace ex.system
{
    public class Bus
    {
        private string brand, state;
        private int model, capacity, n_unit;

        private static List<Bus> buses = new List<Bus>();

        private static List<int> units_numbers = new List<int>();

        public Bus()
        {
        }

        public Bus(string brand, int n_unit, int capacity, int model, string state)
        {
            this.brand = brand;
            this.n_unit = n_unit;
            this.capacity = capacity;
            this.model = model;
            this.state = state;
        }

        

        public int Model { get => model; set => model = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int N_unit { get => n_unit; set => n_unit = value; }
        public string Brand { get => brand; set => brand = value; }
        public string State { get => state; set => state = value; }

        public List<Bus> Buses { get => buses; set => buses = value; }
        public List<int> Units_numbers { get => units_numbers; set => units_numbers = value; }

        public void register_bus()
        {
            Console.WriteLine("Brand");
            Brand = Console.ReadLine();
            Console.WriteLine("Number of unit");
            N_unit = int.Parse(Console.ReadLine());

            while(Units_numbers.IndexOf(N_unit) != -1)
            {
                Console.WriteLine("This number of unit is already exist. Please type a number don't registered");
                N_unit = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Capacity");
            Capacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Model");
            Model = int.Parse(Console.ReadLine());
            State = "Free";

            Units_numbers.Add(N_unit);
            Bus new_bus = new Bus(Brand, N_unit, Capacity, Model, State);
            Buses.Add(new_bus);
        }

        public void see_all_buses()
        {
            int i = 0;

            while (i < Buses.Count)
            {
                
                Console.WriteLine(i + ".Brand: " + Buses[i].Brand + " |Model: " + Buses[i].Model + " |Capacity: " + Buses[i].Capacity + " |Number of Unit: " + Buses[i].N_unit + " |Status: " + Buses[i].State);
                i++;
            }
        }

        public void see_free_buses()
        {
            int i = 0;

            while (i < Buses.Count)  
            {
                if(Buses[i].State == "Free")
                {
                    
                    Console.WriteLine(i + ".Brand: " + Buses[i].Brand + " |Model: " + Buses[i].Model + " |Capacity: " + Buses[i].Capacity + " |Number of Unit: " + Buses[i].N_unit + " |Status: " + Buses[i].State);
                }
                i++;

            }
            
        }

        public void remove_bus()
        {

            int unit_remove;

            Console.WriteLine("NOTE: Only can remove buses with state 'Occupied'. if you want remove other bus first remove excursion linked at bus ");
            Console.WriteLine("Type unit number bus want you remove");
            Console.WriteLine("");
            see_free_buses();
            Console.WriteLine("");
            unit_remove = int.Parse(Console.ReadLine());

            while(Units_numbers.IndexOf(unit_remove) == -1)
            {
                Console.WriteLine("The unit number type not exist. Please try again");
                unit_remove = int.Parse(Console.ReadLine());
            }

            int indx = Units_numbers.IndexOf(unit_remove);
            Buses.RemoveAt(indx);
            Console.WriteLine("The bus has been successfully removed");


        }
    }
}
