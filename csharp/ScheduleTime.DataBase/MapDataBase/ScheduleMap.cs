using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.DataBase.MapDataBase
{
    internal class ScheduleMap : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            throw new NotImplementedException();
        }
    }
}
