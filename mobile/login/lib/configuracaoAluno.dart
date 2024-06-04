import 'package:flutter/material.dart';
import 'package:login/Aluno.dart';
import 'package:login/Empresa.dart';
import 'package:login/Vagas.dart';
import 'package:login/homeAluno.dart';
import 'package:login/likeAluno.dart';
import 'package:login/likeEmpresa.dart';
import 'package:login/login.dart';
import 'package:login/matchs.dart';

class ConfiguracaoAluno extends StatefulWidget {
  ConfiguracaoAluno(this.listaAl, this.listaEm, this.listaVa, this.listaLikeAl, this.listaLikeEm, this.listaMatchs, this.indexL,{super.key});
  List<Aluno> listaAl = [];
  List<Empresa> listaEm = [];
  List<Vagas> listaVa = [];
  List<LikeAluno> listaLikeAl = [];
  List<LikeEmpresa> listaLikeEm = [];
  List<Matchs> listaMatchs = [];
  int indexL = -1;

  @override
  State<ConfiguracaoAluno> createState() => _ConfiguracaoAlunoState();
}

class _ConfiguracaoAlunoState extends State<ConfiguracaoAluno> {

  void initState() {
    super.initState();
    
    cpfController.text = widget.listaAl[widget.indexL].CPF;
    nomeController.text = widget.listaAl[widget.indexL].nome;
    matriculaController.text = widget.listaAl[widget.indexL].matricula;
    dataController.text = widget.listaAl[widget.indexL].data;
    ruaController.text = widget.listaAl[widget.indexL].rua;
    bairroController.text = widget.listaAl[widget.indexL].bairro;
    numeroController.text = widget.listaAl[widget.indexL].numero;
    complementoController.text = widget.listaAl[widget.indexL].complemento;
    cidadeController.text = widget.listaAl[widget.indexL].cidade;
    estadoController.text = widget.listaAl[widget.indexL].estado;
    emailController.text = widget.listaAl[widget.indexL].email;
    telefoneController.text = widget.listaAl[widget.indexL].telefone;
    especialidadeController.text = widget.listaAl[widget.indexL].especialidade;
    statusController.text = widget.listaAl[widget.indexL].status;
    senhaController.text = widget.listaAl[widget.indexL].senha;
    confirmeSenhaController.text = widget.listaAl[widget.indexL].senha;
    anoController.text = widget.listaAl[widget.indexL].ano;
    escolaController.text = widget.listaAl[widget.indexL].escola;
    descricaoController.text = widget.listaAl[widget.indexL].descricao;
  }

  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();

  String im = "assets/images/iconPerfil.png";
  String im2 = "assets/images/iconImagem.png";
  TextEditingController cpfController = TextEditingController();
  TextEditingController nomeController = TextEditingController();
  TextEditingController matriculaController = TextEditingController();
  TextEditingController dataController = TextEditingController();
  TextEditingController ruaController = TextEditingController();
  TextEditingController bairroController = TextEditingController();
  TextEditingController numeroController = TextEditingController();
  TextEditingController complementoController = TextEditingController();
  TextEditingController cidadeController = TextEditingController();
  TextEditingController estadoController = TextEditingController();
  TextEditingController emailController = TextEditingController();
  TextEditingController telefoneController = TextEditingController();
  TextEditingController especialidadeController = TextEditingController();
  TextEditingController statusController = TextEditingController();
  TextEditingController senhaController = TextEditingController();
  TextEditingController confirmeSenhaController = TextEditingController();
  TextEditingController anoController = TextEditingController();
  TextEditingController escolaController = TextEditingController();
  TextEditingController descricaoController = TextEditingController();
  
  

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
              controller: cpfController,
              decoration: InputDecoration(
                labelText: "CPF",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
                validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o CPF';
                          } else if (cpfController.text.length != 11){
                            return 'CPF inválido';
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
              controller: nomeController,
              decoration: InputDecoration(
                labelText: "Nome Completo",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
                validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Nome Completo';
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
              controller: matriculaController,
              decoration: InputDecoration(
                labelText: "Número de Matrícula",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Número de Matrícula';
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
              controller: dataController,
              decoration: InputDecoration(
                labelText: "Data de Nascimento",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira a Data de Nascimento';
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
              controller: ruaController,
              decoration: InputDecoration(
                labelText: "Rua",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira a Rua';
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
              controller: bairroController,
              decoration: InputDecoration(
                labelText: "Bairro",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Bairro';
                          } 
                          return null;
                        },
            )),

            SizedBox(width: 15,),
           
            Expanded(child: TextFormField(
              controller: numeroController,
              decoration: InputDecoration(
                labelText: "Número",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Número';
                          } 
                          return null;
                        },
              ))
          ],),),
        
        SizedBox(height: 7,),

        Container(
          height: 70,
          child: 
          Row(children: [
            Expanded(
              flex: 3,
              child: TextFormField(
              controller: complementoController,
              decoration: InputDecoration(
                labelText: "Complemento",
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
              controller: cidadeController,
              decoration: InputDecoration(
                labelText: "Cidade",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira a Cidade';
                          } 
                          return null;
                        },
            )),

             SizedBox(width: 15,),
           
            Expanded(child: TextFormField(
              controller: estadoController,
              decoration: InputDecoration(
                labelText: "Estado",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Estado';
                          } 
                          return null;
                        },
              ))
          ],),), 

          SizedBox(height: 7,),

          Container(
          height: 70,
          child: 
          Row(children: [
            Expanded(
              flex: 3,
              child: TextFormField(
              controller: emailController,
              decoration: InputDecoration(
                labelText: "Email de Contato",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Email de Contato';
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
              controller: telefoneController,
              decoration: InputDecoration(
                labelText: "Telefone de Contato",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Telefone de Contato';
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
              controller: especialidadeController,
              decoration: InputDecoration(
                labelText: "Área de Especialidade",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira a Área de Especialidade';
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
              controller: statusController,
              decoration: InputDecoration(
                labelText: "Status",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Status';
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
              controller: senhaController,
              decoration: InputDecoration(
                labelText: "Senha",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
               obscureText: true,
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira a Senha';
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
              controller: confirmeSenhaController,
              decoration: InputDecoration(
                labelText: "Confirme sua senha",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              obscureText: true,
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, confirme sua senha';
                          } else if (senhaController.text != confirmeSenhaController.text){
                            return 'As senhas não coincidem';
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

          SizedBox(height: 7,),

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
                            return 'Por favor, insira sua Escola';
                          } 
                          return null;
                        },
            )),
          ],),),

          SizedBox(height: 20,),


          
          Row(mainAxisAlignment: 
              MainAxisAlignment.spaceEvenly,
              children: [
            Column(children: [Text("Foto",style: TextStyle(fontWeight: FontWeight.bold,fontSize: 20)), Image.asset(im, width: 175,)],
            ),
            SizedBox(width: 40,),
            Column(children: [Text("Currículo",style: TextStyle(fontWeight: FontWeight.bold,fontSize: 20)), Image.asset(im2, width: 175,)]),

          ],),

          SizedBox(height: 20,),
         
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
                        },
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
                  cpfController.text, 
                  nomeController.text, 
                  matriculaController.text, 
                  dataController.text, 
                  ruaController.text, 
                  bairroController.text, 
                  numeroController.text, 
                  complementoController.text, 
                  cidadeController.text, 
                  estadoController.text, 
                  emailController.text, 
                  telefoneController.text, 
                  especialidadeController.text, 
                  statusController.text, 
                  senhaController.text, 
                  anoController.text, 
                  escolaController.text, 
                  descricaoController.text+" ");
                  widget.listaAl[widget.indexL] = al;
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
              child: Text("Atualizar", style: TextStyle(color: Colors.white)),
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
          title: new Text("Atualizado com sucesso!",textAlign: TextAlign.center),
          actions: <Widget>[
            
            Center(child: 
            Container(padding: EdgeInsets.fromLTRB(10, 0, 10, 0),
            alignment: Alignment.center,
            child: new ElevatedButton(
              child: new Text("Voltar para a home"),
              onPressed: () {
                Navigator.push(context, MaterialPageRoute(builder: (context)=> HomeAluno(widget.listaAl, widget.listaEm,widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs, widget.indexL)));
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