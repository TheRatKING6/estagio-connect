<?php
	session_start();
?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
	<link rel="stylesheet" href="style1.css">
  <link rel="icon" href="favicon.ico">
	<title>Sobre Nós</title>
  <style type="text/css">
     body {
          background-image: url("img/backimage.png");
          background-size: cover;
          background-position: center;
       }

       .card{
        margin: auto;
        height: 110%;
        
       }
     .margemBaixo{
      margin-bottom: 60%;
     }
     .card{
        border-bottom-left-radius:5px ;
        border-bottom-right-radius:5px ;

       }


       
  </style>
</head>
<body>

<!--inicio navbar-->
<nav class="navbar navbar-expand-lg bg-body-tertiary">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">
    	 <img src="img/estagioconnect2.png" alt="Estagio connect" width="140px">
    </a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
      <div class="navbar-nav">
        <a class="nav-link" href="home.html">Home</a>
        <a class="nav-link active" aria-current="page" href="sobrenos.html">Sobre Nós</a>
        <a class="nav-link" href="download.html">Download</a>
        <a class="nav-link" href="tutorial.html">Tutorial</a>


        <a class="nav-link" data-bs-toggle="modal" data-bs-target="#Modal">Cadastro</a>

        <!-- Modal -->
      <div class="modal fade modal-sm" id="Modal" tabindex="-1" aria-labelledby="ModalLabel" aria-hidden="true">
        <div class="modal-dialog">
          <div class="modal-content">
            <div class="modal-header">
              <h1 class="modal-title fs-5" id="ModalLabel">Cadastro</h1>
              <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div class="modal-body">
              Escolha o cadastro que deseja prosseguir:
            </div>
          <div class="modal-body centralizaCont">
          <a href="cadastroAlu.html">
              <button type="button" class="btn btn-info btncolor botaoAluno" > Aluno </button>
          </a>

          <a href="cadastroEmp.html">
              <button type="button" class="btn btn-info btncolor botaoEmpresa" href="cadastroEmp.html"> Empresa </button>
          </a>
            </div>
              <a href="login.html" class="minLog">Já possui cadastro? Faça login...</a>
            <br>
          </div>
        </div>
      </div>
    <!--fim modal-->

      </div>
    </div>
  </div>
</nav>
<!--fim navbar-->

<!-- inicio container introdução-->
<br>
<div class="container md-3">
  <div class="row">
    <div class="col-12 " style="color: white;">
      <h3 class="display-4 "><b>Erro</b></h1>
      <p class="lead">Você não está logado!<br></p>
    </div>
  </div>

  <div>
    <div class="col-12"><hr class="estConne"></div>    
  </div>

</div>

<!--fim container introducao-->

<br>

<!--inicio container-->
<div class="container md-3">
	<div class="row">
		<a href="login.php" class="linkcolor">Voltar</a>
	</div>
  </div>
<div class="margemBaixo"></div>

<!--fim container-->
<br><br>
<!-- Footer -->
<div class="card">
  <div class="card-header " >
    Estágio Connect - COTIL
  </div>
  <div class="card-body">
    <h5 class="card-title centralizaCont">Conheça mais</h5>
    <p class="card-text">

        <div class="row centralizaCont">
            <a href="sobrenos.html" class="col-md-2 col-sm-12 linkcolor">Sobre nós</a>
  
            <a href="download.html" class="col-md-2 col-sm-12 linkcolor">Download</a>

             <a href="Home.html" class="col-md-4 col-sm-12 linkcolor">Home</a>
                 
            <a href="tutorial.html" class="col-md-2 col-sm-12 linkcolor">Tutorial</a>
 
            <a data-bs-toggle="modal" data-bs-target="#Modal" class="col-md-2 col-sm-12 linkcolor">Cadastro</a>
          
      </p>

  </div>

<!-- Footer -->
    


<!--inicio script-->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
<!--fim script-->

</body>
</html>