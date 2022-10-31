using TransportSystem.Enums;

namespace TransportSystem.Entities
{
    public class Admin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}