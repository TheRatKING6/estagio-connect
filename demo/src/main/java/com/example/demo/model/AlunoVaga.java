package com.example.demo.model;

import jakarta.persistence.*;

@Entity
@Table(name = "Connect_Aluno_Vaga")
public class AlunoVaga {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int idAluno_Vaga;
    @Column
    private int idAluno;
    @Column
    private int codigo_Vaga;

    public int getIdAluno_Vaga() {
        return idAluno_Vaga;
    }

    public void setIdAluno_Vaga(int idAluno_Vaga) {
        this.idAluno_Vaga = idAluno_Vaga;
    }

    public int getIdAluno() {
        return idAluno;
    }

    public void setIdAluno(int idAluno) {
        this.idAluno = idAluno;
    }

    public int getCodigo_Vaga() {
        return codigo_Vaga;
    }

    public void setCodigo_Vaga(int codigo_Vaga) {
        this.codigo_Vaga = codigo_Vaga;
    }
}
