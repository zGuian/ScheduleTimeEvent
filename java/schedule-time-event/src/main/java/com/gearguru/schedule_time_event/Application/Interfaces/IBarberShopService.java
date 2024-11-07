package com.gearguru.schedule_time_event.Application.Interfaces;

import com.gearguru.schedule_time_event.Domain.Entities.Schedule;

public interface IBarberShopService {
    Schedule checkIfTimeIsAvailable();
}
