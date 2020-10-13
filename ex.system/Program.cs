using System;
using System.Diagnostics;

namespace ex.system
{
    class Program
    {
        static void Main(string[] args)
        {
            Excursion exc = new Excursion();

            Bus bus1 = new Bus();

            Client clnt = new Client();

            Employee empl = new Employee();

            Statistic stat = new Statistic();

            int indx_select = 0,inter_select;


            while (indx_select != 5)
            {
                Console.WriteLine("          -----------");
                Console.WriteLine("          TRIP SYSTEM         ");
                Console.WriteLine("          -----------");
                Console.WriteLine("");
                Console.WriteLine("1. GENERATE TRIPS");
                Console.WriteLine("2. EMPLOYEE ADMINISTRATION");
                Console.WriteLine("3. TRIPS SALE");
                Console.WriteLine("4. STADISTICS");
                Console.WriteLine("5. EXIT");

                try
                {
                    indx_select = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please type number of index");
                    indx_select = int.Parse(Console.ReadLine());
                }

                Console.Clear();

                switch (indx_select)
                {
                    case 1:

                        Console.WriteLine("          ---------------");
                        Console.WriteLine("          BUSES AND TRIPS");
                        Console.WriteLine("          ---------------");
                        Console.WriteLine("");
                        Console.WriteLine("1. GENERATE TRIP");
                        Console.WriteLine("2. REMOVE TRIP");
                        Console.WriteLine("3. REGISTER BUS");
                        Console.WriteLine("4. REMOVE BUS");
                        Console.WriteLine("5. TRIP LIST");
                        Console.WriteLine("6. BACK");

                        try
                        {
                            inter_select = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Please type number of index");
                            inter_select = int.Parse(Console.ReadLine());
                        }

                        Console.Clear();

                        switch (inter_select)
                        {
                            case 1:

                                exc.create_excursion();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 2:

                                exc.remove_excursion();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 3:

                                bus1.register_bus();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 4:

                                bus1.remove_bus();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 5:

                                exc.see_excursions();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 6:

                                break;

                            default:

                                Console.WriteLine("the number typed dont exist in index. Please try again");
                                inter_select = int.Parse(Console.ReadLine());

                                break;
                        }

                        break;

                    case 2:

                        Console.WriteLine("     -----------------------");
                        Console.WriteLine("     EMPLOYEE ADMINISTRATION");
                        Console.WriteLine("     -----------------------");
                        Console.WriteLine("");
                        Console.WriteLine("1. REGISTER EMPLOYEE");
                        Console.WriteLine("2. REMOVE EMPLOYEE");
                        Console.WriteLine("3. EMPLOYEE LIST");
                        Console.WriteLine("4. BACK");

                        try
                        {
                            inter_select = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Please type number of index");
                            inter_select = int.Parse(Console.ReadLine());
                        }

                        Console.Clear();

                        switch(inter_select)
                        {

                            case 1:

                                empl.new_employee();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 2:

                                empl.delete_employee();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 3:

                                empl.see_employee();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 4:

                                

                                break;

                            default:

                                Console.WriteLine("the number typed dont exist in index. Please try again");
                                inter_select = int.Parse(Console.ReadLine());

                                break;

                        }

                        break;

                    case 3:

                        Console.WriteLine("        ----------");
                        Console.WriteLine("        TRIP SALES");
                        Console.WriteLine("        ----------");
                        Console.WriteLine("");
                        Console.WriteLine("1. REGISTER CLIENT");
                        Console.WriteLine("2. BUY TICKET");
                        Console.WriteLine("3. REMOVE CLIENT");
                        Console.WriteLine("4. BACK");

                        try
                        {
                            inter_select = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Please type number of index");
                            inter_select = int.Parse(Console.ReadLine());
                        }

                        switch (inter_select)
                        {
                            case 1:

                                clnt.new_client();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 2:

                                exc.buy_ticket();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 3:

                                clnt.remove_client();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 4:

                                break;

                            default:

                                break;
                        }

                        break;

                    case 4:

                        Console.WriteLine("            ----------");
                        Console.WriteLine("            STATISTICS");
                        Console.WriteLine("            ----------");
                        Console.WriteLine("");
                        Console.WriteLine("1. TOP EMPLOYEE");
                        Console.WriteLine("2. TOP CUSTOMERS");
                        Console.WriteLine("3. TOP TRIPS");
                        Console.WriteLine("4. BACK");

                        try
                        {
                            inter_select = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Please type number of index");
                            inter_select = int.Parse(Console.ReadLine());
                        }

                        Console.Clear();

                        switch (inter_select)
                        {
                            case 1:

                                stat.top_employees();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 2:

                                stat.top_client();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 3:

                                stat.top_Trips();
                                Console.ReadKey();
                                Console.Clear();

                                break;

                            case 4:

                                break;

                            default:

                                break;
                        }


                        break;

                    case 5:

                        break;

                    default:

                        Console.WriteLine("the number typed dont exist in index. Please try again");
                        indx_select = int.Parse(Console.ReadLine());

                        break;
                }
            }

        }
    }
}
