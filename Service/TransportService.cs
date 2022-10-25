using TransportSystem.Enums;
using TransportSystem.Service;
using TransportSystem.Shared;
using TransportSystem.Repo;
using TransportSystem.Entities;

namespace TransportSystem.Service
{
    public class TransportService : ITransportService
    {
        private readonly ITransportRepo transportRepo;

        public TransportService()
        {
            transportRepo = new TranportRepo();
        }

        public void AdminRecords()
        {
            var e = new Admin
            {
                UserName = "Olarewaju",
                Password = "Olarewaju$112"
            };
        }

        public Admin Login(string username, string password)
        {
            var admin = transportRepo.GetAdmin(password);
            if (admin != null && admin.Password == password)
            {
                return admin;
            }
            return null;
        }

        public void PrintTickets(Transport transport)
        {
            Console.WriteLine($"{transport.PriceOfBus}\n{transport.Mode}\n{transport.Route}\n{transport.Date}");
        }

        public void TicketSales(TransportDto request)
        {
            var transports = transportRepo.GetTransports();
            int route = Helper.SelectEnum("Enter 1 for ojota\n 2 for Maryland\n3 for Idiroko\n4 for Anthony\n5 for Obanikoro\n6 for Palm Groove\n7 for Onipanu\n8 for Fadeyi", 1, 7);
            request.Route = (Route)route;

            int mode = Helper.SelectEnum("Enter for 1 for korokpe\n2 for Danfo\n3 for Brt", 1, 3);
            request.Mode = (Mode)mode;

            DateTime date = DateTime.Now;

            Transport transport = new Transport
            {
                Route = request.Route,
                Mode = request.Mode,
                Date = date,
            };
            transports.Add(transport);
        }
    }
}