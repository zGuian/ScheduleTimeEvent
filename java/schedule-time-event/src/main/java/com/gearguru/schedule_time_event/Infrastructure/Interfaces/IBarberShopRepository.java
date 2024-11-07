package com.gearguru.schedule_time_event.Infrastructure.Interfaces;

import com.gearguru.schedule_time_event.Domain.Entities.Barbershop;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import java.util.Date;

@Repository
public interface IBarberShopRepository extends JpaRepository<Barbershop, Long> {

    @Query(
            "SELECT u FROM u WHERE u.date =: date"
    )
    Barbershop checkIfTimeIsAvailable(Date date);
}
