package com.example.demo.controller;

import com.example.demo.model.AlunoVaga;
import com.example.demo.repository.AlunoVagaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@CrossOrigin
@RestController
@RequestMapping("/apiAlunoVaga")
public class AlunoVagaController {
    @Autowired
    AlunoVagaRepository alvaRep;

    @GetMapping("/todos")
    public List<AlunoVaga> getTodosAlunoVaga(){
        return alvaRep.findAll();
    }

    @PostMapping("/cadastrar")
    public void cadastraInteresseAluno(@RequestBody AlunoVaga alunoVaga){
        alvaRep.save(alunoVaga);
    }

    @DeleteMapping("/deleteInteresse/idAlunoVaga/{idAluno_Vaga}")
    public void deleteInteresseAluno(@PathVariable("idAluno_Vaga") int id){
        alvaRep.deleteInteresseAluno(id);
    }
}
