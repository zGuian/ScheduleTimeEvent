package com.gearguru.schedule_time_event.Domain.Entities;

import com.gearguru.schedule_time_event.Domain.Entities.ServiceType.Hair;

public class BeautySalon implements Schedule{
    private Long id;
    private Customer customer;
    private Hair hair;

    @Override
    public void scheduleTime() {

    }
}
