using TransportSystem.Service;
using TransportSystem.Entities;

namespace TransportSystem.Service
{
    public interface ITransportService
    {
        void TicketSales(TransportDto request);
        void PrintTickets(Transport transport);
        void AdminRecords();
        Admin Login(string username,string password);
    }
}