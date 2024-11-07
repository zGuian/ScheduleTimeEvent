package com.gearguru.schedule_time_event.Domain.Entities;

import lombok.*;

@Getter(AccessLevel.PUBLIC)
@Setter(AccessLevel.PRIVATE)
@NoArgsConstructor
public class Customer {
    private Long id;
    private final String firstName;
    private final String lastName;
    private final String fullName;
    private final String email;
    private final String phone;

    public Customer(String firstName, String lastName, String fullName, String email, String phone) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.fullName = fullName;
        this.email = email;
        this.phone = phone;
    }
}
