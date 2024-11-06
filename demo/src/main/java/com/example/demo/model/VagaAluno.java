package com.example.demo.model;

import jakarta.persistence.*;

@Entity
@Table(name = "Connect_Vaga_Aluno")
public class VagaAluno {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int idVaga_Aluno;
    @Column
    private int codigo_Vaga;
    @Column
    private int idAluno;

    public int getIdVaga_Aluno() {
        return idVaga_Aluno;
    }

    public void setIdVaga_Aluno(int idVaga_Aluno) {
        this.idVaga_Aluno = idVaga_Aluno;
    }

    public int getCodigo_Vaga() {
        return codigo_Vaga;
    }

    public void setCodigo_Vaga(int codigo_Vaga) {
        this.codigo_Vaga = codigo_Vaga;
    }

    public int getIdAluno() {
        return idAluno;
    }

    public void setIdAluno(int idAluno) {
        this.idAluno = idAluno;
    }
}
