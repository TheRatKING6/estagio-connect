package com.example.demo.repository;

import com.example.demo.model.VagaAluno;
import jakarta.transaction.Transactional;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;

public interface VagaAlunoRepository extends JpaRepository<VagaAluno, Integer> {
    @Transactional
    @Modifying
    @Query("delete from VagaAluno where idVaga_Aluno = :id")
    void deleteInteresseVaga(int id);
}
