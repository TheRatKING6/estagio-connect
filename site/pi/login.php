<?php
  if ($_SERVER["REQUEST_METHOD"] === 'GET') {
    
    $pagina = "";

  } else if ($_SERVER["REQUEST_METHOD"] === 'POST'){

    $pagina = "";

    $login = $_POST["login"];
    $senha = $_POST["senha"];

    if ((trim($login) != "") && (trim($senha) != "")) {

      if (($login == "11223344") && ($senha == "1234")) {
        session_start();
        $_SESSION["login"] = $login;
        header('Location: loginA.php');


      } else if ( ($login == "55667788") && ($senha == "5678")) {
        session_start();
        $_SESSION["login"] = $login;
        header('Location: loginB.php');
        
      } else{

        echo "Login e/ou senha inválido(s)!";

      }
    } else{
      echo "Informe seu login e sua senha";
    }

  }

?>


<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">
  <link rel="icon" href="favicon.ico">
	<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.5/font/bootstrap-icons.css">
  <link rel="stylesheet" href="style1.css">
	<title>Cadastro - Empresa</title>
  <style type="text/css">
    body {
          background-image: url("img/backimage.png");
          background-size: cover;
          background-position: center;
       }
       .boxInfo{

           
            background-color: white;
            border-radius: 15px;
            padding: 30px;
            margin-bottom: 20px;

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
        <a class="nav-link active" aria-current="page" href="home.html">Home</a>
        <a class="nav-link" href="sobrenos.html">Sobre Nós</a>
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

<!--container Login-->

  <br><br>
  <div class="container md-3">
  <div class="row" style="color:white; text-align: center;">
   <h6 class="display-6 "><b>Login</b></h6>
  <p class="lead">Entre com sua conta </p>

  <div>
    <div class="col-12" ><hr class="estConne" style="color:white;"></div>    
  </div>
</div>
</div>
<div style="padding: 15px;">
<div class="container  boxInfo col-md-4 col-sm-12">

<form class="needs-validation" novalidate method="post">
<br>

  <div class="row">
    <div class="col-sm-12 ">
      <label class="form-label">CPF/CNPJ: </label><br>
      <input type="text" class="form-control" name="login" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
  </div>
 
  
  

  <br>

  <div class="row">
  <div class="col-12">
      <label class="form-label">Senha: </label><br>
      <input type="password"  class="form-control" id="password" name="senha" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

  </div>



<br>
    
<!--botao envio inicio-->
    <div style="text-align: center; margin-bottom: 20px;">

        <button type="submit" class="btn btn-info btncolor" style=" width: 90%; margin-top: 10px; " >
           Entrar

        </button>



    
<!--botao envio fim-->
</div>
</div>
</div>
</form>
</div>
</div>

<!--fim container Login-->

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

  
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>

  <!--<script type="text/javascript">
                     
            (() => {
              'use strict'

              // Fetch all the forms we want to apply custom Bootstrap validation styles to
              const forms = document.querySelectorAll('.needs-validation')

              // Loop over them and prevent submission
              Array.from(forms).forEach(form => {
                form.addEventListener('submit', event => {
                  if (!form.checkValidity()) {
                    event.preventDefault()
                    event.stopPropagation()
                  }

                  form.classList.add('was-validated')
                }, false)
              })
            })()



             var password = document.getElementById("password")
            , confirm_password = document.getElementById("confirm_password");

          function validatePassword(){
            if(password.value != confirm_password.value) {
              confirm_password.setCustomValidity("Passwords Don't Match");
            } else {
              confirm_password.setCustomValidity('');
            }
          }

          password.onchange = validatePassword;
          confirm_password.onkeyup = validatePassword;

     
            const toastTrigger = document.getElementById('liveToastBtn')
            const toastLiveExample = document.getElementById('liveToast')

            if (toastTrigger) {
              const toastBootstrap = bootstrap.Toast.getOrCreateInstance(toastLiveExample)
              toastTrigger.addEventListener('click', () => {
                toastBootstrap.show()
              })
            }
  </script>-->

  <script src="scriptCadastro.js"></script>
  <?php
      if ($pagina != "") {
        include $pagina;
      }
    ?>
</body>
</html>