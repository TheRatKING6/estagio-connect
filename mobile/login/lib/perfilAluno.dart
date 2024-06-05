
import 'package:flutter/material.dart';
import 'package:login/Aluno.dart';
import 'package:login/Empresa.dart';
import 'package:login/Vagas.dart';
import 'package:login/configuracaoAluno.dart';
import 'package:login/likeAluno.dart';
import 'package:login/likeEmpresa.dart';
import 'package:login/matchs.dart';

class PerfilAluno extends StatefulWidget {
  PerfilAluno(this.listaAl, this.listaEm, this.listaVa, this.listaLikeAl, this.listaLikeEm, this.listaMatchs, this.indexL,{Key? key});

  List<Aluno> listaAl = [];
  List<Empresa> listaEm = [];
  List<Vagas> listaVa = [];
  List<LikeAluno> listaLikeAl = [];
  List<LikeEmpresa> listaLikeEm = [];
  List<Matchs> listaMatchs = [];
  int indexL = -1;
  

  @override
  State<PerfilAluno> createState() => _PerfilAlunoState();
}

class _PerfilAlunoState extends State<PerfilAluno> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      backgroundColor: Color.fromARGB(255, 220, 255, 247),
      appBar: AppBar(
        backgroundColor: Color.fromARGB(255, 220, 255, 247),
        actions: [
          Padding(
            padding: const EdgeInsets.fromLTRB(0, 0, 25, 0),
            child: IconButton(
            icon: Icon(Icons.settings), 
            onPressed: () {
            Navigator.push(context, MaterialPageRoute(builder: (context)=> ConfiguracaoAluno(widget.listaAl,widget.listaEm,widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs, widget.indexL)));
          },
        ),
          ),
        ],
        
      ),
      body: SingleChildScrollView(
        child: Container(
          padding: EdgeInsets.fromLTRB(50, 0, 50, 40),
          alignment: Alignment.center,
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
             Row(children: [
              Image.asset("assets/images/iconPerfil.png", width: 150,),
              SizedBox(width: 40,),
              Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                Text(widget.listaAl[widget.indexL].nome, style: TextStyle(fontWeight: FontWeight.bold, fontSize: 20),),
                SizedBox(height: 12,),
                Text(widget.listaAl[widget.indexL].ano, style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),),
                Text(widget.listaAl[widget.indexL].cidade + " - " + widget.listaAl[widget.indexL].estado, style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),),
                ],)
             ],),
            SizedBox(height: 12,),
            Text("Nome:", style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),),
            SizedBox(height: 7,),
            Container(  
            height: 40,
            child:  TextField(
              controller: TextEditingController(text: widget.listaAl[widget.indexL].nome),
              enabled: false,
              decoration: InputDecoration(
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
            ),
           ),

          SizedBox(height: 12,),
            Text("Endereço:", style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),),
            SizedBox(height: 7,),
            Container(  
            height: 40,
            child:  TextField(
              controller: TextEditingController(text: widget.listaAl[widget.indexL].rua),
              enabled: false,
              decoration: InputDecoration(
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
            ),
           ),

           SizedBox(height: 12,),
            Text("Email de contato:", style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),),
            SizedBox(height: 7,),
            Container(  
            height: 40,
            child:  TextField(
              controller: TextEditingController(text: widget.listaAl[widget.indexL].email),
              enabled: false,
              decoration: InputDecoration(
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
            ),
           ),

           SizedBox(height: 12,),
            Text("Telefone de contato:", style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),),
            SizedBox(height: 7,),
            Container(  
            height: 40,
            child:  TextField(
              controller: TextEditingController(text: widget.listaAl[widget.indexL].telefone),
              enabled: false,
              decoration: InputDecoration(
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
            ),
           ),

           SizedBox(height: 12,),
            Text("Área de Especialidade:", style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),),
            SizedBox(height: 7,),
            Container(  
            height: 40,
            child:  TextField(
              controller: TextEditingController(text: widget.listaAl[widget.indexL].especialidade),
              enabled: false,
              decoration: InputDecoration(
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
            ),
           ),

           SizedBox(height: 12,),
            Text("Status:", style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),),
            SizedBox(height: 7,),
            Container(  
            height: 40,
            child:  TextField(
              controller: TextEditingController(text: widget.listaAl[widget.indexL].status),
              enabled: false,
              decoration: InputDecoration(
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
            ),
           ),
          
          SizedBox(height: 12,),
            Text("Descrição:", style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),),
            SizedBox(height: 7,),
           Container(
            height: 200,
            child: TextField(
            enabled: false,
            maxLines: null,
            expands: true,
            controller: TextEditingController(text: widget.listaAl[widget.indexL].descricao),
            textAlignVertical: TextAlignVertical.top,
            decoration: InputDecoration(
              filled: true,
              fillColor: Colors.white,
              border: OutlineInputBorder(),
              contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),  
            ),
           ),
          ),

          SizedBox(height: 12,),
            Text("Currículo:", style: TextStyle(fontWeight: FontWeight.bold, fontSize: 15),),
            SizedBox(height: 7,),
            Image.asset('assets/images/iconImagem.png', width: 150,)




            ],
          ),
        ),
      ),
    );
  }
}