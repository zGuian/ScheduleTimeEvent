using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.DataBase.MapDataBase
{
    internal class BeautySalonMap : IEntityTypeConfiguration<BeautySalon>
    {
        public void Configure(EntityTypeBuilder<BeautySalon> builder)
        {
            throw new NotImplementedException();
        }
    }
}
