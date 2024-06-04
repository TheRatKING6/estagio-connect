import 'package:flutter/material.dart';
import 'package:login/cadastroAluno.dart';
import 'package:login/cadastroAluno2.dart';
import 'package:login/cadastroEmpresa.dart';
import 'package:login/cadastroEmpresa2.dart';
import 'package:login/configuracaoAluno.dart';
import 'package:login/configuracaoEmpresa.dart';
import 'package:login/criarVagas.dart';
import 'package:login/homeAluno.dart';
import 'package:login/homeEmpresa.dart';
import 'package:login/login.dart';
import 'package:login/perfilAluno.dart';
import 'package:login/perfilEmpresa.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      title: 'Flutter Demo',
      theme: ThemeData(
        colorScheme: ColorScheme.fromSeed(seedColor: Colors.deepPurple),
        useMaterial3: true,
      ),
      //home: HomeEmpresa(),
      routes: {
        '/': (context) => Login([],[],[],[],[],[]),
        '/cadastroAluno':(context) => CadastroAluno([],[],[],[],[],[]),
        '/cadastroAluno2':(context) => CadastroAluno2([], [],[],[],[],[],"","","","","","","","","","","","","","",""),
        '/cadastroEmpresa':(context) => CadastroEmpresa([],[],[],[],[],[]),
        '/homeAluno':(context) => HomeAluno([],[],[],[],[],[],-1),
        '/homeEmpresa':(context) => HomeEmpresa([],[],[],[],[],[],-1),
        '/perfilAluno':(context) => PerfilAluno([],[],[],[],[],[],-1),
        '/perfilEmpresa':(context) => PerfilEmpresa([],[],[],[],[],[],-1),
        '/configuracaoAluno':(context) => ConfiguracaoAluno([],[],[],[],[],[],-1),
        '/configuracaoEmpresa':(context) => ConfiguracaoEmpresa([],[],[],[],[],[],-1),        
        '/cadastroEmpresa2':(context) => CadastroEmpresa2([], [],[],[],[],[],"","","","","","","","","","","",""),
        '/criarVaga': (context) => CriarVagas([],[],[],[],[],[],-1),
      },
    );
  }
}

