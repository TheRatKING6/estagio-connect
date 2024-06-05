import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter/widgets.dart';
import 'package:login/Aluno.dart';
import 'package:login/Empresa.dart';
import 'package:login/Vagas.dart';
import 'package:login/homeEmpresa.dart';
import 'package:login/likeAluno.dart';
import 'package:login/likeEmpresa.dart';
import 'package:login/matchs.dart';

class ConfiguracaoEmpresa extends StatefulWidget {
  ConfiguracaoEmpresa(this.listaAl,this.listaEm, this.listaVa, this.listaLikeAl, this.listaLikeEm, this.listaMatchs, this.indexL,{super.key});

  List<Aluno> listaAl = [];
  List<Empresa> listaEm = [];
  List<Vagas> listaVa = [];
  List<LikeAluno> listaLikeAl = [];
  List<LikeEmpresa> listaLikeEm = [];
  List<Matchs> listaMatchs = [];
  int indexL = -1;

  @override
  State<ConfiguracaoEmpresa> createState() => _ConfiguracaoEmpresaState();
}

class _ConfiguracaoEmpresaState extends State<ConfiguracaoEmpresa> {

  void initState() {
    super.initState();
    
    cnpjController.text = widget.listaEm[widget.indexL].CNPJ;
    nomeController.text = widget.listaEm[widget.indexL].nome;
    ruaController.text = widget.listaEm[widget.indexL].rua;
    bairroController.text = widget.listaEm[widget.indexL].bairro;
    numeroController.text = widget.listaEm[widget.indexL].numero;
    complementoController.text = widget.listaEm[widget.indexL].complemento;
    cidadeController.text = widget.listaEm[widget.indexL].cidade;
    estadoController.text = widget.listaEm[widget.indexL].estado;
    emailController.text = widget.listaEm[widget.indexL].email;
    telefoneController.text = widget.listaEm[widget.indexL].telefone;
    ramoController.text = widget.listaEm[widget.indexL].ramo;
    senhaController.text = widget.listaEm[widget.indexL].senha;
    confirmeSenhaController.text = widget.listaEm[widget.indexL].senha;
    descricaoController.text = widget.listaEm[widget.indexL].descricao;
  }
 
  TextEditingController descricaoController = TextEditingController();
  String im = "assets/images/iconPerfil.png";
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  TextEditingController cnpjController = TextEditingController();
  TextEditingController nomeController = TextEditingController();
  TextEditingController ruaController = TextEditingController();
  TextEditingController bairroController = TextEditingController();
  TextEditingController numeroController = TextEditingController();
  TextEditingController complementoController = TextEditingController();
  TextEditingController cidadeController = TextEditingController();
  TextEditingController estadoController = TextEditingController();
  TextEditingController emailController = TextEditingController();
  TextEditingController telefoneController = TextEditingController();
  TextEditingController ramoController = TextEditingController();
  TextEditingController senhaController = TextEditingController();
  TextEditingController confirmeSenhaController = TextEditingController();
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar( backgroundColor: Color.fromARGB(255, 230, 230, 230),),
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
                keyboardType: TextInputType.number,
                inputFormatters: <TextInputFormatter>[
                FilteringTextInputFormatter.digitsOnly
                ],
              controller: cnpjController,
              decoration: InputDecoration(
                labelText: "CNPJ",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o CNPJ';
                          } else if (cnpjController.text.length != 14){
                            return 'CNPJ inválido';
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
                labelText: "Nome da Empresa",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Nome da Empresa';
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
              keyboardType: TextInputType.number,
                inputFormatters: <TextInputFormatter>[
                FilteringTextInputFormatter.digitsOnly
                ],
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
                keyboardType: TextInputType.number,
                inputFormatters: <TextInputFormatter>[
                FilteringTextInputFormatter.digitsOnly
                ],
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
              controller: ramoController,
              decoration: InputDecoration(
                labelText: "Ramo de Atividade",
                filled: true,
                fillColor: Colors.white,
                border: OutlineInputBorder(),
                contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
              ),
              validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o Ramo de Atividade';
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
                            return 'Confirme a senha';
                          } else if (senhaController.text != confirmeSenhaController.text){
                            return 'As senhas não coincidem';
                          }
                          return null;
                        },
            )),
          ],),), 

        SizedBox(height: 20,),

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
                  cnpjController.text, 
                  nomeController.text,  
                  ruaController.text, 
                  bairroController.text, 
                  numeroController.text, 
                  complementoController.text, 
                  cidadeController.text, 
                  estadoController.text, 
                  emailController.text, 
                  telefoneController.text, 
                  ramoController.text,  
                  senhaController.text, 
                  descricaoController.text);
                  widget.listaEm[widget.indexL] = em;
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









        ],))])))
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
                Navigator.push(context, MaterialPageRoute(builder: (context)=> HomeEmpresa(widget.listaAl, widget.listaEm, widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs, widget.indexL)));
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