using ScheduleTime.CrossCutting.DTOs.VOs;

namespace ScheduleTime.CrossCutting.DTOs.V1
{
    public record BeautySalonDTO
    {
        public CustomerDTO Customer { get; init; }
        public HairVO? Hair { get; init; }
        public NailVO? Nail { get; init; }
        public LashVO? Lash { get; init; }
        public AnotherProcedureVO? AnotherProcedure { get; init; }
        public ScheduleDTO Schedule { get; init; }

        private BeautySalonDTO()
        {
            if (Customer == null) throw new ArgumentNullException(nameof(Customer));
            if (Schedule == null) throw new ArgumentNullException(nameof(Schedule));
        }

        public BeautySalonDTO(CustomerDTO customer, ScheduleDTO schedule, HairVO? hair, NailVO? nail, LashVO? lash, AnotherProcedureVO? anotherProcedure)
        {
            Customer = customer;
            Schedule = schedule;
            Hair = hair;
            Nail = nail;
            Lash = lash;
            AnotherProcedure = anotherProcedure;
        }
    }
}
