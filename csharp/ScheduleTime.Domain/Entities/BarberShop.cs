﻿using ScheduleTime.Domain.Entities.Interfaces;
using ScheduleTime.Domain.Entities.ServiceType;

namespace ScheduleTime.Domain.Entities
{
    public class BarberShop : HairService, IBarberShopServices
    {
        private BarberShop() { }

        public BarberShop(Customer customer, DateTime date)
        {
        }

        public void HaircutSchedule()
        {
            throw new NotImplementedException();
        }

        public void BeardCuttingSchedule()
        {
            throw new NotImplementedException();
        }
    }
}