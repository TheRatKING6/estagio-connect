import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:login/Aluno.dart';
import 'package:login/Empresa.dart';
import 'package:login/Vagas.dart';
import 'package:login/cadastroAluno2.dart';
import 'package:login/likeAluno.dart';
import 'package:login/likeEmpresa.dart';
import 'package:login/matchs.dart';

class CadastroAluno extends StatefulWidget {
  CadastroAluno(this.listaAl,this.listaEm, this.listaVa, this.listaLikeAl, this.listaLikeEm, this.listaMatchs,{super.key});

  List<Aluno> listaAl = [];
  List<Empresa> listaEm = [];
  List<Vagas> listaVa = [];
  List<LikeAluno> listaLikeAl = [];
  List<LikeEmpresa> listaLikeEm = [];
  List<Matchs> listaMatchs = [];

  @override
  State<CadastroAluno> createState() => _CadastroAlunoState();
}

class _CadastroAlunoState extends State<CadastroAluno> {

  void initState(){
    super.initState();
  }

  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();

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
                keyboardType: TextInputType.number,
                inputFormatters: <TextInputFormatter>[
                FilteringTextInputFormatter.digitsOnly
                ],
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
                          } else if (confereCpf()) {
                          return 'CPF já cadastrado';
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
                 keyboardType: TextInputType.number,
                inputFormatters: <TextInputFormatter>[
                FilteringTextInputFormatter.digitsOnly
                ],
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
                labelText: "Status de Ensino",
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

          SizedBox(height: 20,),

          Container(
            
            width: 500,
            height: 50,
            child: ElevatedButton(
              onPressed: () {
                if (_formKey.currentState!.validate()) {
                Navigator.push(context, MaterialPageRoute(builder: (context)=> CadastroAluno2(
                  widget.listaAl,
                  widget.listaEm,
                  widget.listaVa,
                  widget.listaLikeAl,
                  widget.listaLikeEm,
                  widget.listaMatchs,
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

                )));
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
              child: Text("Prosseguir", style: TextStyle(color: Colors.white)),
            ),
          ),
      ],))])))
      
    );
  }
  bool confereCpf()
  {
    for(int i = 0; i < widget.listaAl.length; i++){
      if(widget.listaAl[i].CPF == cpfController.text){
        return true;
      }
    }
    return false;
    
  }
}