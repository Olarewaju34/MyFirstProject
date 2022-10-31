using TransportSystem.Repo;
using TransportSystem.Entities;

namespace TransportSystem.Repo
{
 public interface ITransportRepo
    {
        List<Transport> GetTransports();
         Admin GetAdmin(string password);
      
    }
}
   