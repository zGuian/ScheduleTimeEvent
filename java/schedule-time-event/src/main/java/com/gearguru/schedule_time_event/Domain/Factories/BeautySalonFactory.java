package com.gearguru.schedule_time_event.Domain.Factories;

import com.gearguru.schedule_time_event.Domain.Entities.BeautySalon;
import com.gearguru.schedule_time_event.Domain.Entities.Schedule;
import com.gearguru.schedule_time_event.Domain.Interfaces.IScheduleFactory;

public class BeautySalonFactory implements IScheduleFactory {
    @Override
    public Schedule scheduleTime() {
        return new BeautySalon();
    }
}
