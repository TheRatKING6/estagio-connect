// ignore_for_file: prefer_const_literals_to_create_immutables, prefer_const_constructors

import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:login/Aluno.dart';
import 'package:login/Empresa.dart';
import 'package:login/Vagas.dart';
import 'package:login/homeEmpresa.dart';
import 'package:login/likeAluno.dart';
import 'package:login/likeEmpresa.dart';
import 'package:login/matchs.dart';

class CriarVagas extends StatefulWidget {
  CriarVagas(this.listaAl, this.listaEm, this.listaVa, this.listaLikeAl, this.listaLikeEm, this.listaMatchs, this.indexL,{super.key});
  List<Aluno> listaAl = [];
  List<Empresa> listaEm = [];
  List<Vagas> listaVa = [];
  List<LikeAluno> listaLikeAl = [];
  List<LikeEmpresa> listaLikeEm = [];
  List<Matchs> listaMatchs = [];
  int indexL = -1;
  

  @override
  State<CriarVagas> createState() => _CriarVagasState();
}

class _CriarVagasState extends State<CriarVagas> {
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  TextEditingController tituloController = TextEditingController();
  TextEditingController descricaoController = TextEditingController();
  TextEditingController salarioController = TextEditingController();
  TextEditingController localizacaoController = TextEditingController();
  TextEditingController requisitosController = TextEditingController();
  TextEditingController beneficiosController= TextEditingController();
  TextEditingController areaController = TextEditingController();
  TextEditingController prazoController = TextEditingController();
  TextEditingController numeroController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      
      appBar: AppBar(backgroundColor: Color.fromARGB(255, 230, 230, 230),),
      backgroundColor: Color.fromARGB(255, 230, 230, 230),
      body: SingleChildScrollView(
        child: Container(
        padding:EdgeInsets.fromLTRB(50, 10, 50, 40),
        alignment: Alignment.center,
        child: Column(children: [
          Form(
            key: _formKey,
            child: Column(children: [

              Container(
          height: 70,
          child: 
          Row(children: [
            Expanded(
              flex: 3,
              child: TextFormField(
              controller: tituloController,
              decoration: InputDecoration(
                labelText: "Título",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o título';
                          } 
                          return null;
                        },
            )),
          ],),),

          SizedBox(height: 7,),

          Container(
          height: 70,
          child: 
          Row(children: [
            Expanded(
              flex: 3,
              child: TextFormField(
              controller: salarioController,
              decoration: InputDecoration(
                labelText: "Salário",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
            )),
          ],),),

          SizedBox(height: 7,),

          Container(
            height: 200,
            child: TextFormField(
            maxLines: null,
            expands: true,
            controller: descricaoController,
            textAlignVertical: TextAlignVertical.top,
            decoration: InputDecoration(
              labelText: "Descrição",
              filled: true,
              fillColor: Colors.white,
              border: OutlineInputBorder(),
              contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),  
            ),
            validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira a Descrição';
                          }
                          return null;
                        }
           ),
          ),

          SizedBox(height: 7,),

          Container(
          height: 70,
          child: 
          Row(children: [
            Expanded(
              flex: 3,
              child: TextFormField(
              controller: localizacaoController,
              decoration: InputDecoration(
                labelText: "Localização",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira a localização';
                          } 
                          return null;
                        },
            )),
          ],),),

          SizedBox(height: 7,),

          Container(
          height: 70,
          child: 
          Row(children: [
            Expanded(
              flex: 3,
              child: TextFormField(
                
              controller: requisitosController,
              decoration: InputDecoration(
                labelText: "Requisitos",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira os Requisitos';
                          } 
                          return null;
                        },
            )),
          ],),),

          SizedBox(height: 7,),

          Container(
          height: 70,
          child: 
          Row(children: [
            Expanded(
              flex: 3,
              child: TextFormField(
                
              controller: beneficiosController,
              decoration: InputDecoration(
                labelText: "Benefícios",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
            )),
          ],),),

          SizedBox(height: 7,),

          Container(
          height: 70,
          child: 
          Row(children: [
            Expanded(
              flex: 3,
              child: TextFormField(
                
              controller: areaController,
              decoration: InputDecoration(
                labelText: "Área de especialidade do Aluno",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira qual a área';
                          } 
                          return null;
                        },
            )),
          ],),),

          SizedBox(height: 7,),

          Container(
          height: 70,
          child: 
          Row(children: [
            Expanded(
              flex: 3,
              child: TextFormField(
                
              controller: prazoController,
              decoration: InputDecoration(
                labelText: "Prazo para Aplicação",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Prazo';
                          } 
                          return null;
                        },
            )),
          ],),),

          SizedBox(height: 7,),

          Container(
          height: 70,
          child: 
          Row(children: [
            Expanded(
              flex: 3,
              child: TextFormField(
                
              controller: numeroController,
              decoration: InputDecoration(
                labelText: "Número de Vagas",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Número de Vagas';
                          } 
                          return null;
                        },
            )),
          ],),),

          SizedBox(height: 20,),

        Container(
            
            width: 500,
            height: 50,
            child: ElevatedButton(
              onPressed: () {
                if (_formKey.currentState!.validate()) {
                  Vagas va = new Vagas(
                    DateTime.now().millisecondsSinceEpoch.toString(),
                    widget.listaEm[widget.indexL].CNPJ,
                    tituloController.text,
                    descricaoController.text,
                    salarioController.text,
                    localizacaoController.text,
                    requisitosController.text,
                    beneficiosController.text,
                    areaController.text,
                    prazoController.text,
                    numeroController.text,
                  );
                  widget.listaVa.add(va);
                  Navigator.push(context, MaterialPageRoute(builder: (context)=> HomeEmpresa(widget.listaAl, widget.listaEm, widget.listaVa,widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs, widget.indexL)));

                }
                setState(() {

                });
              }, 
              style: ElevatedButton.styleFrom(
                shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.zero,
                ),
                backgroundColor: Color.fromARGB(255, 2, 146, 191)
              ),
              child: Text("Criar Vaga", style: TextStyle(color: Colors.white)),
            ),
          ),
























              
            ]))])))

    );
  }
}