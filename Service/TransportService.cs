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

        

        public void GetAll()
        {
            var transports = transportRepo.GetTransports();
            foreach (var transport in transports)
            {
                PrintAll(transport);
            }
        }

        public Admin Login(string password)
        {
            var admin = transportRepo.GetAdmin(password);
            if (admin != null && admin.Password == password)
            {
                return admin;
            }
            return null;
        }

        public void PrintAll(Transport transport)
        {
            Console.WriteLine($"${transport.PriceOfBus}\t{transport.Mode}\t{transport.Route}\t{transport.Date}");
        }

        public void PrintTickets(TransportDto transportDto)
        {
            Console.WriteLine($"Ticket Price: ${transportDto.PriceOfBus}\tVehicle: {transportDto.Mode}\tDetination: {transportDto.Route}");
        }

        public void TicketSales(TransportDto request)
        {
            var transports = transportRepo.GetTransports();
            int route = Helper.SelectEnum("Enter 1 for ojota\t2 for Maryland\t3for Idiroko\t4 for Anthony\t5 for Obanikoro\t6 for Palm Groove\t7 for Onipanu\n8 for Fadeyi: ", 1, 7);
            request.Route = (Route)route;

            int mode = Helper.SelectEnum("Enter for 1 for korokpe\n2 for Danfo\n3 for Brt: ", 1, 3);
            request.Mode = (Mode)mode;

            DateTime date = DateTime.Now;


            Transport transport = new Transport
            {
                Route = request.Route,
                Mode = request.Mode,
                Date = date
            };
            transports.Add(transport);
        }



    }
}