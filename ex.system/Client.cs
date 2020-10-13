using System;
using System.Collections.Generic;
using System.Text;

namespace ex.system
{
    class Client : people
    {
        private int id, shopping, id_counter = 0;

        private static List<Client> customers = new List<Client>();

        public Client(string name, string surname, int dni, int id, int shopping)
        {
            Name = name;
            Surname = surname;
            Dni = dni;
            this.id = id;
            this.shopping = shopping;
        }

        public Client()
        {
        }

        public int Id { get => id; set => id = value; }
        public int Shopping { get => shopping; set => shopping = value; }
        public int Id_counter { get => id_counter; set => id_counter = value; }

        internal List<Client> Customers { get => customers; set => customers = value; }

        public void client_date()
        {
            Id = Id_counter;

            Id_counter++;

            Shopping = 0;

            //add specific data of the client
        }

        public void new_client()
        {
            basic_data();

            client_date();


            Client n_client = new Client(Name,Surname,Dni,Id,Shopping);

            //generating object "client" for later add in the list of clients

            Customers.Add(n_client);

            Console.WriteLine("You id is: " + (Id_counter - 1));

            Console.WriteLine("Registered seccessfully");
        }

        public void see_customers()
        {
            int i = 0;

            while (i <= Customers.Count)
            {
                
                Console.WriteLine(i + ".Name: " + Customers[i].Name + " |Surname: " + Customers[i].Surname + " |Dni: " + Customers[i].Dni + " |Id: " + Customers[i].Id);
                i++;
            }
        }

        public void remove_client()
        {
            int id_remove;

            Console.WriteLine("Type id of clien want to remove");
            Console.WriteLine("");
            see_customers();
            id_remove = int.Parse(Console.ReadLine());
            Console.Clear();

            while (id_remove > (Customers.Count - 1))
            {

                Console.WriteLine("The id not exist. Please try again");
                Console.WriteLine("");
                id_remove = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Customers.RemoveAt(id_remove);
            Console.WriteLine("The client has been successfully removed");
        }

        public Tuple<Boolean,int> login()
        {
            int dni_reciv, id_reciv;

            Console.WriteLine("ID");
            id_reciv = int.Parse(Console.ReadLine());
            Console.WriteLine("DNI");
            dni_reciv = int.Parse(Console.ReadLine());

            if( id_reciv > Customers.Count || Customers[id_reciv].Dni != dni_reciv )
            {

                return new Tuple<bool, int>(false,id_reciv);
            }

            else
            {

                return new Tuple<bool, int>(true, id_reciv);
            }
        }


    }
}
