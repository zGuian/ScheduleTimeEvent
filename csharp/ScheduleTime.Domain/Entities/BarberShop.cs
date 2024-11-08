using ScheduleTime.Domain.Entities.ServiceType;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleTime.Domain.Entities
{
    [Table("barber_shop")]
    public class BarberShop
    {
        public long Id { get; private set; }
        public AnotherProcedure? AnotherProcedure { get; private set; }
        public Hair? Hair { get; private set; }
    }
}
