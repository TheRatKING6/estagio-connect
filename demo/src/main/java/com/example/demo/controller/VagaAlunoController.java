package com.example.demo.controller;

import com.example.demo.model.VagaAluno;
import com.example.demo.repository.VagaAlunoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@CrossOrigin
@RestController
@RequestMapping("/apiVagaAluno")
public class VagaAlunoController {
    @Autowired
    VagaAlunoRepository vaalRep;

    @GetMapping("/todos")
    public List<VagaAluno> getTodosVagaAluno(){
        return vaalRep.findAll();
    }

    @PostMapping("/cadastrar")
    public void cadastraInteresseVaga(@RequestBody VagaAluno vagaAluno){
        vaalRep.save(vagaAluno);
    }

    @DeleteMapping("/deleteInteresse/idVagaAluno/{idVaga_Aluno}")
    public void deleteInteresseVaga(@PathVariable("idVaga_Aluno") int id){
        vaalRep.deleteInteresseVaga(id);
    }
}
