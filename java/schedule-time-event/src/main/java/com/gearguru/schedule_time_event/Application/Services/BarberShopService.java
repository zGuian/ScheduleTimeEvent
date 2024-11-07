package com.gearguru.schedule_time_event.Application.Services;

import com.gearguru.schedule_time_event.Application.Interfaces.IBarberShopService;
import com.gearguru.schedule_time_event.Domain.Entities.Schedule;
import com.gearguru.schedule_time_event.Infrastructure.Interfaces.IBarberShopRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class BarberShopService implements IBarberShopService {
    private final IBarberShopRepository barberShopRepository;

    @Autowired
    public BarberShopService(IBarberShopRepository barberShopRepository) {
        this.barberShopRepository = barberShopRepository;
    }


    @Override
    public Schedule checkIfTimeIsAvailable() {
        ;
        return null;
    }
}
