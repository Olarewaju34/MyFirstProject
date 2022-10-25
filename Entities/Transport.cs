using TransportSystem.Enums;

namespace TransportSystem.Entities
{
    public class Transport
    {
        public Route Route { get; set; }
        public Mode Mode { get; set; }
        public decimal PriceOfBus { get { return 100; } }
        public DateTime Date { get; set; }
    }
}