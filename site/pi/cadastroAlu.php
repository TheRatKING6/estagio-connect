<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-4bw+/aepP/YC94hEpVNVgiZdgIC5+VKNBQNGCHeKRQN+PtmoHDEXuppvnDJzQIu9" crossorigin="Ano_Letivonymous">
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
 
  

  
    include('assets/qualnavbar.php');


  

    if ($_SERVER["REQUEST_METHOD"] === 'GET'){
        $texto = "";
        $CPF = "";
        $Matricula = "";
        $Nome = "";
        $Nascimento = "";
        $Rua = "";
        $Numero = "";
        $Bairro = "";
        $Complemento = "";
        $Cidade = "";
        $Estado = "";
        $CEP = "";
        $Email = "";
        $Telefone = "";
        $Especialidade = "";
        $Escola= "";
        $Status = "";
        $Ano_Letivo = "";
        $Descricao = "";
        $Senha = "";
        $mensagem = "";

    }

    if ($_SERVER["REQUEST_METHOD"] === 'POST'){
        $texto = "";
        $CPF = $_POST["CPF"];
        $Matricula = $_POST["Matricula"];
        $Nome = $_POST["Nome"];
        $Nascimento = $_POST["Nascimento"];
        $Rua = $_POST["Rua"];
        $Numero = $_POST["Numero"];
        $Bairro = $_POST["Bairro"];
        $Complemento = $_POST["Complemento"];
        $Cidade = $_POST["Cidade"];
        $Estado = $_POST["Estado"];
        $CEP = $_POST["CEP"];
        $Email = $_POST["Email"];
        $Telefone = $_POST['Telefone'];
        $Especialidade = $_POST["Especialidade"];
        $Escola = $_POST["Escola"];
        $Status = $_POST["Status"];
        $Ano_Letivo = $_POST["Ano_Letivo"];
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
           
          $nasc = new DateTime($Nascimento);
          $hoje = new DateTime(); // Data atual

          $idade = $hoje->diff($nasc)->y; 

          

          
              
        
          if ($idade < 15) {
              $mensagem = '<div class="toast-container position-fixed bottom-0 end-0 p-3">
                <div id="liveToast" class="toast align-items-center  border-0" role="alert" aria-live="assertive" aria-atomic="true">
                    <div class="d-flex">
                      <div class="toast-body">
                      O usuário deve ser maior que 15 anos
                      </div>
                      <button type="button" class="btn-close btn-close-white me-2 m-auto" data-bs-dismiss="toast" aria-label="Close"></button>
                    </div>
                  </div>
              </div>';
          
              
          }


          else{
          
       
        

        try {
            include("conexaoBD.php");
            
            $stmt = $pdo->prepare("select * from Connect_Aluno where CPF = :CPF");
            $stmt->bindParam(':CPF', $CPF);
            $stmt->execute();

            $rows = $stmt->rowCount();

            if ($rows <= 0) {
            $stmt = $pdo->prepare("INSERT INTO Connect_Aluno (CPF, Matricula, Nome, Nascimento, Rua, Numero, Bairro, Complemento, Cidade, Estado, CEP, Email, Telefone, Especialidade, Escola, Status, Ano_Letivo, Descricao, Senha) VALUES (:CPF, :Matricula, :Nome, :Nascimento, :Rua, :Numero, :Bairro, :Complemento, :Cidade, :Estado, :CEP, :Email, :Telefone, :Especialidade, :Escola, :Status, :Ano_Letivo, :Descricao, :Senha)");
            
            $stmt->bindParam(':CPF', $CPF);
            $stmt->bindParam(':Matricula', $Matricula);
            $stmt->bindParam(':Nome', $Nome);
            $stmt->bindParam(':Nascimento', $Nascimento);
            $stmt->bindParam(':Rua', $Rua);
            $stmt->bindParam(':Numero', $Numero);
            $stmt->bindParam(':Bairro', $Bairro);
            $stmt->bindParam(':Complemento', $Complemento);
            $stmt->bindParam(':Cidade', $Cidade);
            $stmt->bindParam(':Estado', $Estado);
            $stmt->bindParam(':CEP', $CEP);
            $stmt->bindParam(':Email', $Email);
            $stmt->bindParam(':Telefone', $Telefone);
            $stmt->bindParam(':Especialidade', $Especialidade);
            $stmt->bindParam(':Escola', $Escola);
            $stmt->bindParam(':Status', $Status);
            $stmt->bindParam(':Ano_Letivo', $Ano_Letivo);
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
                      CPF já cadastrado/inválido!
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

<form class="needs-validation" novalidate method="POST" id="Form">
  <br>
  <div class="row">
      <div class="col-md-12 col-sm-12 mb-3">
        <label class="form-label">CPF: </label><br>
        <input type="text" name="CPF" id="cpf" class="form-control" required>
        <div class="invalid-feedback">
          Campo obrigatório.
        </div>
      </div></div>

    <br>


  <div class="row">
    <div class="col-md-6 col-sm-12 mb-3">
      <label class="form-label">Nome Completo: </label><br>
      <input type="text" name="Nome" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

    
    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Matrícula: </label><br>
      <input type="text" name="Matricula" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>



    <div class=" col-md-3 col-sm-12 mb-3">
      <label class="form-label"  >Data de Nascimento: </label><br>
      <input type="date" name="Nascimento" class="form-control" id="data" required >
      <div class="invalid-feedback">
        Campo obrigatório/o estudante deve ser maior de 15 anos.
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

     <div class="col-md-2 col-sm-12 mb-3">
      <label class="form-label">Número:</label>
      <input type="text" name="Numero" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Bairro:</label>
      <input type="text" name="Bairro" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

   
 
 
    <div class="col-md-2 col-sm-12 mb-3">
        <label class="form-label">Complemento:</label>
        <input type="text" name="Complemento" class="form-control">
      
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
      <label class="form-label">Email de Contato: </label><br>
      <input type="Email"  name="Email" class="form-control" required>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Telefone de Contato: </label>
      <input type="tel"  name="Telefone" id="tel" class="form-control">
    </div>

    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Área de Especialização: </label>
      <select class="form-select" name="Especialidade" required>
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
          <input type="text" name="Escola" class="form-control" required>
          <div class="invalid-feedback">
            Campo obrigatório.
          </div>
        </div>


      <div class="col-md-4 col-sm-12 mb-3">
            <label class="form-label">Status: </label>
            <select class="form-select" name="Status" required>
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
            <select class="form-select" name="Ano_Letivo" required>
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
      <input type="password" name="Senha" class="form-control" id="confirm_password" required>
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
                          });</script>";}
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
</form>
</div>
      
   <script>
     


    function validaCPF(cpf) {
      cpf = cpf.replace(/\D+/g, '');
      if (cpf.length !== 11) return false;

      else
      return true;
    }

    document.addEventListener('DOMContentLoaded', function() {
      document.getElementById('Form').addEventListener('submit', function(e) {
        var cpf = document.getElementById('cpf').value;
        if (!validaCPF(cpf)) {
          e.preventDefault();
          alert('CPF inválido, mínimo 11 caracteres.');
          document.getElementById('cpf').focus();
        }
      });});

    document.getElementById('cpf').addEventListener('input', function(e) {
      var value = e.target.value;
      var cpfPattern = value.replace(/\D/g, '') // Remove qualquer coisa que não seja número
                .replace(/(\d{3})(\d)/, '$1.$2') // Adiciona ponto após o terceiro dígito
                .replace(/(\d{3})(\d)/, '$1.$2') // Adiciona ponto após o sexto dígito
                .replace(/(\d{3})(\d)/, '$1-$2') // Adiciona traço após o nono dígito
                .replace(/(-\d{2})\d+?$/, '$1'); // Impede entrada de mais de 11 dígitos
      e.target.value = cpfPattern;
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
  

  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.1/dist/js/bootstrap.bundle.min.js" integrity="sha384-HwwvtgBNo3bZJJLYd8oVXjrBZt8cqVSpeBNS5n7C8IVInixGAoxmnlMuBnhbgrkm" crossorigin="Ano_Letivonymous"></script>

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