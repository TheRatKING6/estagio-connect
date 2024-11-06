package com.example.demo.repository;

import com.example.demo.model.AlunoVaga;
import com.example.demo.model.Empresa;
import com.example.demo.model.Vaga;
import com.example.demo.model.VagaAluno;
import jakarta.transaction.Transactional;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;

public interface EmpresaRepository extends JpaRepository<Empresa, Integer> {
    /*@Query(
        value = "delete Connect_Aluno_Vaga, Connect_Vaga_Aluno from Connect_Vagas " +
        "inner join Connect_Aluno_Vaga inner join Connect_Vaga_Aluno " +
        "where Connect_Vagas.Codigo = Connect_Aluno_Vaga.Codigo_Vaga and Connect_Vagas.Codigo = Connect_Vaga_Aluno.Codigo_Vaga " +
        "and Connect_Vagas.id_empresa = ?1 ;" +
        "delete from Connect_Vagas where id_empresa = ?1;" +
        "delete from connect_empresa where id_empresa = ?1",
        nativeQuery = true
    )*/

    @Transactional
    @Modifying
    @Query(value = "DELETE av, va " +
            "FROM connect_aluno_vaga av " +
            "INNER JOIN connect_vaga_aluno va ON av.codigo_vaga = va.codigo_vaga " +
            "INNER JOIN connect_vagas v ON v.codigo = av.codigo_vaga " +
            "WHERE v.id_empresa = :idEmpresa",
            nativeQuery = true)
    void deleteInteressesEmpresa(int idEmpresa);

    @Transactional
    @Modifying
    @Query("delete from Vaga where id_empresa = :idEmpresa")
    void deleteVagasEmpresa(int idEmpresa);

    @Transactional
    @Modifying
    @Query("delete from Empresa where idEmpresa = :idEmpresa")
    void deleteEmpresa(int idEmpresa);
}
