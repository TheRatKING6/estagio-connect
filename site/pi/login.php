
<?php

  if ($_SERVER["REQUEST_METHOD"] === 'GET') {
    
    $pagina = "";
    $texto = "";

  } else if ($_SERVER["REQUEST_METHOD"] === 'POST'){

    $pagina = "";
    $texto = "";

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
        

        //echo "Login e/ou senha inválido(s)!";
        $texto = '<div class="toast-container position-fixed bottom-0 end-0 p-3">
                <div id="liveToast" class="toast align-items-center  border-0" role="alert" aria-live="assertive" aria-atomic="true">
                    <div class="d-flex">
                      <div class="toast-body">
                      Login e/ou senha inválido(s)!
                      </div>
                      <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                    </div>
                  </div>
              </div>';

      }
    } else{
      //echo "Informe seu login e sua senha";
      $texto = '<div class="toast-container position-fixed bottom-0 end-0 p-3">
                <div id="liveToast" class="toast align-items-center  border-0" role="alert" aria-live="assertive" aria-atomic="true">
                    <div class="d-flex">
                      <div class="toast-body">
                      Informe seu login e sua senha
                      </div>
                      <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                    </div>
                  </div>
              </div>';

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
	<title>Login</title>
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

<?php
  session_start();
  if (isset($_SESSION["login"])) {

     require('assets/navbarLogado.html');;
  }
  else{
    
     require('assets/navbar.html');
  }
?>

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
      <input type="text" class="form-control" name="login" >

    </div>
  </div>
 
  
  

  <br>

  <div class="row">
  <div class="col-12">
      <label class="form-label">Senha: </label><br>
      <input type="password"  class="form-control" id="password" name="senha">
    </div>

  </div>



<br>
    
<!--botao envio inicio-->
    <div style="text-align: center; margin-bottom: 20px;">
        <button type="submit" class="btn btn-info btncolor" style="width: 90%; margin-top: 10px;" id="liveToastBtn">
            Entrar
        </button>
    </div>
        <?php echo $texto; ?>
        


    
<!--botao envio fim-->
</div>
</div>
</div>
</form>
</div>
</div>

<!--fim container Login-->

<?php
  require('assets/footer.html');
?>

  
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="anonymous"></script>
<script>
    document.addEventListener('DOMContentLoaded', function () {
        var toastElement = document.querySelector('.toast');
        if (toastElement) {
            var myToast = new bootstrap.Toast(toastElement);
            myToast.show();
        }
    });
</script>
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