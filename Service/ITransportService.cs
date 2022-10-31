using TransportSystem.Service;
using TransportSystem.Entities;

namespace TransportSystem.Service
{
    public interface ITransportService
    {
        void TicketSales(TransportDto request);
        void PrintTickets(TransportDto  transport);
        void GetAll();
        void PrintAll(Transport transport);
        Admin Login(string password);
    }
}