package com.uninove.point.model.entity;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import java.io.Serializable;

@Entity
@Getter
@Setter
public class Produto implements Serializable {


        @SequenceGenerator(
                name = "produto_sequence",
                sequenceName = "produto_sequence",
                allocationSize = 1
        )
        @Id
        @GeneratedValue(
                strategy = GenerationType.SEQUENCE,
                generator = "produto_sequence"
        )
        private Long Id;
        private String descricao;
        private String categoria;
        private float preco;
        private int quantidade;

        @ManyToOne
        @JoinColumn(name = "usuario_id")
        private Usuario usuario;
}
