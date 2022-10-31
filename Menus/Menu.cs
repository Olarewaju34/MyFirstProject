using TransportSystem.Entities;
using TransportSystem.Enums;
using TransportSystem.Repo;
using TransportSystem.Service;
using TransportSystem.Shared;


namespace TransportSystem.Menus
{
    public class Menus
    {
        private static TransportDto transportDto;
        private static ITransportService transportService;

        public Menus()
        {
            transportDto = new TransportDto();
            transportService = new TransportService();
        }
        public void MyMenu()
        {
            var flag = true;
            while (flag)
            {
                PrintMenu();
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("Enter UserName: ");
                        var username = Console.ReadLine();
                        Console.Write("Enter password: ");
                        var password = Console.ReadLine();
                        var employee = transportService.Login(password);
                        if (employee == null)
                        {
                            Console.WriteLine("Invalid Password");
                        }
                        else
                        {
                            if (employee.Role == Role.Admin)
                            {
                                AdminMenu();
                            }
                        }
                        break;
                    case "0":
                        flag = false;
                        Console.WriteLine("Thank you for using our App...");
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }

        }
        private void AdminMenu()
        {
            var flag = true;
            while (flag)
            {
                PrintAdminMenu();
                Console.Write("Enter Option: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("");
                        transportService.TicketSales(transportDto);
                        Console.WriteLine("Your Ticket");
                        transportService.PrintTickets(transportDto);
                        break;
                    case "2":
                        Console.WriteLine("");
                        transportService.GetAll();
                        break;
                    case "0":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }

        }
        private void PrintAdminMenu()
        {
            Console.WriteLine("Enter 1 to buy tickets");
            Console.WriteLine("Enter 2 to view all ticket sold");
            Console.WriteLine("Enter 0 to go back to main menu");
        }
        private void PrintMenu()
        {
            Console.WriteLine("Enter 1 to login");
            Console.WriteLine("Enter 0 to exit");
        }
    }
}