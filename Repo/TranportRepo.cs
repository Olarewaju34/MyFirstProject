using TransportSystem.Service;
using TransportSystem.Repo;
using TransportSystem.Entities;

namespace TransportSystem.Repo
{
    public class TranportRepo : ITransportRepo
    {
        public static List<Transport> AllTransport;
        public static List<Admin> admins;
        public TranportRepo()
        {
            AllTransport = new List<Transport>();
            admins = new List<Admin>();
        }

        public Admin GetAdmin(string password)
        {
           return  admins.Find(i => i.Password == password);
        }

        public List<Transport> GetTransports()
        {
            return AllTransport;
        }


    }
}