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
      margin-bottom: 100px;
     }
     .card{
        border-bottom-left-radius:5px ;
        border-bottom-right-radius:5px ;

       }


       
  </style>
</head>
<body>
  
<?php
  session_start();
  if (isset($_SESSION["login"])) {

     require('assets/navbarLogado.html');;
  }
  else{
    
     require('assets/navbar.html');
  }
?>

<!-- inicio container introdução-->
<br>
<div class="container md-3">
  <div class="row">
    <div class="col-12 centralizaCont" style="color: white;">
      <h3 class="display-4 "><b>S<a class="estConne">o</a>bre N<a class="estConne">ó</a>s</b></h1>
      <p class="lead">Conheça a equipe</p>
    </div>
  </div>

  <div>
    <div class="col-12"><hr class="estConne"></div>    
  </div>

</div>

<!--fim container introducao-->

<br>

       <!--inicio container sobrenos-->

<div class="container centralizaCont">
  
    <div class="row">

    <div class="col-md-6 col-lg-3 margemBaixo">
      
      <div class="card">
        <img src="img/perfil.jpg" class="card-img-top " alt="Pedro">
        <div class="card-body alturaCardsNos">
          <h5 class="card-title">Pedro Furtado Carvalho</h5>
          <p class="card-text">Programador full-stack<br>Desenvolvedor de software</p><br>
        </div>
      </div>

    </div>

  <div class="col-md-6 col-lg-3 margemBaixo">
      
      <div class="card">
        <img src="img/perfil.jpg" class="card-img-top " alt="Lucas">
        <div class="card-body alturaCardsNos">
          <h5 class="card-title">Lucas David de Sousa</h5>
          <p class="card-text">Programador back-end<br>Analista de sistemas</p><br>
        </div>
      </div>

    </div>


   <div class="col-md-6 col-lg-3 margemBaixo">
      
      <div class="card">
        <img src="img/perfil.jpg" class="card-img-top " alt="Aline">
        <div class="card-body alturaCardsNos">
          <h5 class="card-title">Aline Yumi Shimojo</h5>
          <p class="card-text">Programador front-end<br>Desenvolvedor Web</p><br>
        </div>
      </div>

    </div>

    <div class="col-md-6 col-lg-3 margemBaixo">
      
      <div class="card">
        <img src="img/perfil.jpg" class="card-img-top " alt="Rafael">
        <div class="card-body alturaCardsNos">
          <h5 class="card-title">Rafael Petrini dos Santos</h5>
          <p class="card-text">Programador back-end<br>Administrador de banco de dados</p><br>
        </div>
      </div>

    </div>
    
</div>

</div>
<!--fim container sobrenos-->
<br><br>

<?php
  require('assets/footer.html');
?>
    


<!--inicio script-->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
<!--fim script-->

</body>
</html>