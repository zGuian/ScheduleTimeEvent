using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ScheduleTime.Domain.Entities;

namespace ScheduleTime.DataBase.MapDataBase
{
    internal class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            throw new NotImplementedException();
        }
    }
}
