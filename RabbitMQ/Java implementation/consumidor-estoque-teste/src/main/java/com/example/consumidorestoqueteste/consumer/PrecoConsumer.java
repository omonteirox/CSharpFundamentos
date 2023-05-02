package com.example.consumidorestoqueteste.consumer;

import constantes.RabbitmqConstantes;
import dto.PrecoDto;
import org.springframework.amqp.rabbit.annotation.RabbitListener;
import org.springframework.stereotype.Component;

@Component
public class PrecoConsumer {
    @RabbitListener(queues = RabbitmqConstantes.FILA_PRECO)
    private void consumidor(PrecoDto precoDto){
        System.out.println("Preço recebido: ");
        System.out.println("Código do preço - "+precoDto.codigoPreco);
        System.out.println("Preço - R$"+precoDto.preco);
        System.out.println("------------------------------------------");
    }
}
