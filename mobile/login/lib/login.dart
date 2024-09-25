import 'dart:html';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:flutter/widgets.dart';
import 'package:login/Aluno.dart';
import 'package:login/Empresa.dart';
import 'package:login/Vagas.dart';
import 'package:login/cadastroAluno.dart';
import 'package:login/cadastroEmpresa.dart';
import 'package:login/homeAluno.dart';
import 'package:login/homeEmpresa.dart';
import 'package:login/likeAluno.dart';
import 'package:login/likeEmpresa.dart';
import 'package:login/matchs.dart';

class Login extends StatefulWidget {
  Login(this.listaAl, this.listaEm, this.listaVa,this.listaLikeAl,this.listaLikeEm,this.listaMatchs,{super.key});
  List<Aluno> listaAl = [];
  List<Empresa> listaEm = [];
  List<Vagas> listaVa = [];
  List<LikeAluno> listaLikeAl = [];
  List<LikeEmpresa> listaLikeEm = [];
  List<Matchs> listaMatchs = []; 
  

  @override
  State<Login> createState() => _LoginState();
}

class _LoginState extends State<Login> {

  Empresa x = new Empresa('12345678912345','ByteWorks', 'Rua das Flores', 'Jardim Alves','123','Casa','Limeira',"SP",'byteworks@gmail.com','199999','Programação','1234','Empresa de softwares');
  Empresa y = new Empresa('12345123456789','NexCode', 'Rua da Amizade', 'Jardim América','143','Casa','Campinas',"SP",'Y@gmail.com','198888','Informática','1234','Empresa de informática');
  Vagas v1 = new Vagas("1",'12345678912345' , "Analista de Sistemas", "Estamos em busca de um Analista de Sistemas talentoso e dedicado para se juntar à nossa equipe. O candidato ideal terá um forte conhecimento em desenvolvimento de software, análise de requisitos e habilidades de resolução de problemas. Você será responsável por analisar, projetar e implementar soluções que atendam às necessidades de nossos clientes internos e externos.", "3000 reais", "home ofice", "html, dart, flutter", "Vale alimentação", "Desenvolvimento de Sistemas", "18/10", "4");
  Vagas v2 = new Vagas("2",'12345123456789' , "Engenheiro de Software", "Estamos procurando um Engenheiro de Software altamente qualificado e motivado para integrar nossa equipe. O candidato ideal será responsável pelo desenvolvimento, teste e implementação de soluções de software de alta qualidade. Trabalhará em estreita colaboração com equipes multifuncionais para criar produtos inovadores que atendam às necessidades dos nossos clientes.", "4000 reais", "na empresa", "html, flutter, java", "Vale alimentação", "Desenvolvimento de Sistemas", "18/10", "4");
  Aluno a = new Aluno("12345678912", "João Silva", "1", "25/04/2007", "Rua do Duque de Caxias", "Jardim Florido", "178", "casa", "Americana", 'SP', "clJoao@gmail.com", "1977777", "Desenvolvimento de Sistemas", "Ensino médio concluído", "1234", "2º", "Cotil", "sei dart, html, php, java, flutter");
  Aluno b = new Aluno("12123456789", "Maria Santos", "2", "28/06/2007", "Rua São José", "Vila Alves", "180", "casa", "Santa Bárbara", 'SP', "clMaria@gmail.com", "1955555", "Desenvolvimento de Sistemas", "Cursando", "1234", "2º", "Cotil", "sei dart, html, php, flutter, java, c++");
  final GlobalKey<FormState> _formKey = GlobalKey<FormState>();

  final TextEditingController cpfController = TextEditingController();
  final TextEditingController senhaController = TextEditingController();
  
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      
      backgroundColor: Color.fromARGB(255, 220, 255, 247),
      body: SingleChildScrollView(
        child: Container(
          padding: EdgeInsets.fromLTRB(50, 60, 50, 40),
          alignment: Alignment.center,
          child: Column(
            children: [
              Divider(thickness: 10, color: Color.fromARGB(255, 168, 221, 237)),
              SizedBox(height: 15),
              Image.asset('assets/images/logo.png', width: 450),
              SizedBox(height: 20),
              Divider(thickness: 10, color: Color.fromARGB(255, 168, 221, 237)),
              SizedBox(height: 15),
              Text("Login", style: TextStyle(fontWeight: FontWeight.bold, fontSize: 25)),
              SizedBox(height: 15),
              Form(
                key: _formKey,
                child: Column(
                  children: [
                    Row(
                      children: [
                        Text("CPF/CNPJ: ", style: TextStyle(fontWeight: FontWeight.bold)),
                      ],
                    ),
                    Container(
                      height: 70, 
                      child: TextFormField(
                        keyboardType: TextInputType.number,
                        inputFormatters: <TextInputFormatter>[
                          FilteringTextInputFormatter.digitsOnly
                        ],
                        controller: cpfController,
                        decoration: InputDecoration(
                          filled: true,
                          fillColor: Colors.white,
                          border: OutlineInputBorder(),
                          contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
                        ),
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira o CPF/CNPJ';
                          } else if (cpfController.text.length != 11 && cpfController.text.length != 14 ){
                            return 'CPF/CNPJ inválido';
                          } else if (cpfController.text.length==11){
                            if (confereCpf()) {
                            return 'CPF não cadastrado';
                          }
                          return null;
                          } else if (confereCnpj()){
                            return 'CNPJ não cadastrado';
                          }
                          
                          
                        },
                      ),
                    ),
                    SizedBox(height: 0),
                    Row(
                      children: [
                        Text("Senha: ", style: TextStyle(fontWeight: FontWeight.bold)),
                      ],
                    ),
                    Container(
                      height: 70, 
                      child: TextFormField(
                        controller: senhaController,
                        decoration: InputDecoration(
                          filled: true,
                          fillColor: Colors.white,
                          border: OutlineInputBorder(),
                          contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
                        ),
                        obscureText: true,
                        validator: (value) {
                          if (value == null || value.isEmpty) {
                            return 'Por favor, insira a senha';
                          } else if (cpfController.text.length==11){
                            if(confereSenha()) {
                              return 'Senha incorreta';
                              }
                          return null;
                          } else if (confereSenhaCnpj()){
                            return 'Senha incorreta';
                          }
                          return null;
                          
                        },
                      ),
                    ),
                    SizedBox(height: 20),
                    Container(
                      width: double.infinity,
                      height: 50,
                      child: ElevatedButton(
                        onPressed: () {
                          if (widget.listaEm.length == 0 && widget.listaAl.length == 0 && widget.listaVa.length == 0){
                            widget.listaEm.add(x);
                            widget.listaEm.add(y);
                            widget.listaVa.add(v1);
                            widget.listaVa.add(v2);
                            widget.listaAl.add(a);
                            widget.listaAl.add(b);
                          }
                          
                          if (_formKey.currentState!.validate()) {
                            int indexL = indexLista();
                            
                            if (cpfController.text.length==11){
                            Navigator.push(context, MaterialPageRoute(builder: (context)=> HomeAluno(widget.listaAl, widget.listaEm, widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs, indexL)));
                            } else
                            Navigator.push(context, MaterialPageRoute(builder: (context)=> HomeEmpresa(widget.listaAl,widget.listaEm,widget.listaVa,widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs,indexL)));
                          }
                        },
                        style: ElevatedButton.styleFrom(
                          shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.zero,
                          ),
                          backgroundColor: Color.fromARGB(255, 2, 146, 191),
                        ),
                        child: Text("Entrar", style: TextStyle(color: Colors.white)),
                      ),
                    ),
                    SizedBox(height: 15),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.end,
                      children: [
                        GestureDetector(
                          onTap: _showDialog,
                          child: Text('Cadastre-se', style: TextStyle(color: Color.fromARGB(255, 90, 191, 252))),
                        ),
                      ],
                    ),
                  ],
                ),
              ),
            ],
          ),
        ),
      ),
    );
  }

  void _showDialog() {
    showDialog(
      context: context,
      builder: (BuildContext context) {
        
        return AlertDialog(
          title: Text("Você é:"),
          actions: <Widget>[
            
            Row(
              children: [
                Container(
                  padding: EdgeInsets.fromLTRB(10, 0, 10, 0),
                  alignment: Alignment.center,
                  child: ElevatedButton(
                    child: Text("Empresa"),
                    onPressed: () {
                      Navigator.push(context, MaterialPageRoute(builder: (context)=> CadastroEmpresa(widget.listaAl,widget.listaEm, widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs,)));
                    },
                  ),
                ),
                Container(
                  padding: EdgeInsets.fromLTRB(10, 0, 10, 0),
                  alignment: Alignment.center,
                  child: ElevatedButton(
                    child: Text("Aluno"),
                    onPressed: () {
                      Navigator.push(context, MaterialPageRoute(builder: (context)=> CadastroAluno(widget.listaAl,widget.listaEm, widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs,)));
                    },
                  ),
                ),
              ],
            )
          ],
        );
      },
    );
  }
  bool confereCpf()
  {
    for(int i = 0; i < widget.listaAl.length; i++){
      if(widget.listaAl[i].CPF == cpfController.text){
        return false;
      }
    }
    return true;
    
  }

  bool confereCnpj()
  {
    for(int i = 0; i < widget.listaEm.length; i++){
      if(widget.listaEm[i].CNPJ == cpfController.text){
        return false;
      }
    }
    return true;
    
  }

  bool confereSenha()
  {
    for(int i = 0; i < widget.listaAl.length; i++){
      if(widget.listaAl[i].CPF == cpfController.text){
        if (widget.listaAl[i].senha == senhaController.text){
          return false;
        }
      }
    }
    return true;
    
  }

   bool confereSenhaCnpj()
  {
    for(int i = 0; i < widget.listaEm.length; i++){
      if(widget.listaEm[i].CNPJ == cpfController.text){
        if (widget.listaEm[i].senha == senhaController.text){
          return false;
        }
      }
    }
    return true;
  }

  int indexLista() {
  // Verifica se o comprimento do texto do cpfController é 11
  if (cpfController.text.length == 11) {
    // Itera sobre a lista de alunos
    for (int i = 0; i < widget.listaAl.length; i++) {
      // Compara o CPF do aluno com o texto do cpfController
      if (widget.listaAl[i].CPF == cpfController.text) {
        return i; // Retorna o índice se encontrar
      }
    }
  } else {
    // Itera sobre a lista de empresas
    for (int i = 0; i < widget.listaEm.length; i++) {
      // Compara o CNPJ da empresa com o texto do cpfController
      if (widget.listaEm[i].CNPJ == cpfController.text) {
        return i; // Retorna o índice se encontrar
      }
    }
  }
  return -2; // Retorna -2 se não encontrar
}
}