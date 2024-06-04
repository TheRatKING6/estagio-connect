import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'package:login/Aluno.dart';
import 'package:login/Empresa.dart';
import 'package:login/Vagas.dart';
import 'package:login/likeAluno.dart';
import 'package:login/likeEmpresa.dart';
import 'package:login/login.dart';
import 'package:login/matchs.dart';

class CadastroAluno2 extends StatefulWidget {
  CadastroAluno2(this.listaAl, this.listaEm, this.listaVa, this.listaLikeAl, this.listaLikeEm, this.listaMatchs, this.cpf, this.nome, this.matricula, this.data, this.rua, this.bairro, this.numero, this.complemento,
  this.cidade, this.estado, this.email, this.telefone, this.especialidade, this.status, this.senha, {super.key});
  List<Aluno>listaAl = [];
  List<Empresa>listaEm = [];
  List<Vagas> listaVa = [];
  List<LikeAluno> listaLikeAl = [];
  List<LikeEmpresa> listaLikeEm = [];
  List<Matchs> listaMatchs = [];
  String cpf ="";
  String nome = "";
  String matricula="";
  String data = "";
  String rua = "";
  String bairro = "";
  String numero = "";
  String complemento = "";
  String cidade = "";
  String estado = "";
  String email = "";
  String telefone = "";
  String especialidade = "";
  String status = "";
  String senha = "";

  

  @override
  State<CadastroAluno2> createState() => _CadastroAluno2State();
}

class _CadastroAluno2State extends State<CadastroAluno2> {
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  TextEditingController anoController = TextEditingController();
  TextEditingController escolaController = TextEditingController();
  TextEditingController descricaoController = TextEditingController();
  String im = "assets/images/iconPerfil.png";
  String im2 = "assets/images/iconImagem.png";

  
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(backgroundColor: Color.fromARGB(255, 220, 255, 247),),
      backgroundColor: Color.fromARGB(255, 220, 255, 247),
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
              controller: anoController,
              decoration: InputDecoration(
                labelText: "Ano",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
            )),
          ],),),

          SizedBox(height: 15,),

          Container(
          height: 70,
          child: 
          Row(children: [
            Expanded(
              flex: 3,
              child: TextFormField(
              controller: escolaController,
              decoration: InputDecoration(
                labelText: "Escola",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira a Escola';
                          }
                          return null;
                        },
            )),
          ],),),

          SizedBox(height: 15,),

          
          Row(mainAxisAlignment: 
              MainAxisAlignment.spaceEvenly,
              children: [
            Column(children: [Text("Foto",style: TextStyle(fontWeight: FontWeight.bold,fontSize: 20)), Image.asset(im, width: 175,)],
            ),
            SizedBox(width: 40,),
            Column(children: [Text("Currículo",style: TextStyle(fontWeight: FontWeight.bold,fontSize: 20)), Image.asset(im2, width: 175,)]),

          ],),

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
                 Aluno al = new Aluno(
                  widget.cpf, 
                  widget.nome, 
                  widget.matricula, 
                  widget.data, 
                  widget.rua, 
                  widget.bairro, 
                  widget.numero, 
                  widget.complemento, 
                  widget.cidade, 
                  widget.estado, 
                  widget.email, 
                  widget.telefone, 
                  widget.especialidade, 
                  widget.status, 
                  widget.senha, 
                  anoController.text, 
                  escolaController.text, 
                  descricaoController.text+" ");
                  widget.listaAl.add(al);
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









        ],))])))
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
                Navigator.push(context, MaterialPageRoute(builder: (context)=> Login(widget.listaAl, widget.listaEm, widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs)));
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