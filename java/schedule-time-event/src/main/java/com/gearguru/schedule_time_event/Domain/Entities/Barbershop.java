package com.gearguru.schedule_time_event.Domain.Entities;

import com.gearguru.schedule_time_event.Domain.Entities.ServiceType.Hair;
import lombok.AccessLevel;
import lombok.*;

@Getter(AccessLevel.PUBLIC)
@Setter(AccessLevel.PRIVATE)
@NoArgsConstructor
public class Barbershop implements Schedule {
    private Long id;
    private Customer customer;
    private Hair hair;
    private boolean Beard;


    public void haircutSchedule(Customer customer) {

    }

    public Schedule beardCuttingSchedule(Customer customer, Barbershop barbershop) {
        barbershop.Beard = true;
        return this;
    }

    @Override
    public void scheduleTime() {

    }
}
