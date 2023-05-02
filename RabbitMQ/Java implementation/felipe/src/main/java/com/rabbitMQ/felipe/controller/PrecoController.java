package com.rabbitMQ.felipe.controller;

import com.rabbitMQ.felipe.service.RabbitmqService;
import constantes.RabbitmqConstantes;
import dto.PrecoDto;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping(value = "preco")
public class PrecoController {

    @Autowired
    private RabbitmqService rabbitmqService;
    @PutMapping
    private ResponseEntity alteraPreco(@RequestBody PrecoDto precoDto){
        System.out.println("-----------------------------------------------------------------");
        System.out.println("Foi enviado o preço do produto com o código:" + precoDto.codigoPreco);
        System.out.println("-----------------------------------------------------------------");
        this.rabbitmqService.enviaMensagem(RabbitmqConstantes.FILA_PRECO,precoDto);
        return new ResponseEntity(HttpStatus.OK);
    }
}
