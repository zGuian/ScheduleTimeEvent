package com.gearguru.schedule_time_event.Domain.Entities;

import java.time.LocalDate;

public class Schedule {
    private Long id;
    private LocalDate scheduledTime;
    private Customer customer;
    private Barbershop barbershop;
}
