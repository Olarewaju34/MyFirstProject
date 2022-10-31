using TransportSystem.Service;
using TransportSystem.Repo;
using TransportSystem.Entities;
using TransportSystem.Enums;

namespace TransportSystem.Repo
{
    public class TranportRepo : ITransportRepo
    {
        public static List<Transport> AllTransport;
        public static List<Admin> admins = new List<Admin>()
        { new Admin()
          {
            UserName = "Olarewaju",
            Password = "Olarewaju11$",
            Role = Role.Admin
          }
        };


        public TranportRepo()
        {
            AllTransport = new List<Transport>();
        }

        public Admin GetAdmin(string password)
        {
            return admins.Find(i => i.Password == password);
        }

        public List<Transport> GetTransports()
        {
            return AllTransport;
        }


    }
}