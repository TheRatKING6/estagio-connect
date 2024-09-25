import 'package:flutter/cupertino.dart';
import 'package:flutter/widgets.dart';
import 'package:flutter/material.dart';
import 'package:login/Aluno.dart';
import 'package:login/Empresa.dart';
import 'package:login/Vagas.dart';
import 'package:login/configuracaoAluno.dart';
import 'package:login/configuracaoVaga.dart';
import 'package:login/criarVagas.dart';
import 'package:login/likeAluno.dart';
import 'package:login/likeEmpresa.dart';
import 'package:login/login.dart';
import 'package:login/matchs.dart';
import 'package:login/perfilEmpresa.dart';

class HomeEmpresa extends StatefulWidget {
  HomeEmpresa(this.listaAl, this.listaEm, this.listaVa, this.listaLikeAl, this.listaLikeEm, this.listaMatchs, this.indexL,{Key? key}) : super(key: key);
  List<Aluno> listaAl = [];
  List<Empresa> listaEm = [];
  List<Vagas> listaVa = [];
  List<LikeAluno> listaLikeAl = [];
  List<LikeEmpresa> listaLikeEm = [];
  List<Matchs> listaMatchs = [];
  int indexL = -1;


  @override
  State<HomeEmpresa> createState() => _HomeEmpresaState();
}

class _HomeEmpresaState extends State<HomeEmpresa> with TickerProviderStateMixin {
  late TabController _homeTabController;
  late TabController _searchTabController;
  TextEditingController curriculoController = TextEditingController();
  int _currentIndex = 0;
  List<Vagas> listaVagas = [];
  Set<Aluno> listaAlunoRecente = {};
  List<Aluno> listaAlunoSugestao = [];
  List<Aluno> listaFavoritos = [];
  List<LikeEmpresa> listaLikeDessaEmpresa = [];

  @override
  void initState() {
    super.initState();
    _homeTabController = TabController(length: 3, vsync: this);
    _searchTabController = TabController(length: 1, vsync: this);

    for (int j = 0; j<widget.listaAl.length; j++){
    for (int i = 0; i<widget.listaVa.length; i++){
      if (widget.listaEm[widget.indexL].CNPJ == widget.listaVa[i].idEmpresa){
        if (widget.listaVa[i].area == widget.listaAl[j].especialidade){
          listaAlunoRecente.add(widget.listaAl[j]);
        }
      }
    }
    }

    for(int i = 0; i <widget.listaVa.length; i++){
      if (widget.listaEm[widget.indexL].CNPJ==widget.listaVa[i].idEmpresa){
        listaVagas.add(widget.listaVa[i]);
      }
    }

   for (Aluno aluno in widget.listaAl) {
    String descricaoSemVirgula = aluno.descricao.replaceAll(',', '');
    List<String> listaDescricao = descricaoSemVirgula.split(' ');

    for (Vagas vaga in listaVagas) {
      List<String> requisitosVaga = vaga.requisitos.replaceAll(',', '').split(' ');

      bool atendeRequisitos = requisitosVaga.every((requisito) => listaDescricao.contains(requisito));

      if (atendeRequisitos && !listaAlunoSugestao.contains(aluno)) {
        listaAlunoSugestao.add(aluno);
      }
    }
  }

    for(int i = 0; i <widget.listaLikeEm.length; i++){
       if (widget.listaLikeEm[i].cnpj == widget.listaEm[widget.indexL].CNPJ){
        listaLikeDessaEmpresa.add(widget.listaLikeEm[i]);
       }
    }

    for(int i = 0; i < listaLikeDessaEmpresa.length; i++){
      for (int j = 0; j < widget.listaAl.length; j++){
      if (listaLikeDessaEmpresa[i].cpf == widget.listaAl[j].CPF){
        listaFavoritos.add(widget.listaAl[j]);
      }
    }
  }

  }

    

  @override
  void dispose() {
    _homeTabController.dispose();
    _searchTabController.dispose();
    curriculoController.dispose();
    super.dispose();
  }

  List<Widget> _screens = [];

  @override
  Widget build(BuildContext context) {
    _screens = [
      _buildHomeScreen(),
      _buildSearchScreen(),
      _buildVagaScreen(),
      _buildConnectScreen(),
    ];

    return Scaffold(
      appBar: AppBar(
        leading: IconButton(
            icon: Icon(Icons.arrow_back),
            onPressed: () {
              Navigator.of(context).pushReplacement(
                MaterialPageRoute(builder: (context) => Login(widget.listaAl,widget.listaEm,widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs)),  
              );
            },
          ),
        backgroundColor: _currentIndex == 1
            ? Color.fromARGB(255, 230, 230, 230)
            : Color.fromARGB(255, 220, 255, 247),
        actions: _buildAppBarScreen(),
        title: _buildTitleScreen()
      ),
      backgroundColor: _currentIndex == 1
          ? Color.fromARGB(255, 230, 230, 230)
          : Color.fromARGB(255, 220, 255, 247),
      body: _screens[_currentIndex],
      bottomNavigationBar: BottomNavigationBar(
        type: BottomNavigationBarType.fixed,
        currentIndex: _currentIndex,
        backgroundColor: Color.fromARGB(255, 132, 229, 217),
        selectedItemColor: Color.fromARGB(255, 13, 153, 255),
        unselectedItemColor: Color.fromARGB(255, 73, 69, 79),
        onTap: (index) {
          setState(() {
            _currentIndex = index;
          });
        },
        items: [
          BottomNavigationBarItem(
            icon: Icon(Icons.home),
            label: 'Início',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.search),
            label: 'Buscar',
          ),
          BottomNavigationBarItem(
            icon: Icon(Icons.work),
            label: 'Vagas',
            ),
          BottomNavigationBarItem(
            icon: Icon(Icons.connect_without_contact),
            label: 'Connects',
          ),
        ],
      ),
    );
  }

  Widget _buildHomeScreen() {
    return Column(
      children: [
        TabBar(
          indicatorColor: Color.fromARGB(255, 168, 221, 237),
          labelColor: Color.fromARGB(255, 13, 153, 255),
          controller: _homeTabController,
          tabs: [
            Tab(text: 'Favoritos', icon: Icon(Icons.favorite)),
            Tab(text: 'Mais Recentes', icon: Icon(Icons.update)),
            Tab(text: 'Sugestões', icon: Icon(Icons.lightbulb)),
          ],
        ),
        Expanded(
          child: TabBarView(
            controller: _homeTabController,
            children: [
              _buildFavoritosTab(),
              _buildAlunosList(listaAlunoRecente.toList()),
              _buildAlunosList(listaAlunoSugestao),
            ],
          ),
        ),
      ],
    );
  }

  Widget _buildFavoritosTab() {
    return listaFavoritos.isEmpty
        ? Center(child: Text('Nenhum Aluno favoritado.'))
        : _buildAlunosList(listaFavoritos);
  }

  Widget _buildAlunosList(List<Aluno> alunosList) {
    return ListView.builder(
      itemCount: alunosList.length,
      itemBuilder: (context, index) {
        if (index >= alunosList.length) {
          return SizedBox.shrink();
        }
        Aluno aluno = alunosList[index];
        bool isFavorite = listaFavoritos.contains(aluno);
        return Card(
          margin: EdgeInsets.all(30.0),
          child: Align(
            alignment: Alignment.centerRight,
            child: ExpansionTile(
              title: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Row(
                    children: [
                      Image.asset("assets/images/iconPerfil.png", width: 60),
                      SizedBox(width: 5),
                      Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(
                            aluno.nome,
                            style: TextStyle(
                              fontSize: 14.0,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          SizedBox(height: 1.0),
                          Text(
                            aluno.cidade +
                                " - " +
                               aluno.estado,
                            style: TextStyle(
                              fontSize: 12.0,
                              fontWeight: FontWeight.bold,
                            ),
                          )
                        ],
                      ),
                    ],
                  ),
                  SizedBox(height: 5),
                  Text(
                    aluno.especialidade,
                    style: TextStyle(
                      fontSize: 14.0,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                  SizedBox(height: 5),
                  Text(
                    aluno.descricao,
                    style: TextStyle(
                      fontSize: 14.0,
                    ),
                  ),
                  SizedBox(height: 5),
                  Text(
                    "Status: " + aluno.status,
                    style: TextStyle(
                      fontSize: 14.0,
                    ),
                  ),
                ],
              ),
              children: <Widget>[
                Padding(
                  padding: const EdgeInsets.symmetric(horizontal: 16.0),
                  child: Container(
                    alignment: Alignment.centerLeft,
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          "Ano: " + aluno.ano,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Escola: " + aluno.escola,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Telefone: " + aluno.telefone,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Email: " + aluno.email,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Rua: " + aluno.rua,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Bairro: " + aluno.bairro,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Número: " + aluno.numero,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Complemento: " + aluno.complemento,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 10),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.end,
                          children: [
                            IconButton(
                              icon: Icon(
                                isFavorite ? Icons.favorite : Icons.favorite_border,
                                color: isFavorite ? Colors.red : null,
                              ),
                              onPressed: () {
                                setState(() {
                                  if (isFavorite) {
                                    _removerFavorito(aluno);
                                  } else {
                                    _showVagaSelectionDialog(aluno);
                                  }
                                });
                              },
                            ),
                          ],
                        ),
                      ],
                    ),
                  ),
                ),
              ],
            ),
          ),
        );
      },
    );
  }

  void _adicionarFavorito(Aluno aluno, String vagaId) {
    setState(() {
      listaFavoritos.add(aluno);
      widget.listaLikeEm.add(
        LikeEmpresa(
          widget.listaEm[widget.indexL].CNPJ,
          aluno.CPF,
          vagaId,
        ),
      );
    });
  }

  void _removerFavorito(Aluno aluno) {
    setState(() {
      listaFavoritos.remove(aluno);
      widget.listaLikeEm.removeWhere(
        (like) => like.cnpj == widget.listaEm[widget.indexL].CNPJ && like.cpf == aluno.CPF,
      );
    });
  }

  void _showVagaSelectionDialog(Aluno aluno) {
  showDialog(
    barrierDismissible: false,
    context: context,
    builder: (context) {
      return AlertDialog(
        title: Text('Selecionar Vaga'),
        content: Container(
          width: double.maxFinite,
          child: ListView.builder(
            shrinkWrap: true,
            itemCount: listaVagas.length,
            itemBuilder: (context, index) {
              final vaga = listaVagas[index];
              return ListTile(
                title: Text(vaga.titulo),
                onTap: () {
                  _adicionarFavorito(aluno, vaga.id);
                  Navigator.pop(context);
                },
              );
            },
          ),
        ),
      );
    },
  );
}

  Widget? _buildTitleScreen(){
    if (_currentIndex == 0) {
      return Row(
        children: [
          Container(
            padding: const EdgeInsets.all(8.0),
            child: Text(
              'Bem vindo!',
              style: TextStyle(fontWeight: FontWeight.bold),
            ),
          ),
        ],
      );
    } else if (_currentIndex == 3) {
      return Row(
        children: [
          Container(
            padding: const EdgeInsets.all(8.0),
            child: Text(
              'Connects',
              style: TextStyle(fontWeight: FontWeight.bold),
            ),
          ),
        ],
      );
    }else if (_currentIndex == 2){
      return Row(
        children: [
          Container(
            padding: const EdgeInsets.all(8.0),
            child: Text(
              'Criar Vagas',
              style: TextStyle(fontWeight: FontWeight.bold),
            ),
          ),
        ],
      );
    }
     else {
      return null;
    }
  }

  List<Widget> _buildAppBarScreen(){if (_currentIndex == 2) {
      return [
        IconButton(
          icon: Icon(Icons.add),
          onPressed: () {
            Navigator.push(context, MaterialPageRoute(builder: (context)=> CriarVagas(widget.listaAl,widget.listaEm, widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs, widget.indexL)));
          },
        ),
        Padding(
          padding: const EdgeInsets.fromLTRB(0, 0, 25, 0),
          child: InkWell(
              onTap: () {
                Navigator.push(context, MaterialPageRoute(builder: (context)=> PerfilEmpresa(widget.listaAl,widget.listaEm,widget.listaVa,widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs, widget.indexL)));
              },
              child: Image.asset(
                "assets/images/iconPerfil.png",
                width: 45,
              ),
            )
        ),
      ];
    } else {
      return [
        Padding(
          padding: const EdgeInsets.fromLTRB(0, 0, 25, 0),
          child: InkWell(
              onTap: () {
                Navigator.push(context, MaterialPageRoute(builder: (context)=> PerfilEmpresa(widget.listaAl,widget.listaEm,widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs, widget.indexL)));
              },
              child: Image.asset(
                "assets/images/iconPerfil.png",
                width: 45,
              ),
            )
        ),
      ];
    }
  }
  Widget _buildSearchScreen() {
  return Column(
    children: [
      TabBar(
        indicatorColor: Color.fromARGB(255, 168, 221, 237),
        labelColor: Color.fromARGB(255, 13, 153, 255),
        controller: _searchTabController,
        tabs: [
          Tab(text: 'Currículos', icon: Icon(Icons.work)),
        ],
      ),
      Expanded(
        child: TabBarView(
          controller: _searchTabController,
          children: [
            Column(
              children: [
                Container(
                  padding: EdgeInsets.fromLTRB(40, 40, 40, 40),
                  alignment: Alignment.center,
                  child: TextField(
                    controller: curriculoController,
                    decoration: InputDecoration(
                      filled: true,
                      fillColor: Colors.white,
                      border: OutlineInputBorder(),
                      contentPadding: EdgeInsets.symmetric(vertical: 10, horizontal: 10),
                      labelText: 'Buscar',
                      suffixIcon: IconButton(
                        icon: Icon(Icons.search),
                        onPressed: () {
                          setState(() {});
                        },
                      ),
                    ),
                  ),
                ),
                Expanded(child: _buildAlunoSearchScreen()),
              ],
            ),
          ],
        ),
      ),
    ],
  );
}

  Widget _buildAlunoSearchScreen() {
    List<Aluno> filteredAlunos = widget.listaAl.where((aluno) {
    String searchText = curriculoController.text.toLowerCase();
    return 
        aluno.escola.toLowerCase().contains(searchText) ||
        aluno.ano.toLowerCase().contains(searchText) ||
        aluno.status.toLowerCase().contains(searchText) ||
        aluno.especialidade.toLowerCase().contains(searchText) ||
        aluno.estado.toLowerCase().contains(searchText) ||
        aluno.cidade.toLowerCase().contains(searchText) ||
        aluno.bairro.toLowerCase().contains(searchText) ||
        aluno.rua.toLowerCase().contains(searchText) ||
        aluno.nome.toLowerCase().contains(searchText) ||
        aluno.email.toLowerCase().contains(searchText) ||
        aluno.telefone.toLowerCase().contains(searchText) ||
        aluno.descricao.toLowerCase().contains(searchText); 
  }).toList();

  return Container(
    padding: EdgeInsets.fromLTRB(40, 40, 40, 40),
    alignment: Alignment.center,
    child: Column(
      children: [
        curriculoController.text.isNotEmpty
            ? Expanded(
                child: ListView.builder(
                  itemCount: filteredAlunos.length,
                  itemBuilder: (context, index) {
                    Aluno aluno = filteredAlunos[index];
                    bool isFavorite = listaFavoritos.contains(aluno);
                    return Card(
          margin: EdgeInsets.all(30.0),
          child: Align(
            alignment: Alignment.centerRight,
            child: ExpansionTile(
              title: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Row(
                    children: [
                      Image.asset("assets/images/iconPerfil.png", width: 60),
                      SizedBox(width: 5),
                      Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(
                            aluno.nome,
                            style: TextStyle(
                              fontSize: 14.0,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          SizedBox(height: 1.0),
                          Text(
                            aluno.cidade +
                                " - " +
                               aluno.estado,
                            style: TextStyle(
                              fontSize: 12.0,
                              fontWeight: FontWeight.bold,
                            ),
                          )
                        ],
                      ),
                    ],
                  ),
                  SizedBox(height: 5),
                  Text(
                    aluno.especialidade,
                    style: TextStyle(
                      fontSize: 14.0,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                  SizedBox(height: 5),
                  Text(
                    aluno.descricao,
                    style: TextStyle(
                      fontSize: 14.0,
                    ),
                  ),
                  SizedBox(height: 5),
                  Text(
                    "Status: " + aluno.status,
                    style: TextStyle(
                      fontSize: 14.0,
                    ),
                  ),
                ],
              ),
              children: <Widget>[
                Padding(
                  padding: const EdgeInsets.symmetric(horizontal: 16.0),
                  child: Container(
                    alignment: Alignment.centerLeft,
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          "Ano: " + aluno.ano,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Escola: " + aluno.escola,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Telefone: " + aluno.telefone,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Email: " + aluno.email,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Rua: " + aluno.rua,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Bairro: " + aluno.bairro,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Número: " + aluno.numero,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Complemento: " + aluno.complemento,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 10),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.end,
                          children: [
                            IconButton(
                              icon: Icon(
                                isFavorite ? Icons.favorite : Icons.favorite_border,
                                color: isFavorite ? Colors.red : null,
                              ),
                              onPressed: () {
                                setState(() {
                                  if (isFavorite) {
                                    _removerFavorito(aluno);
                                  } else {
                                    _showVagaSelectionDialog(aluno);
                                  }
                                });
                              },
                            ),
                          ],
                        ),
                      ],
                    ),
                  ),
                ),
              ],
            ),
          ),
        );
                  },
                ),
              )
            : Center(child: Text('Digite algo para buscar alunos.')),
      ],
    ),
  );
  }

 Widget _buildVagaScreen() {
  return ListView.builder(
    itemCount: listaVagas.length,
    itemBuilder: (context, index) {
      if (index >= listaVagas.length) {
        return SizedBox.shrink(); 
      }
      Vagas vaga = listaVagas[index];
      return Card(
        margin: EdgeInsets.all(30.0),
        child: Align(
          alignment: Alignment.centerRight,
          child: ExpansionTile(
            title: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Row(
                  children: [
                    Image.asset("assets/images/iconPerfil.png", width: 60),
                    SizedBox(width: 5),
                    Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          widget.listaEm[widget.indexL].nome,
                          style: TextStyle(
                            fontSize: 14.0,
                            fontWeight: FontWeight.bold,
                          ),
                        ),
                        SizedBox(height: 1.0),
                        Text(
                          widget.listaEm[widget.indexL].cidade +
                              " - " +
                              widget.listaEm[widget.indexL].estado,
                          style: TextStyle(
                            fontSize: 12.0,
                            fontWeight: FontWeight.bold,
                          ),
                        )
                      ],
                    ),
                  ],
                ),
                SizedBox(height: 5),
                Text(
                  vaga.titulo,
                  style: TextStyle(
                    fontSize: 14.0,
                    fontWeight: FontWeight.bold,
                  ),
                ),
                SizedBox(height: 5),
                Text(
                  vaga.descricao,
                  style: TextStyle(
                    fontSize: 14.0,
                  ),
                ),
                SizedBox(height: 5),
                Text(
                  "Requisitos: " + vaga.requisitos,
                  style: TextStyle(
                    fontSize: 14.0,
                  ),
                ),
              ],
            ),
            children: <Widget>[
              Padding(
                padding: const EdgeInsets.symmetric(horizontal: 16.0),
                child: Container(
                  alignment: Alignment.centerLeft, 
                  child: Column(
                    crossAxisAlignment: CrossAxisAlignment.start,
                    children: [
                      Text(
                        "Salário: " + vaga.salario,
                        style: TextStyle(
                          fontSize: 14.0,
                        ),
                      ),
                      SizedBox(height: 5),
                      Text(
                        "Localização: " + vaga.localizacao,
                        style: TextStyle(
                          fontSize: 14.0,
                        ),
                      ),
                      SizedBox(height: 5),
                      Text(
                        "Benefícios: " + vaga.beneficios,
                        style: TextStyle(
                          fontSize: 14.0,
                        ),
                      ),
                      SizedBox(height: 5),
                      Text(
                        "Área de especialidade: " + vaga.area,
                        style: TextStyle(
                          fontSize: 14.0,
                        ),
                      ),
                      SizedBox(height: 5),
                      Text(
                        "Prazo de Aplicação: " + vaga.prazo,
                        style: TextStyle(
                          fontSize: 14.0,
                        ),
                      ),
                      SizedBox(height: 5),
                      Text(
                        "Número de Vagas: " + vaga.numero,
                        style: TextStyle(
                          fontSize: 14.0,
                        ),
                      ),
                      SizedBox(height: 10),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.end,
                        children: [
                          IconButton(
                            icon: Icon(Icons.edit),
                            onPressed: () {
                              Navigator.push(context, MaterialPageRoute(builder: (context)=> ConfiguracaoVagas(
                                widget.listaAl,
                                widget.listaEm,
                                widget.listaVa,
                                widget.listaLikeAl,
                                widget.listaLikeEm,
                                widget.listaMatchs,
                                widget.indexL,
                                listaVagas[index].id,
                                widget.listaEm[widget.indexL].CNPJ,
                                listaVagas[index].titulo,
                                listaVagas[index].descricao,
                                listaVagas[index].salario,
                                listaVagas[index].localizacao,
                                listaVagas[index].requisitos,
                                listaVagas[index].beneficios,
                                listaVagas[index].area,
                                listaVagas[index].prazo,
                                listaVagas[index].numero,
                                )));
                            },
                          ),
                          IconButton(
                            icon: Icon(Icons.delete),
                            onPressed: () {
                              setState(() {
                                var vagaRemovida = listaVagas.removeAt(index);
                                widget.listaVa.removeWhere((v) => v == vagaRemovida);
                              });
                            },
                          ),
                        ],
                      ),
                    ],
                  ),
                ),
              ),
            ],
          ),
        ),
      );
    },
  );
}


  Widget _buildConnectScreen() {
    List<Aluno> matches = getMatchesParaEmpresa();

  return matches.isEmpty
      ? Center(child: Text('Nenhum match encontrado.'))
      :ListView.builder(
      itemCount: matches.length,
      itemBuilder: (context, index) {
        if (index >= matches.length) {
          return SizedBox.shrink();
        }
        Aluno aluno = matches[index];
        bool isFavorite = listaFavoritos.contains(aluno);
        return Card(
          margin: EdgeInsets.all(30.0),
          child: Align(
            alignment: Alignment.centerRight,
            child: ExpansionTile(
              title: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  Row(
                    children: [
                      Image.asset("assets/images/iconPerfil.png", width: 60),
                      SizedBox(width: 5),
                      Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          Text(
                            aluno.nome,
                            style: TextStyle(
                              fontSize: 14.0,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          SizedBox(height: 1.0),
                          Text(
                            aluno.cidade +
                                " - " +
                               aluno.estado,
                            style: TextStyle(
                              fontSize: 12.0,
                              fontWeight: FontWeight.bold,
                            ),
                          )
                        ],
                      ),
                    ],
                  ),
                  SizedBox(height: 5),
                  Text(
                    aluno.especialidade,
                    style: TextStyle(
                      fontSize: 14.0,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                  SizedBox(height: 5),
                  Text(
                    aluno.descricao,
                    style: TextStyle(
                      fontSize: 14.0,
                    ),
                  ),
                  SizedBox(height: 5),
                  Text(
                    "Status: " + aluno.status,
                    style: TextStyle(
                      fontSize: 14.0,
                    ),
                  ),
                ],
              ),
              children: <Widget>[
                Padding(
                  padding: const EdgeInsets.symmetric(horizontal: 16.0),
                  child: Container(
                    alignment: Alignment.centerLeft,
                    child: Column(
                      crossAxisAlignment: CrossAxisAlignment.start,
                      children: [
                        Text(
                          "Ano: " + aluno.ano,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Escola: " + aluno.escola,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Telefone: " + aluno.telefone,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Email: " + aluno.email,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Rua: " + aluno.rua,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Bairro: " + aluno.bairro,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Número: " + aluno.numero,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Complemento: " + aluno.complemento,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 10),
                        Row(
                          mainAxisAlignment: MainAxisAlignment.end,
                          children: [
                            IconButton(
                              icon: Icon(
                                isFavorite ? Icons.favorite : Icons.favorite_border,
                                color: isFavorite ? Colors.red : null,
                              ),
                              onPressed: () {
                                setState(() {
                                  if (isFavorite) {
                                    _removerFavorito(aluno);
                                  } else {
                                    _showVagaSelectionDialog(aluno);
                                  }
                                });
                              },
                            ),
                          ],
                        ),
                      ],
                    ),
                  ),
                ),
              ],
            ),
          ),
        );
      },
    );
  }


 bool alunoCurtiuVaga(String alunoId, String vagaId) {
  return widget.listaLikeAl.any((like) => like.cpf == alunoId && like.idVaga == vagaId);
} 
  bool isMatchEmpresa(String vagaId) {
  return widget.listaLikeAl.any((likeAluno) => alunoCurtiuVaga(likeAluno.cpf, vagaId) && 
                                              likeAluno.idVaga == vagaId);
}

List<Aluno> getMatchesParaEmpresa() {
  Set<Aluno> matches = {};

  var likesDaEmpresaAtual = widget.listaLikeEm.where((like) => like.cnpj == widget.listaEm[widget.indexL].CNPJ).toList();

  for (var likeEmpresa in likesDaEmpresaAtual) {
    if (isMatchEmpresa(likeEmpresa.idVaga)) {
      matches.add(widget.listaAl.firstWhere((aluno) => alunoCurtiuVaga(aluno.CPF, likeEmpresa.idVaga)));
    }
  }

  return matches.toList();
}

}
