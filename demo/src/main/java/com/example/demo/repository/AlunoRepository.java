package com.example.demo.repository;

import com.example.demo.model.Aluno;
import jakarta.transaction.Transactional;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;

public interface AlunoRepository extends JpaRepository<Aluno, Integer> {
    @Transactional
    @Modifying
    @Query("delete from AlunoVaga where idAluno = :idAluno")
    void deleteInteressesAluno(int idAluno);

    @Transactional
    @Modifying
    @Query("delete from VagaAluno where idAluno = :idAluno")
    void deleteVagasInteressadas(int idAluno);

    @Transactional
    @Modifying
    @Query("delete from Aluno where idAluno = :idAluno")
    void deleteAluno(int idAluno);
}
