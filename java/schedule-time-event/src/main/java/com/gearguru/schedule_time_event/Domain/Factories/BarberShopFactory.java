package com.gearguru.schedule_time_event.Domain.Factories;

import com.gearguru.schedule_time_event.Domain.Entities.Barbershop;
import com.gearguru.schedule_time_event.Domain.Entities.Schedule;
import com.gearguru.schedule_time_event.Domain.Interfaces.IScheduleFactory;

public class BarberShopFactory implements IScheduleFactory {
    @Override
    public Schedule scheduleTime() {
        return new Barbershop();
    }
}
