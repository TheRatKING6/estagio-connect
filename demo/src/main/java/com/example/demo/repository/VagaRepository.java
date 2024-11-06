package com.example.demo.repository;

import com.example.demo.model.Vaga;
import jakarta.transaction.Transactional;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;

public interface VagaRepository extends JpaRepository<Vaga, Integer> {
    @Transactional
    @Modifying
    @Query("delete from AlunoVaga where codigo_Vaga = :id")
    void deleteAlunoVaga(int id);
    @Transactional
    @Modifying
    @Query("delete from VagaAluno where codigo_Vaga = :id")
    void deleteVagaAluno(int id);
    @Transactional
    @Modifying
    @Query("delete from Vaga where Codigo = :id")
    void deleteVaga(int id);
}
