package com.gearguru.schedule_time_event.Application.Handlers;

import com.gearguru.schedule_time_event.Application.Interfaces.IBarberShopHandler;
import com.gearguru.schedule_time_event.Application.Services.BarberShopService;
import com.gearguru.schedule_time_event.Application.UseCases.BarberShopUseCase;
import com.gearguru.schedule_time_event.Domain.Entities.Schedule;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@Component
public class BarberShopHandler implements IBarberShopHandler {
    private final BarberShopService barberShopService;
    private final BarberShopUseCase barberShopUseCase;

    @Autowired
    public BarberShopHandler(BarberShopService barberShopService, BarberShopUseCase barberShopUseCase) {
        this.barberShopService = barberShopService;
        this.barberShopUseCase = barberShopUseCase;
    }

    @Override
    public Schedule createSchedule(Schedule schedule) {
        barberShopService.checkIfTimeIsAvailable();


        return null;
    }
}
