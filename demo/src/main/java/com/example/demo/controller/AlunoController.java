package com.example.demo.controller;

import com.example.demo.model.Aluno;
import com.example.demo.repository.AlunoRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@CrossOrigin
@RestController
@RequestMapping("/apiAluno")
public class AlunoController {

    @Autowired
    AlunoRepository alRep;

    @GetMapping("/todos")
    public List<Aluno> getTodosAlunos(){
        return alRep.findAll();
    }

    //cadastrar aluno
    @PostMapping("/cadastrarAluno")
    public void cadastrarAluno(@RequestBody Aluno al){
        alRep.save(al);
    }

    @DeleteMapping("/apagar/idAluno/{idAluno}")
    public void deleteAluno(@PathVariable("idAluno") int idAluno){
        alRep.deleteInteressesAluno(idAluno);
        alRep.deleteVagasInteressadas(idAluno);
        alRep.deleteAluno(idAluno);
    }

}
