package com.gearguru.schedule_time_event.Domain.Entities.ServiceType;

import lombok.*;

import java.time.LocalDate;

@Getter(AccessLevel.PUBLIC)
@Setter(AccessLevel.PRIVATE)
@NoArgsConstructor
@AllArgsConstructor
public class HairService {
    private boolean painting;
    private String color;
    private boolean anotherService;
    private String anotherServiceText;
    private LocalDate currentDay;
}
