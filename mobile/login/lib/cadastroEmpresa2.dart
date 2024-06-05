// ignore_for_file: prefer_const_constructors

import 'package:flutter/material.dart';
import 'package:login/Aluno.dart';
import 'package:login/Empresa.dart';
import 'package:login/Vagas.dart';
import 'package:login/likeAluno.dart';
import 'package:login/likeEmpresa.dart';
import 'package:login/login.dart';
import 'package:login/matchs.dart';

class CadastroEmpresa2 extends StatefulWidget {
  CadastroEmpresa2(this.listaAl, this.listaEm, this.listaVa, this.listaLikeAl, this.listaLikeEm, this.listaMatchs, this.cnpj, this.nome, this.rua, this.bairro, this.numero, this.complemento, this.cidade,
  this.estado, this.email, this.telefone, this.ramo, this.senha,{super.key});
  List<Aluno>listaAl = [];
  List<Empresa>listaEm = [];
  List<Vagas> listaVa = [];
  List<LikeAluno> listaLikeAl = [];
  List<LikeEmpresa> listaLikeEm = [];
  List<Matchs> listaMatchs = [];
  String cnpj ="";
  String nome = "";
  String rua = "";
  String bairro = "";
  String numero = "";
  String complemento = "";
  String cidade = "";
  String estado = "";
  String email = "";
  String telefone = "";
  String ramo = "";
  String senha = "";

  @override
  State<CadastroEmpresa2> createState() => _CadastroEmpresa2State();
}

class _CadastroEmpresa2State extends State<CadastroEmpresa2> {
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  TextEditingController descricaoController = TextEditingController();
  String im = "assets/images/iconPerfil.png";
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar( backgroundColor: Color.fromARGB(255, 220, 255, 247),),
      backgroundColor: Color.fromARGB(255, 220, 255, 247),
      body: SingleChildScrollView(
        child: Container(
        padding:EdgeInsets.fromLTRB(50, 10, 50, 40),
        alignment: Alignment.center,
        child: Column(children: [

        Form(
          key: _formKey,
          child: Column(children: [

         

         Text("Foto",style: TextStyle(fontWeight: FontWeight.bold,fontSize: 20)),
         SizedBox(height: 20,),
         Image.asset(im, width: 200,),
         
         SizedBox(height: 60,),
         
         Row(children: [
          Text("Descrição: ", style: TextStyle(fontWeight: FontWeight.bold)),
          SizedBox(width: 60,)
          ],),

        Container(
            height: 200,
            child: TextFormField(
            maxLines: null,
            expands: true,
            controller: descricaoController,
            textAlignVertical: TextAlignVertical.top,
            decoration: InputDecoration(
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

          SizedBox(height: 40,),

          Container(
            width: 500,
            height: 50,
            child: ElevatedButton(
              onPressed: () {
                if (_formKey.currentState!.validate()) {
                  Empresa em = new Empresa(
                  widget.cnpj, 
                  widget.nome, 
                  widget.rua, 
                  widget.bairro, 
                  widget.numero, 
                  widget.complemento, 
                  widget.cidade, 
                  widget.estado, 
                  widget.email, 
                  widget.telefone, 
                  widget.ramo, 
                  widget.senha, 
                  descricaoController.text);
                  widget.listaEm.add(em);
                _showDialog();
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
              child: Text("Cadastrar", style: TextStyle(color: Colors.white)),
            ),
          ),



         ],),
        )

        ])))
    );
  }
   void _showDialog() {
    showDialog(
      barrierDismissible: false,
      context: context,
      builder: (BuildContext context) {
        
        return AlertDialog(
          title: new Text("Cadastro realizado com sucesso!",textAlign: TextAlign.center),
          actions: <Widget>[
            
            Center(child: 
            Container(padding: EdgeInsets.fromLTRB(10, 0, 10, 0),
            alignment: Alignment.center,
            child: new ElevatedButton(
              child: new Text("Voltar para o Login"),
              onPressed: () {
                Navigator.push(context, MaterialPageRoute(builder: (context)=> Login(widget.listaAl, widget.listaEm,widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs)));
              },
            ),
            ), 
            )
          ],
        );
      },
    );
}
}