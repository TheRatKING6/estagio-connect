import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:flutter/widgets.dart';
import 'package:login/Aluno.dart';
import 'package:login/Empresa.dart';
import 'package:login/Vagas.dart';
import 'package:login/likeAluno.dart';
import 'package:login/likeEmpresa.dart';
import 'package:login/login.dart';
import 'package:login/matchs.dart';
import 'package:login/perfilAluno.dart';

class HomeAluno extends StatefulWidget {
  HomeAluno(this.listaAl, this.listaEm, this.listaVa, this.listaLikeAl, this.listaLikeEm, this.listaMatchs, this.indexL, {Key? key}) : super(key: key);

  List<Aluno> listaAl = [];
  List<Empresa> listaEm = [];
  List<Vagas> listaVa = [];
  List<LikeAluno> listaLikeAl = [];
  List<LikeEmpresa> listaLikeEm = [];
  List<Matchs> listaMatchs = [];
  int indexL = -1;

  @override
  State<HomeAluno> createState() => _HomeAlunoState();
}

class _HomeAlunoState extends State<HomeAluno> with TickerProviderStateMixin {
  late TabController _homeTabController;
  late TabController _searchTabController;
  TextEditingController empresaController = TextEditingController();
  TextEditingController vagasController = TextEditingController();
  int _currentIndex = 0;
  List<Vagas> listaVagaRecente = [];
  List<Vagas> listaVagaSugestao = [];
  List<Vagas> listaFavoritos = [];
  String descricaoSemVirgula = "";
  List<String> listaDescricao = [];
  List<LikeAluno> listaLikeDesseAluno = [];

  @override
  void initState() {
    super.initState();
    _homeTabController = TabController(length: 3, vsync: this);
    _searchTabController = TabController(length: 2, vsync: this);

    descricaoSemVirgula = widget.listaAl[widget.indexL].descricao.replaceAll(',', '');
    listaDescricao = descricaoSemVirgula.split(' ');

    for (int i = widget.listaVa.length - 1; i >= 0; i--) {
      if (widget.listaAl[widget.indexL].especialidade == widget.listaVa[i].area) {
        listaVagaRecente.add(widget.listaVa[i]);
      }
    }
    for (Vagas vaga in listaVagaRecente) {
      List<String> requisitosVaga = vaga.requisitos.replaceAll(',', '').split(' ');

      bool atendeRequisitos = requisitosVaga.every((requisito) => listaDescricao.contains(requisito));

      if (atendeRequisitos) {
        listaVagaSugestao.add(vaga);
      }
    }

    for(int i = 0; i <widget.listaLikeAl.length; i++){
       if (widget.listaLikeAl[i].cpf == widget.listaAl[widget.indexL].CPF){
        listaLikeDesseAluno.add(widget.listaLikeAl[i]);
       }
    }

    
    for(int i = 0; i < listaLikeDesseAluno.length; i++){
      for (int j = 0; j < widget.listaVa.length; j++){
      if (listaLikeDesseAluno[i].idVaga == widget.listaVa[j].id){
        listaFavoritos.add(widget.listaVa[j]);
      }
    }
  }
    
  }

  @override
  void dispose() {
    _homeTabController.dispose();
    _searchTabController.dispose();
    empresaController.dispose();
    vagasController.dispose();
    super.dispose();
  }

  List<Widget> _screens = [];

  @override
  Widget build(BuildContext context) {
    _screens = [
      _buildHomeScreen(),
      _buildSearchScreen(),
      _buildConnectScreen(),
    ];

    return Scaffold(
      appBar: AppBar(
        leading: IconButton(
          icon: Icon(Icons.arrow_back),
          onPressed: () {
            Navigator.of(context).pushReplacement(
              MaterialPageRoute(builder: (context) => Login(widget.listaAl, widget.listaEm, widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs)),
            );
          },
        ),
        backgroundColor: _currentIndex == 1
            ? Color.fromARGB(255, 230, 230, 230)
            : Color.fromARGB(255, 220, 255, 247),
        actions: [
          Padding(
            padding: const EdgeInsets.fromLTRB(0, 0, 25, 0),
            child: Builder(
              builder: (context) {
                return InkWell(
                  onTap: () {
                    Navigator.push(
                      context,
                      MaterialPageRoute(
                        builder: (context) => PerfilAluno(widget.listaAl, widget.listaEm, widget.listaVa, widget.listaLikeAl, widget.listaLikeEm, widget.listaMatchs, widget.indexL,),
                      ),
                    );
                  },
                  child: Image.asset(
                    "assets/images/iconPerfil.png",
                    width: 45,
                  ),
                );
              },
            ),
          ),
        ],
        title: _currentIndex == 0
            ? Row(
                children: [
                  Container(
                    padding: const EdgeInsets.all(8.0),
                    child: Text(
                      'Bem-vindo!',
                      style: TextStyle(fontWeight: FontWeight.bold),
                    ),
                  ),
                ],
              )
            : _currentIndex == 2
                ? Row(
                    children: [
                      Container(
                        padding: const EdgeInsets.all(8.0),
                        child: Text(
                          'Connects',
                          style: TextStyle(fontWeight: FontWeight.bold),
                        ),
                      ),
                    ],
                  )
                : null,
      ),
      backgroundColor: _currentIndex == 1
          ? Color.fromARGB(255, 230, 230, 230)
          : Color.fromARGB(255, 220, 255, 247),
      body: _screens[_currentIndex],
      bottomNavigationBar: BottomNavigationBar(
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
              _buildVagasList(listaVagaRecente),
              _buildVagasList(listaVagaSugestao),
            ],
          ),
        ),
      ],
    );
  }

  Widget _buildFavoritosTab() {
    return listaFavoritos.isEmpty
        ? Center(child: Text('Nenhuma vaga favorita.'))
        : _buildVagasList(listaFavoritos);
  }

  Widget _buildVagasList(List<Vagas> vagasList) {
    return ListView.builder(
      itemCount: vagasList.length,
      itemBuilder: (context, index) {
        if (index >= vagasList.length) {
          return SizedBox.shrink();
        }
        Vagas vaga = vagasList[index];
        bool isFavorite = listaFavoritos.contains(vaga);
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
                            widget.listaEm[retornaIndexEmpresa(vaga.idEmpresa)].nome,
                            style: TextStyle(
                              fontSize: 14.0,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          SizedBox(height: 1.0),
                          Text(
                            widget.listaEm[retornaIndexEmpresa(vaga.idEmpresa)].cidade +
                                " - " +
                               widget.listaEm[retornaIndexEmpresa(vaga.idEmpresa)].estado,
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
                              icon: Icon(
                                isFavorite ? Icons.favorite : Icons.favorite_border,
                                color: isFavorite ? Colors.red : null,
                              ),
                              onPressed: () {
                                setState(() {
                                  if (isFavorite) {
                                    _removerFavorito(vaga);
                                    
                                  } else {

                                    _adicionarFavorito(vaga);
                                    
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

  void _adicionarFavorito(Vagas vaga) {
    setState(() {
      listaFavoritos.add(vaga);
      widget.listaLikeAl.add(
        LikeAluno(
          widget.listaAl[widget.indexL].CPF,
          vaga.id,
        ),
      );
    });
  }

  void _removerFavorito(Vagas vaga) {
    setState(() {
      listaFavoritos.remove(vaga);
      widget.listaLikeAl.removeWhere(
        (like) => like.cpf == widget.listaAl[widget.indexL].CPF && like.idVaga == vaga.id,
      );
    });
    _removerMatch(vaga);
  }

  void _removerMatch(Vagas vaga) {
  setState(() {
    widget.listaLikeAl.removeWhere((like) => like.idVaga == vaga.id);
  });
}

  Widget _buildSearchScreen() {
    return Column(
      children: [
        TabBar(
          indicatorColor: Color.fromARGB(255, 168, 221, 237),
          labelColor: Color.fromARGB(255, 13, 153, 255),
          controller: _searchTabController,
          tabs: [
            Tab(text: 'Empresa', icon: Icon(Icons.business)),
            Tab(text: 'Vagas', icon: Icon(Icons.work)),
          ],
        ),
        Expanded(
          child: TabBarView(
            controller: _searchTabController,
            children: [
              _buildEmpresaSearchTab(),
              _buildVagasSearchTab(),
            ],
          ),
        ),
      ],
    );
  }

  Widget _buildEmpresaSearchTab() {
    List<Empresa> filteredEmpresas = widget.listaEm.where((empresa) {
      String searchText = empresaController.text.toLowerCase();
       return empresa.CNPJ.toLowerCase().contains(searchText) ||
          empresa.nome.toLowerCase().contains(searchText) ||
          empresa.rua.toLowerCase().contains(searchText) ||
          empresa.bairro.toLowerCase().contains(searchText) ||
          empresa.numero.toLowerCase().contains(searchText) ||
          empresa.complemento.toLowerCase().contains(searchText) ||
          empresa.cidade.toLowerCase().contains(searchText) ||
          empresa.estado.toLowerCase().contains(searchText) ||
          empresa.email.toLowerCase().contains(searchText) ||
          empresa.telefone.toLowerCase().contains(searchText) ||
          empresa.ramo.toLowerCase().contains(searchText) ||
          empresa.descricao.toLowerCase().contains(searchText);
    }).toList();

    return Container(
      padding: EdgeInsets.fromLTRB(40, 40, 40, 40),
      alignment: Alignment.center,
      child: Column(
        children: [
          TextField(
            controller: empresaController,
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
          SizedBox(height: 20),
          empresaController.text.isNotEmpty
              ? Expanded(
                  child: ListView.builder(
                    itemCount: filteredEmpresas.length,
                    itemBuilder: (context, index) {
                      Empresa empresa = filteredEmpresas[index];
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
                            empresa.nome,
                            style: TextStyle(
                              fontSize: 14.0,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          SizedBox(height: 1.0),
                          Text(
                            empresa.cidade +
                                " - " +
                            empresa.estado,
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
                    empresa.ramo,
                    style: TextStyle(
                      fontSize: 14.0,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                  SizedBox(height: 5),
                  Text(
                    empresa.descricao,
                    style: TextStyle(
                      fontSize: 14.0,
                    ),
                  ),
                  SizedBox(height: 5),
                  Text(
                    "Telefone: " + empresa.telefone,
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
                          "Email: " + empresa.email,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Rua: " + empresa.rua,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Bairro: " + empresa.bairro,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Número: " + empresa.numero,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 5),
                        Text(
                          "Complemento: " + empresa.complemento,
                          style: TextStyle(
                            fontSize: 14.0,
                          ),
                        ),
                        SizedBox(height: 10),
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
              : Center(child: Text('Digite algo para buscar empresas.')),
        ],
      ),
    );
  }

  Widget _buildVagasSearchTab() {
    List<Vagas> filteredVagas = widget.listaVa.where((vaga) {
    String searchText = vagasController.text.toLowerCase();
    Empresa empresa = widget.listaEm.firstWhere(
      (empresa) => empresa.CNPJ == vaga.idEmpresa, 
      orElse: () => Empresa('', '', '', '', '', '', '', '', '', '', '', '', ''),
    );

    return vaga.titulo.toLowerCase().contains(searchText) ||
        vaga.descricao.toLowerCase().contains(searchText) ||
        vaga.requisitos.toLowerCase().contains(searchText) ||
        vaga.localizacao.toLowerCase().contains(searchText) ||
        vaga.area.toLowerCase().contains(searchText) ||
        vaga.beneficios.toLowerCase().contains(searchText) ||
        empresa.nome.toLowerCase().contains(searchText);
  }).toList();


    return Container(
      padding: EdgeInsets.fromLTRB(40, 40, 40, 40),
      alignment: Alignment.center,
      child: Column(
        children: [
          TextField(
            controller: vagasController,
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
          SizedBox(height: 20),
          vagasController.text.isNotEmpty
              ? Expanded(
                  child: ListView.builder(
                    itemCount: filteredVagas.length,
                    itemBuilder: (context, index) {
                      Vagas vaga = filteredVagas[index];
                      bool isFavorite = listaFavoritos.contains(vaga);
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
                            widget.listaEm[retornaIndexEmpresa(vaga.idEmpresa)].nome,
                            style: TextStyle(
                              fontSize: 14.0,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          SizedBox(height: 1.0),
                          Text(
                            widget.listaEm[retornaIndexEmpresa(vaga.idEmpresa)].cidade +
                                " - " +
                            widget.listaEm[retornaIndexEmpresa(vaga.idEmpresa)].estado,
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
                              icon: Icon(
                                isFavorite ? Icons.favorite : Icons.favorite_border,
                                color: isFavorite ? Colors.red : null,
                              ),
                              onPressed: () {
                                setState(() {
                                  if (isFavorite) {
                                    _removerFavorito(vaga);
                                    
                                  } else {

                                  _adicionarFavorito(vaga);

                                    
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
              : Center(child: Text('Digite algo para buscar vagas.')),
        ],
      ),
    );
  }

  Widget _buildConnectScreen() {
    List<Vagas> matches = getMatches();

  return matches.isEmpty
      ? Center(child: Text('Nenhum match encontrado.'))
      : ListView.builder(
      itemCount:  matches.length,
      itemBuilder: (context, index) {
        if (index >=  matches.length) {
          return SizedBox.shrink();
        }
        Vagas vaga = matches[index];
        bool isFavorite = listaFavoritos.contains(vaga);
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
                            widget.listaEm[retornaIndexEmpresa(vaga.idEmpresa)].nome,
                            style: TextStyle(
                              fontSize: 14.0,
                              fontWeight: FontWeight.bold,
                            ),
                          ),
                          SizedBox(height: 1.0),
                          Text(
                            widget.listaEm[retornaIndexEmpresa(vaga.idEmpresa)].cidade +
                                " - " +
                               widget.listaEm[retornaIndexEmpresa(vaga.idEmpresa)].estado,
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
                              icon: Icon(
                                isFavorite ? Icons.favorite : Icons.favorite_border,
                                color: isFavorite ? Colors.red : null,
                              ),
                              onPressed: () {
                                setState(() {
                                  if (isFavorite) {
                                    _removerFavorito(vaga);
                                    
                                  } else {

                                    _adicionarFavorito(vaga);
                                    
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


List<Vagas> getMatches() {
  Set<Vagas> matches = {};

  for (var likeAluno in widget.listaLikeAl) {
    if (isMatch(likeAluno.cpf, likeAluno.idVaga)) {
      matches.add(widget.listaVa.firstWhere((vaga) => vaga.id == likeAluno.idVaga));
    }
  }

  return matches.toList();
}

  bool isMatch(String alunoId, String vagaId) {
  return widget.listaLikeEm.any((like) => like.idVaga == vagaId && like.cnpj == retornaIdEmpresa(vagaId));
}

String retornaIdEmpresa(String vagaId) {
  return widget.listaVa.firstWhere((vaga) => vaga.id == vagaId).idEmpresa;
}

  int retornaIndexEmpresa(String idDaEmpresa){
    for(int i = 0; i < widget.listaEm.length; i++){
     if(idDaEmpresa == widget.listaEm[i].CNPJ){
      return i;
     }

    }
    return -1;
  }
}