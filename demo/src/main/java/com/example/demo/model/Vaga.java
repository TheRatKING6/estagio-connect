package com.example.demo.model;

import jakarta.persistence.*;

@Entity
@Table(name = "Connect_Vagas")
public class Vaga {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int Codigo;

    //@ManyToOne
    //@JoinColumn(name = "idEmpresa", nullable = false)
    @Column
    private int id_empresa;
    @Column
    private String nome;
    @Column
    private String descricao;
    @Column
    private String area;
    @Column
    private String requisitos;
    @Column
    private String carga_horaria;

    public int getCodigo() {
        return Codigo;
    }

    public void setCodigo(int codigo) {
        Codigo = codigo;
    }

    public int getId_empresa() {
        return id_empresa;
    }

    public void setId_empresa(int id_empresa) {
        this.id_empresa = id_empresa;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public String getArea() {
        return area;
    }

    public void setArea(String area) {
        this.area = area;
    }

    public String getRequisitos() {
        return requisitos;
    }

    public void setRequisitos(String requisitos) {
        this.requisitos = requisitos;
    }

    public String getCarga_horaria() {
        return carga_horaria;
    }

    public void setCarga_horaria(String carga_horaria) {
        this.carga_horaria = carga_horaria;
    }
}
