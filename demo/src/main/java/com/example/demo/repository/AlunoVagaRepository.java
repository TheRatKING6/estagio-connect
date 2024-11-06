package com.example.demo.repository;

import com.example.demo.model.AlunoVaga;
import jakarta.transaction.Transactional;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;

public interface AlunoVagaRepository extends JpaRepository<AlunoVaga, Integer> {
    @Transactional
    @Modifying
    @Query("delete from AlunoVaga where idAluno_Vaga = :id")
    void deleteInteresseAluno(int id);
}
