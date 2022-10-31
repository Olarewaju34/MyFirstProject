using TransportSystem.Enums;
namespace TransportSystem.Entities
{
    public class TransportDto
    {

        public Route Route { get; set; }
        public Mode Mode { get; set; }
        public decimal PriceOfBus { get { return 100; } }
        

    }
}