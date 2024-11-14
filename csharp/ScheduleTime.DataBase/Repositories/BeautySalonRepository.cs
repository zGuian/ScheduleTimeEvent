using ScheduleTime.DataBase.Context;
using ScheduleTime.DataBase.Interfaces;
using ScheduleTime.DataBase.Repositories.Base;
using ScheduleTime.Domain.Entities;
using ScheduleTime.Domain.Responses;

namespace ScheduleTime.DataBase.Repositories
{
    public class BeautySalonRepository : IBaseRepository<BarberShop>, IBeautySalonRepository
    {
        private readonly AppDbContext _context;

        public BeautySalonRepository()
        {
            if (_context == null) throw new ArgumentNullException(nameof(_context));
        }

        public BeautySalonRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ObjectResponse<Schedule>> CheckIfTimeIsAvailableAsync(DateTime dateTime)
        {
            // CRIAR LOGICA PARA VERIFICAR SE ESTA DISPONIVEL O HORARIO PASSADO PELO PARAMETRO
            throw new NotImplementedException();
        }
    }
}
