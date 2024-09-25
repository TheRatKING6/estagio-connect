
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

<?php
  session_start();
  
  if (isset($_SESSION["login"])) {
    if (isset($_SESSION["login"])=="11223344") {

     require('assets/navbarLogadoA.html');
  }else if (isset($_SESSION["login"])=="55667788") {
    require('assets/navbarLogadoB.html');
  }}
  else{
    
     require('assets/navbar.html');
  }
?>

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

<?php
  require('assets/footer.html');
?>
    


<!--inicio script-->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
<!--fim script-->

</body>
</html>