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
  

  
    include('assets/qualnavbar.php');


    if ($_SERVER["REQUEST_METHOD"] === 'GET'){
        $texto = "";
        $CNPJ = "";
        $Nome = "";
        $Rua = "";
        $Numero = "";
        $Bairro = "";
        $Complemento = "";
        $Cidade = "";
        $Estado = "";
        $CEP = "";
        $Email = "";
        $Telefone = "";
        $Ramo = "";
        $Descricao = "";
        $Senha = "";
        $mensagem = "";
    }

    if ($_SERVER["REQUEST_METHOD"] === 'POST'){
        $texto = "";
        $CNPJ = $_POST["CNPJ"];
        $Nome = $_POST["Nome"];
        $Rua = $_POST["Rua"];
        $Numero = $_POST["Numero"];
        $Bairro = $_POST["Bairro"];
        $Complemento = $_POST["Complemento"];
        $Cidade = $_POST["Cidade"];
        $Estado = $_POST["Estado"];
        $CEP = $_POST["CEP"];
        $Email = $_POST["Email"];
        $Telefone = $_POST["Telefone"];
        $Ramo = $_POST["Ramo"];
        $Descricao = $_POST["Descricao"];
        $Senha = $_POST["Senha"];
        $mensagem = "";

        if(strlen($Senha)<8){
             $mensagem = '<div class="toast-container position-fixed bottom-0 end-0 p-3">
                <div id="liveToast" class="toast align-items-center  border-0" role="alert" aria-live="assertive" aria-atomic="true">
                    <div class="d-flex">
                      <div class="toast-body">
                      Senha deve ter no mínimo 8 caracteres
                      </div>
                      <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                    </div>
                  </div>
              </div>';
          }
          else{
        

        try {
            include("conexaoBD.php");
            
            $stmt = $pdo->prepare("select * from Connect_Empresa where CNPJ = :CNPJ");
            $stmt->bindParam(':CNPJ', $CNPJ);
            $stmt->execute();

            $rows = $stmt->rowCount();

            if ($rows <= 0) {
            $stmt = $pdo->prepare("INSERT INTO Connect_Empresa (CNPJ, Nome, Rua, Numero, Bairro, Complemento, Cidade, Estado, CEP, Email, Telefone, Ramo, Descricao, Senha) VALUES (:CNPJ, :Nome, :Rua, :Numero, :Bairro, :Complemento, :Cidade, :Estado, :CEP, :Email, :Telefone, :Ramo, :Descricao, :Senha)");
            
            $stmt->bindParam(':CNPJ', $CNPJ);
            $stmt->bindParam(':Nome', $Nome);
            $stmt->bindParam(':Rua', $Rua);
            $stmt->bindParam(':Numero', $Numero);
            $stmt->bindParam(':Bairro', $Bairro);
            $stmt->bindParam(':Complemento', $Complemento);
            $stmt->bindParam(':Cidade', $Cidade);
            $stmt->bindParam(':Estado', $Estado);
            $stmt->bindParam(':CEP', $CEP);
            $stmt->bindParam(':Email', $Email);
            $stmt->bindParam(':Telefone', $Telefone);
            $stmt->bindParam(':Ramo', $Ramo);
            $stmt->bindParam(':Descricao', $Descricao);
            $stmt->bindParam(':Senha', $Senha);

            $stmt->execute();
            header('Location: login.php');
            exit();
            }else{
            $texto = '<div class="toast-container position-fixed bottom-0 end-0 p-3">
                <div id="liveToast" class="toast align-items-center  border-0" role="alert" aria-live="assertive" aria-atomic="true">
                    <div class="d-flex">
                      <div class="toast-body">
                      CNPJ já cadastrado!
                      </div>
                      <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                    </div>
                  </div>
              </div>';


          }
        } catch (PDOExCEPtion $e) {
          
          echo 'Error: ' . $e->getMessage();
           
        }
        $pdo = null;
    }}

?>


<!--container do Empresa-->

  <br><br>
  <div class="container md-3">
  <div class="row" style="color:white;">
   <h6 class="display-6 "><b>Cadastro<a class="estConne"> -</a> Empresa</b></h6>
  <p class="lead">Cadastre a sua empresa no Estágio Connect </p>

  <div>
    <div class="col-12" ><hr class="estConne" style="color:white;"></div>    
  </div>
</div>
</div>

<div class="container containerCad boxInfo">

<form class="needs-validation" novalidate method="POST">
<br>

  <div class="row">
    <div class="col-sm-12 mb-3">
      <label class="form-label">CNPJ: </label><br>
      <input type="text" name="CNPJ" id="cnpj" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
  </div>

  <div class="row">
    <div class="col-sm-12 mb-3">
      <label class="form-label">Nome: </label><br>
      <input type="text" name="Nome" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
  </div>

  <br>
    
    <div class="row">
    <div class="col-md-5 col-sm-12 mb-3">
      <label class="form-label">Rua:</label>
      <input type="text" name="Rua" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

     <div class="col-md-1 col-sm-12 mb-3">
      <label class="form-label">Número:</label>
      <input type="text" name="Numero" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

    <div class="col-md-4 col-sm-12 mb-3">
      <label class="form-label">Bairro:</label>
      <input type="text" name="Bairro" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

   
 
 
    <div class="col-md-2 col-sm-12 mb-3">
        <label class="form-label">Complemento:</label>
        <input type="text" name="Complemento" class="form-control" required>
        <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
  </div>

  <div class="row">
    <div class="col-md-6 col-sm-12 mb-3">
      <label class="form-label">Cidade:</label>
      <input type="text" name="Cidade" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Estado:</label>
      <select class="form-select" name="Estado" required>
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
        <input type="text" name="CEP" id="cep" class="form-control" required>
        <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
  </div>
  <br>

  <div class="row">
  <div class="col-md-6 col-sm-12 mb-3">
      <label class="form-label">Email de Contato: </label>
      <input type="Email" name="Email"  class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Telefone de Contato: </label>
      <input type="tel" name="Telefone" id="tel" class="form-control">
    </div>
    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Ramo de Atividade: </label>
      <input type="text" name="Ramo" class="form-control" required>
    </div>

  </div>
  <br>

  <div class="row">

        <div class="col-md-12 col-sm-12 mb-3">
        <label class="form-label">Descrição:</label>
        <input type="text" name="Descricao" class="form-control">
      
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
      <label class="form-label">Confirmar Senha: </label><br>
      <input type="password"  name="Senha" class="form-control" id="confirm_password" required>
      <div class="invalid-feedback">
        Campo inválido ou Senha não corresponde.
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

        <button type="reset" class="btn btn-info btncolor" id="liveToastBtn" onclick="exibirToast();">
          <i class="bi bi-x-circle"></i> Limpar
        </button>

        <?php
              echo $texto;
              echo $mensagem;
              echo exibirToast();
       ?>

          <!--toast limpar inicio-->
          <?php
          function exibirToast() {
          return
          '<div class="toast-container position-fixed bottom-0 end-0 p-3">
                  <div id="liveToasta" class="toast align-items-center  border-0" role="alert" aria-live="assertive" aria-atomic="true">
                      <div class="d-flex">
                        <div class="toast-body">
                              
                                      Formulário limpo com sucesso!
                                      </div>
                                      <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                                    </div>
                                  </div>
                             </div>
                        
                        </div>
                        <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>';}?>

                        <?php if (($texto != "") || ($mensagem != "")){
                          echo "<script>
                          document.addEventListener('DOMContentLoaded', function () {
                              var toastElement = document.querySelector('.toast');
                              if (toastElement) {
                                  var myToast = new bootstrap.Toast(toastElement);
                                  myToast.show();
                              }
                          });</script>";

                          
                          
                        }

                        ?>
                        
                      </div>
                    </div>
                </div>
              

          <!--toast limpar fim-->
      </div>
    </div>
    <script>
function exibirToast() {
    var toastElement = document.getElementById('liveToasta');
    if (toastElement) {
        var myToast = new bootstrap.Toast(toastElement);
        myToast.show();
    }
}
</script>
<!--botao envio fim-->
</div>
</form>
</div>
<script>
    function validaCPF(cnpj) {
      cnpj = cnpj.replace(/\D+/g, '');
      if (cnpj.length !== 14) return false;

      else
      return true;
    }

    document.addEventListener('DOMContentLoaded', function() {
      document.getElementById('Form').addEventListener('submit', function(e) {
        var cpf = document.getElementById('cnpj').value;
        if (!validaCPF(cnpj)) {
          e.preventDefault();
          alert('CNPJ inválido, mínimo 14 caracteres.');
          document.getElementById('cnpj').focus();
        }
      });});

    document.getElementById('cnpj').addEventListener('input', function(e) {
      var value = e.target.value;
      var cnpjPattern = value.replace(/\D/g, '') 
                .replace(/(\d{2})(\d)/, '$1.$2') 
                .replace(/(\d{3})(\d)/, '$1.$2') 
                .replace(/(\d{3})(\d)/, '$1/$2') 
                .replace(/(\d{4})(\d)/, '$1-$2') 
                .replace(/(-\d{2})\d+?$/, '$1'); // Impede entrada de mais de 11 dígitos
      e.target.value = cnpjPattern;
    });
    </script>
    <script>

    function validaCEP(cep) {
      cep = cep.replace(/\D+/g, '');
      if (cep.length !== 8) return false;

      else
      return true;
    }

    document.addEventListener('DOMContentLoaded', function() {
      document.getElementById('Form').addEventListener('submit', function(e) {
        var cep = document.getElementById('cep').value;
        if (!validaCEP(cep)) {
          e.preventDefault();
          alert('CEP inválido, mínimo 8 caracteres.');
          document.getElementById('cep').focus();
        }
      });});

    document.getElementById('cep').addEventListener('input', function(e) {
      var value = e.target.value;
      var cepPattern = value.replace(/\D/g, '') // Remove qualquer coisa que não seja número
                .replace(/(\d{5})(\d)/, '$1-$2') 
                .replace(/(-\d{3})\d+?$/, '$1'); 
      e.target.value = cepPattern;
    });
</script>
    <script>

    function validaTel(tel) {
      tel = tel.replace(/\D+/g, '');
      tel = tel.replace(/ +/g, '');
      if ((tel.length !== 10) && (tel.length !==0)) return false;

      else
      return true;
    }

    document.addEventListener('DOMContentLoaded', function() {
      document.getElementById('Form').addEventListener('submit', function(e) {
        var tel = document.getElementById('tel').value;
        if (!validaTel(tel)) {
          e.preventDefault();
          alert('Telefone inválido.');
          document.getElementById('tel').focus();
        }
      });});

    document.getElementById('tel').addEventListener('input', function(e) {
      var value = e.target.value;
      var telPattern = value.replace(/\D/g, '') // Remove qualquer coisa que não seja número
                .replace(/(\d{1})(\d)/, '($1$2')
                .replace(/(\d{2})(\d)/, '$1) $2') 
                .replace(/(\d{4})(\d)/, '$1-$2') 
                .replace(/(-\d{4})\d+?$/, '$1'); 
      e.target.value = telPattern;
    });
</script>



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