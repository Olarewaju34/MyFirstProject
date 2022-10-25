using TransportSystem.Entities;
using TransportSystem.Enums;
using TransportSystem.Repo;
using TransportSystem.Service;
using TransportSystem.Shared;


namespace TransportSystem.Menus
{
    public class Menus
    {
        private static ITransportRepo transportRepo;
        private static TransportDto transportDto;
        private static ITransportService transportService;
        private static Admin admin;
        public Menus()
        {
            transportDto = new TransportDto();
            transportRepo = new TranportRepo();
            transportService = new TransportService();
            admin = new Admin();
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
                        string username = Console.ReadLine();
                        Console.Write("Enter password: ");
                        string password = Console.ReadLine();
                        var employee = transportService.Login(username, password);
                        if (employee == null)
                        {
                            Console.WriteLine("Invalid Password");
                        }
                        else
                        {
                            if (employee.Password == admin.Password && employee.UserName == admin.UserName  )
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
                        transportService.TicketSales(transportDto);
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
        }
        private void PrintMenu()
        {
            Console.WriteLine("Enter 1 to login");
            Console.WriteLine("Enter 0 to exit");
        }
    }
}