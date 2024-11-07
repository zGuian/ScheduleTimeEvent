package com.gearguru.schedule_time_event.Presentation.Controllers;

import com.gearguru.schedule_time_event.Application.Interfaces.IBarberShopHandler;
import com.gearguru.schedule_time_event.Domain.Entities.Schedule;
import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.media.Content;
import io.swagger.v3.oas.annotations.media.Schema;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.tags.Tag;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("api/v1/BarberShop")
@Tag(name = "BarberShop", description = "Endpoint for schedule barbershop")
public class BarberShopController {
    private final IBarberShopHandler barberShopHandler;

    @Autowired
    public BarberShopController(IBarberShopHandler barberShopHandler) {
        this.barberShopHandler = barberShopHandler;
    }

    @Operation(summary = "Registra horario em barbearia", description = "registra horario em barbearia",
            tags = {"BarberShop"}, responses =  {
            @ApiResponse(description = "Success", responseCode = "200", content = {
                    @Content(schema = @Schema(implementation = Schedule.class))}),
            @ApiResponse(description = "Bad request", responseCode = "400", content = {@Content}),
            @ApiResponse(description = "Unauthorized", responseCode = "401", content = {@Content}),
            @ApiResponse(description = "Internal Error", responseCode = "500", content = {@Content})
    })
    @PostMapping(consumes = {MediaType.APPLICATION_JSON_VALUE, MediaType.APPLICATION_XML_VALUE},
            produces = {MediaType.APPLICATION_JSON_VALUE, MediaType.APPLICATION_XML_VALUE})
    public ResponseEntity<?> ScheduleTimeForBarberShop(@RequestBody Schedule schedule) {
       var respHandler = barberShopHandler.createSchedule(schedule);
       return null;
    }
}
