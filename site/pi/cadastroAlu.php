<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="anonymous">
  <link rel="icon" href="favicon.ico">
	<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.10.5/font/bootstrap-icons.css">
  <link rel="stylesheet" href="style1.css">
	<title>Cadastro - Aluno</title>
  <style type="text/css">
    body {
          background-image: url("img/backimage.png");
          background-size: cover;
          background-position: center;
       }
       .boxInfo{

            position: relative;
            background-color: white;
            border-radius: 15px;
            padding: 30px;
            width: 90%;
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
<!--container do Empresa-->

  <br><br>
  <div class="container md-3">
  <div class="row" style="color:white;">
   <h6 class="display-6 "><b>Cadastro<a class="estConne"> -</a> Aluno</b></h6>
  <p class="lead">Cadastre-se no Estágio Connect e conheça diversas vagas</p>

  <div>
    <div class="col-12" ><hr class="estConne" style="color:white;"></div>    
  </div>
  <br>
</div>
</div>

<div class="container containerCad boxInfo">

<form class="needs-validation" novalidate>
<br>
  <div class="row">
    <div class="col-md-9 col-sm-12 mb-3">
      <label class="form-label">Nome Completo: </label><br>
      <input type="text" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

    <div class=" col-md-3 col-sm-12 mb-3">
      <label class="form-label"  >Data de Nascimento: </label><br>
      <input type="date" class="form-control" required >
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
  </div>

  <br>
    
    <div class="row">
    <div class="col-md-5 col-sm-12 mb-3">
      <label class="form-label">Rua:</label>
      <input type="text" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

     <div class="col-md-2 col-sm-12 mb-3">
      <label class="form-label">Número:</label>
      <input type="text" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Bairro:</label>
      <input type="text" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

   
 
 
    <div class="col-md-2 col-sm-12 mb-3">
        <label class="form-label">Complemento:</label>
        <input type="text" class="form-control" required>
        <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
  </div>

  <div class="row">
    <div class="col-md-6 col-sm-12 mb-3">
      <label class="form-label">Cidade:</label>
      <input type="text" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Estado:</label>
      <select class="form-select" required>
        <option></option>
        <option>AC</option>
        <option>AL</option>
        <option>AP</option>
        <option>AM</option>
        <option>BA</option>
        <option>CE</option>
        <option>ES</option>
        <option>GO</option>
        <option>MA</option>
        <option>MT</option>
        <option>MS</option>
        <option>MG</option>
        <option>PA</option>
        <option>PB</option>
        <option>PR</option>
        <option>PE</option>
        <option>PI</option>
        <option>RJ</option>
        <option>RN</option>
        <option>RS</option>
        <option>RO</option>
        <option>RR</option>
        <option>SC</option>
        <option>SP</option>
        <option>SE</option>
        <option>TO</option>
        <option>DF</option>
        <div class="invalid-feedback">
        Campo obrigatório.
      </div>
      </select>
    </div>
 
  
    <div class="col-md-3 col-sm-12 mb-3">
        <label class="form-label">CEP:</label>
        <input type="text" class="form-control" required>
        <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
  </div>
  <br>

  <div class="row">
  <div class="col-md-6 col-sm-12 mb-3">
      <label class="form-label">Email de Contato: </label><br>
      <input type="email"  class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Telefone de Contato: </label>
      <input type="tel"  class="form-control">
    </div>

    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Área de Especialização: </label>
      <select class="form-select" required>
      <option></option>
        <option>Química</option>
        <option>Desenvolvimento de Sistemas</option>
        <option>Arquitetura/Engenharia</option>
        <option>Mecânica Industrial</option>
        <option>Enfermagem</option>
        <option>Qualidade de Produção</option>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
      </select>
    </div>
  </div>

     <div class="row">

        <div class="col-md-6 col-sm-12 mb-3">
          <label class="form-label">Escola:</label>
          <input type="text" class="form-control" required>
          <div class="invalid-feedback">
            Campo obrigatório.
          </div>
        </div>


      <div class="col-md-4 col-sm-12 mb-3">
            <label class="form-label">Status: </label>
            <select class="form-select" required>
            <option></option>
              <option>Estudando</option>
              <option>Estudos Concluídos</option>
              <option>Empregado</option>
              <option>Empregado e Estudando</option>
            <div class="invalid-feedback">
              Campo obrigatório.
            </div>
            </select>
          </div>

          <div class="col-md-2 col-sm-12 mb-3">
            <label class="form-label">Ano Letivo: </label>
            <select class="form-select" required>
            <option></option>
              <option>1</option>
              <option>2</option>
              <option>3</option>
              <option>4</option>
            <div class="invalid-feedback">
              Campo obrigatório.
            </div>
            </select>
          </div>

      

        </div>

<br>

  <div class="row">
  <div class="col-md-6 col-sm-12 mb-3">
      <label class="form-label">Senha: </label><br>
      <input type="password"  class="form-control" id="password" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

  <div class="col-md-6 col-sm-12 mb-3">
      <label class="form-label">Confirmar senha: </label><br>
      <input type="password"  class="form-control" id="confirm_password" required>
      <div class="invalid-feedback">
        Campo inválido ou senha não corresponde.
      </div>
    </div>

  </div>

<br>
    
<!--botao envio inicio-->
    <div class="row fimForm">
      <div class="col-12 ">
        <button type="submit" class="btn btn-info btncolor">
           <i class="bi bi-send"></i> Cadastrar
        </button>

        <button type="reset" class="btn btn-info btncolor" id="liveToastBtn">
          <i class="bi bi-x-circle"></i> Limpar
        </button>

          <!--toast limpar inicio-->
          <div class="toast-container position-fixed bottom-0 end-0 p-3">
                  <div id="liveToast" class="toast align-items-center  border-0" role="alert" aria-live="assertive" aria-atomic="true">
                      <div class="d-flex">
                        <div class="toast-body">
                          Formulário limpo com sucesso!
                        </div>
                        <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                      </div>
                    </div>
                </div>
              

          <!--toast limpar fim-->
      </div>
    </div>
<!--botao envio fim-->
</form>
</div>

<!--fim container Empresa-->
  
<?php
  require('assets/footer.html');
?>

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
</body>
</html>