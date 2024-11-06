using ScheduleTime.Domain.Entities.Interfaces;
using ScheduleTime.Domain.Entities.ServiceType;

namespace ScheduleTime.Domain.Entities
{
    public class BeautySalon : HairService, IBeautySalonServices
    {
        public long Id { get; private set; }
        public NailService Nail { get; private set; } = null!;
        public LashService Lash { get; private set; } = null!;

        public void HairTreatment()
        {
            throw new NotImplementedException();
        }

        public void PerformsChemistry()
        {
            throw new NotImplementedException();
        }

        public void PerformsLashDesign()
        {
            throw new NotImplementedException();
        }

        public void PerformsNailDesign()
        {
            throw new NotImplementedException();
        }
    }
}
