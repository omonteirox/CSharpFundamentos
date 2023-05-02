package com.example.consumidorestoqueteste.consumer;

import constantes.RabbitmqConstantes;
import dto.EstoqueDto;

import org.springframework.amqp.rabbit.annotation.RabbitListener;
import org.springframework.stereotype.Component;

@Component
public class EstoqueConsumer {
    @RabbitListener(queues = RabbitmqConstantes.FILA_ESTOQUE)
    private void consumidor(EstoqueDto estoqueDto){
        System.out.println("Estoque recebido:");
        System.out.println("Código do estoque - "+estoqueDto.codigoproduto);
        System.out.println("Quantidade no estoque - "+estoqueDto.quantidade);
        System.out.println("-----------------------");
    }
}
