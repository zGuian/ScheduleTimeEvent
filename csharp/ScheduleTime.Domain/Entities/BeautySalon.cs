using ScheduleTime.Domain.Entities.ServiceType;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScheduleTime.Domain.Entities
{
    [Table("beauty_salon")]
    public class BeautySalon
    {
        public long Id { get; private set; }
        public Hair? Hair { get; private set; }
        public Nail? Nail { get; private set; }
        public Lash? Lash { get; private set; }
        public AnotherProcedure? AnotherProcedure { get; private set; }
        public Schedule Schedule { get; private set; } = null!;

        private BeautySalon() { }

        public BeautySalon(Schedule schedule, Hair? hair = null, Nail? nail = null, Lash? lash = null, AnotherProcedure? anotherProcedure = null)
        {
            Hair = hair;
            Nail = nail;
            Lash = lash;
            AnotherProcedure = anotherProcedure;
            Schedule = schedule;
        }

        public static class Factories
        {
            public static BeautySalon CreateBeautySalon(Schedule schedule, Hair? hair = null, Nail? nail = null, 
                Lash? lash = null, AnotherProcedure? anotherProcedure = null)
            {
                return new BeautySalon(schedule, hair, nail, lash, anotherProcedure);
            }
        }
    }
}
