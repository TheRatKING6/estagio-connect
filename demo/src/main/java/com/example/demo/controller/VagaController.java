package com.example.demo.controller;

import com.example.demo.model.Vaga;
import com.example.demo.repository.VagaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@CrossOrigin
@RestController
@RequestMapping("/apiVagas")
public class VagaController {
    @Autowired
    VagaRepository vaRep;

    @GetMapping("/todas")
    public List<Vaga> getTodasVagas(){
        return vaRep.findAll();
    }

    @PostMapping("/cadastrarVaga")
    public void cadastrarVaga(@RequestBody Vaga vaga){
        vaRep.save(vaga);
    }

    @DeleteMapping("/excluirVaga/idVaga/{idVaga}")
    public void excluirVaga(@PathVariable("idVaga") int id){
        vaRep.deleteAlunoVaga(id);
        vaRep.deleteVagaAluno(id);
        vaRep.deleteVaga(id);
    }
}
