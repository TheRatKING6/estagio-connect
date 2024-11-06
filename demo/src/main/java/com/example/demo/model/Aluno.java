package com.example.demo.model;

import jakarta.persistence.*;

@Entity
@Table(name="Connect_Aluno")
public class Aluno {
    @Id
    @GeneratedValue(strategy=GenerationType.IDENTITY)
    private int idAluno;

    //------------------------------ ATRIBUTOS --------------------------------------
    @Column(nullable = false)
    private String cpf;
    @Column
    private String matricula;
    @Column
    private String nome;
    @Column
    private String nascimento;
    @Column
    private String email;
    @Column
    private String telefone;
    @Column
    private String especialidade;
    @Column
    private String descricao;
    @Column
    private String rua;
    @Column
    private int numero;
    @Column
    private String bairro;
    @Column
    private String complemento;
    @Column
    private String cidade;
    @Column
    private String estado;
    @Column
    private String cep;
    @Column
    private String status;
    @Column
    private int ano;
    @Column
    private String escola;
    @Column
    private String senha;
    @Column(length=800)
    public byte[] curriculo;
    @Column(length = 800)
    public byte[] foto;

    /*@Transient
    public String caminhoCurriculo;
    @Transient
    public String caminhoFoto;*/


    //------------------------------ GETTER E SETTER --------------------------------------

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public String getMatricula() {
        return matricula;
    }

    public void setMatricula(String matricula) {
        this.matricula = matricula;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getNascimento() {
        return nascimento;
    }

    public void setNascimento(String nascimento) {
        this.nascimento = nascimento;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getTelefone() {
        return telefone;
    }

    public void setTelefone(String telefone) {
        this.telefone = telefone;
    }

    public String getEspecialidade() {
        return especialidade;
    }

    public void setEspecialidade(String especialidade) {
        this.especialidade = especialidade;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public String getRua() {
        return rua;
    }

    public void setRua(String rua) {
        this.rua = rua;
    }

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public String getBairro() {
        return bairro;
    }

    public void setBairro(String bairro) {
        this.bairro = bairro;
    }

    public String getComplemento() {
        return complemento;
    }

    public void setComplemento(String complemento) {
        this.complemento = complemento;
    }

    public String getCidade() {
        return cidade;
    }

    public void setCidade(String cidade) {
        this.cidade = cidade;
    }

    public String getEstado() {
        return estado;
    }

    public void setEstado(String estado) {
        this.estado = estado;
    }

    public String getCep() {
        return cep;
    }

    public void setCep(String cep) {
        this.cep = cep;
    }

    public String getStatus() {
        return status;
    }

    public void setStatus(String status) {
        this.status = status;
    }

    public int getAno() {
        return ano;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }

    public String getEscola() {
        return escola;
    }

    public void setEscola(String escola) {
        this.escola = escola;
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        this.senha = senha;
    }

    public byte[] getCurriculo() {
        return curriculo;
    }

    public void setCurriculo(byte[] curriculo) {
        this.curriculo = curriculo;
    }

    public byte[] getFoto() {
        return foto;
    }

    public void setFoto(byte[] foto) {
        this.foto = foto;
    }

    /*public String getCaminhoCurriculo() {
        return caminhoCurriculo;
    }

    public void setCaminhoCurriculo(String caminhoCurriculo) {
        this.caminhoCurriculo = caminhoCurriculo;
    }

    public String getCaminhoFoto() {
        return caminhoFoto;
    }

    public void setCaminhoFoto(String caminhoFoto) {
        this.caminhoFoto = caminhoFoto;
    }*/

    public int getIdAluno() {
        return idAluno;
    }

    public void setIdAluno(int idAluno) {
        this.idAluno = idAluno;
    }
}
