package com.example.demo.controller;

import com.example.demo.model.Empresa;
import com.example.demo.repository.EmpresaRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@CrossOrigin
@RestController
@RequestMapping("/apiEmpresa")
public class EmpresaController {

    @Autowired
    EmpresaRepository emRep;

    @GetMapping("/todas")
    public List<Empresa> getTodasEmpresas(){
        return emRep.findAll();
    }

    @PostMapping("/cadastrarEmpresa")
    public void cadastrarEmpresa(@RequestBody Empresa emp){
        emRep.save(emp);
    }

    @DeleteMapping("/apagar/idEmpresa/{idEmpresa}")
    public void deleteEmpresa(@PathVariable("idEmpresa") int idEmpresa){
        emRep.deleteInteressesEmpresa(idEmpresa);
        emRep.deleteVagasEmpresa(idEmpresa);
        emRep.deleteEmpresa(idEmpresa);
    }
}
