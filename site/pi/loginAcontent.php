<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">

	<link rel="stylesheet" href="style1.css">
  <link rel="icon" href="favicon.ico">
	<title></title>
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
      margin-bottom: 20%;
     }
     .card{
        border-bottom-left-radius:5px ;
        border-bottom-right-radius:5px ;

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
  

<!--inicio navbar-->
<?php
  $tex="";
  
  /*if (isset($_SESSION["login"])) {
    if (isset($_SESSION["login"])=="11223344") {

     require('assets/navbarLogadoA.html');
  }else if (isset($_SESSION["login"])=="55667788") {
    require('assets/navbarLogadoB.html');
  }}
  else{
    
     require('assets/navbar.html');
  }*/




  
    include("conexaoBD.php");

    include('assets/qualnavbar.php');

    $CPF = $_SESSION["login"];
   
       
      $stmt = $pdo->prepare("select * from Connect_Aluno where CPF = :CPF");
      $stmt->bindParam(':CPF', $CPF);
      $stmt->execute();

   

      $quimica = "";
      $desenv = "";
      $arquitetura = "";
      $mecanica = "";
      $enfermagem = "";
      $qualidade = "";

      $estudando = "";
      $estudoC = "";
      $empregado = "";
      $empregadoE = "";

      $ano1 = "";
      $ano2 = "";
      $ano3 = "";
      $ano4 = "";

      $AC = "";
      $AL = "";
      $AP = "";
      $AM = "";
      $BA = "";
      $CE = "";
      $ES = "";
      $GO = "";
      $MA = "";
      $MT = "";
      $MS = "";
      $MG = "";
      $PA = "";
      $PB = "";
      $PR = "";
      $PE = "";
      $PI = "";
      $RJ = "";
      $RN = "";
      $RS = "";
      $RO = "";
      $RR = "";
      $SC = "";
      $SP = "";
      $SE = "";
      $TO = "";
      $DF = "";

      while($row = $stmt->fetch()){
        $Matricula = $row["Matricula"];
        $Nome = $row["Nome"];
        $Nascimento = $row["Nascimento"];
        $Rua = $row["Rua"];
        $Numero = $row["Numero"];
        $Bairro = $row["Bairro"];
        $Complemento = $row["Complemento"];
        $Cidade = $row["Cidade"];
        $Estado = $row["Estado"];
        $CEP = $row["CEP"];
        $Email = $row["Email"];
        $Telefone = $row["Telefone"];
        $Escola= $row["Escola"];
        $Status = $row["Status"];
        $Ano_Letivo = $row["Ano_Letivo"];
        $Descricao = $row["Descricao"];
        $Especialidade = $row["Especialidade"];
       


       if($row['Especialidade'] == "Química"){
            $quimica = "selected";
       }
        else if($row['Especialidade'] == "Desenvolvimento de Sistemas"){
            $desenv = "selected";
       }
       else if($row['Especialidade'] == "Arquitetura/Engenharia"){
            $arquitetura = "selected";
       }
       else if($row['Especialidade'] == "Mecânica Industrial"){
            $mecanica = "selected";
       }
       else if($row['Especialidade'] == "Enfermagem"){
            $enfermagem = "selected";
       }
       else if($row['Especialidade'] == "Qualidade de Produção"){
            $qualidade = "selected";
       }

        if($row['Status'] == "Estudando"){
            $estudando = "selected";
       }
        else if($row['Status'] == "Estudos Concluidos"){
            $estudoC = "selected";
       }
       else if($row['Status'] == "Empregado"){
            $empregado = "selected";
       }
       else if($row['Status'] == "Empregado e Estudando"){
            $empregadoE = "selected";
       }


        if($row['Ano_Letivo'] == "1"){
            $ano1 = "selected";
       }
        else if($row['Ano_Letivo'] == "2"){
            $ano2 = "selected";
       }
       else if($row['Ano_Letivo'] == "3"){
            $ano3 = "selected";
       }
       else if($row['Ano_Letivo'] == "4"){
            $ano4 = "selected";
       }


        if($row['Estado'] == "AC"){
            $AC = "selected";
       }
        else if($row['Estado'] == "AL"){
            $AL = "selected";
       }
       else if($row['Estado'] == "AP"){
            $AP = "selected";
       }
       else if($row['Estado'] == "AM"){
            $AM = "selected";
       }
        else if($row['Estado'] == "BA"){
            $BA = "selected";
       }
       else if($row['Estado'] == "CE"){
            $CE = "selected";
       }
       else if($row['Estado'] == "ES"){
            $ES = "selected";
       }
        else if($row['Estado'] == "GO"){
            $GO = "selected";
       }
       else if($row['Estado'] == "MA"){
            $MA = "selected";
       }
        else if($row['Estado'] == "MT"){
            $MT = "selected";
       }
       else if($row['Estado'] == "MS"){
            $MS = "selected";
       }
       else if($row['Estado'] == "MG"){
            $MG = "selected";
       }
        else if($row['Estado'] == "PA"){
            $PA = "selected";
       }
       else if($row['Estado'] == "PB"){
            $PB = "selected";
       }
       else if($row['Estado'] == "PR"){
            $PR = "selected";
       }
        else if($row['Estado'] == "PE"){
            $PE = "selected";
       }
       else if($row['Estado'] == "PI"){
            $PI = "selected";
       }
       else if($row['Estado'] == "RJ"){
            $RJ = "selected";
       }
        else if($row['Estado'] == "RN"){
            $RN = "selected";
       }
       else if($row['Estado'] == "RS"){
            $RS = "selected";
       }
       else if($row['Estado'] == "RO"){
            $RO = "selected";
       }
        else if($row['Estado'] == "RR"){
            $RR = "selected";
       }
       else if($row['Estado'] == "SC"){
            $SC = "selected";
       }
       else if($row['Estado'] == "SP"){
            $SP = "selected";
       }
        else if($row['Estado'] == "SE"){
            $SE = "selected";
       }
       else if($row['Estado'] == "TO"){
            $TO = "selected";
       }
       else if($row['Estado'] == "DF"){
            $DF = "selected";
       }
       else if($row['Estado'] == "AM"){
            $AM = "selected";
       }

         if (isset($_SESSION['mensagem'])) {
            $mensagem = $_SESSION['mensagem'];
        } else {
            $mensagem = ""; 
        }
              

     $tex = "<a href='deleta.php?login=" . $row['CPF'] . "' class='btn btn-info btncolor'>Excluir Perfil</a>";
      $nome = $row['Nome'];



}



?>
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
      <h3 class="display-4 "><b>Bem Vindo de Volta <?=$nome;?>!</b></h1>
      <p class="lead">Confira e edite seu perfil</p>
    </div>
  </div>

  <div>
    <div class="col-12"><hr class="estConne"></div>    
  </div>

</div>
<br>


<div class="container containerCad boxInfo">

<form class="needs-validation" action="updateAluno.php" novalidate method="POST" id="myForm" >
  
  

    <br>


  <div class="row">
    <div class="col-md-6 col-sm-12 mb-3">
      <label class="form-label">Nome Completo: </label><br>
      <input type="text" name="Nome" value="<?= $Nome ?>" class="form-control" required disabled>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

    
    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Matrícula: </label><br>
      <input type="text" name="Matricula" value="<?= $Matricula ?>" class="form-control" required disabled>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>



    <div class=" col-md-3 col-sm-12 mb-3">
      <label class="form-label"  >Data de Nascimento: </label><br>
      <input type="date" name="Nascimento" value="<?= $Nascimento ?>" class="form-control" id="data" required disabled>
      <div class="invalid-feedback">
        Campo obrigatório/o estudante deve ser maior de 15 anos.
      </div>
    </div>
  </div>

  <br>
    
    <div class="row">
    <div class="col-md-5 col-sm-12 mb-3">
      <label class="form-label">Rua:</label>
      <input type="text" name="Rua" value="<?= $Rua ?>" class="form-control" required disabled>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

     <div class="col-md-2 col-sm-12 mb-3">
      <label class="form-label">Número:</label>
      <input type="text" name="Numero" value="<?= $Numero ?>" class="form-control" required disabled>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Bairro:</label>
      <input type="text" name="Bairro" value="<?= $Bairro ?>" class="form-control" required disabled>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

   
 
 
    <div class="col-md-2 col-sm-12 mb-3">
        <label class="form-label">Complemento:</label>
        <input type="text" name="Complemento" value="<?= $Complemento ?>" class="form-control" disabled>
      
    </div>
  </div>

  <div class="row">
    <div class="col-md-6 col-sm-12 mb-3">
      <label class="form-label">Cidade:</label>
      <input type="text" name="Cidade" value="<?= $Cidade ?>" class="form-control" required disabled>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>

    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Estado:</label>
      <select class="form-select" name="Estado"  required disabled>
        <option></option>
        <option value="AC" <?= $AC ?>>AC</option>
        <option value="AL" <?= $AL ?>>AL</option>
        <option value="AP" <?= $AP ?>>AP</option>
        <option value="AM" <?= $AM ?>>AM</option>
        <option value="BA" <?= $BA ?>>BA</option>
        <option value="CE" <?= $CE ?>>CE</option>
        <option value="ES" <?= $ES ?>>ES</option>
        <option value="GO" <?= $GO ?>>GO</option>
        <option value="MA" <?= $MA ?>>MA</option>
        <option value="MT" <?= $MT ?>>MT</option>
        <option value="MS" <?= $MS ?>>MS</option>
        <option value="MG" <?= $MG ?>>MG</option>
        <option value="PA" <?= $PA ?>>PA</option>
        <option value="PB" <?= $PB ?>>PB</option>
        <option value="PR" <?= $PR ?>>PR</option>
        <option value="PE" <?= $PE ?>>PE</option>
        <option value="PI" <?= $PI ?>>PI</option>
        <option value="RJ" <?= $RJ ?>>RJ</option>
        <option value="RN" <?= $RN ?>>RN</option>
        <option value="RS" <?= $RS ?>>RS</option>
        <option value="RO" <?= $RO ?>>RO</option>
        <option value="RR" <?= $RR ?>>RR</option>
        <option value="SC" <?= $SC ?>>SC</option>
        <option value="SP" <?= $SP ?>>SP</option>
        <option value="SE" <?= $SE ?>>SE</option>
        <option value="TO" <?= $TO ?>>TO</option>
        <option value="DF" <?= $DF ?>>DF</option>
        <div class="invalid-feedback">
        Campo obrigatório.
      </div>
      </select>
    </div>
 
  
    <div class="col-md-3 col-sm-12 mb-3">
        <label class="form-label">CEP:</label>
        <input type="text" name="CEP" id="cep" value="<?= $CEP ?>" class="form-control" required disabled>
        <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
  </div>
  <br>

  <div class="row">
  <div class="col-md-6 col-sm-12 mb-3">
      <label class="form-label">Email de Contato: </label><br>
      <input type="Email"  name="Email" value="<?= $Email ?>" class="form-control" required disabled>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
    </div>
    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Telefone de Contato: </label>
      <input type="tel"  name="Telefone" value="<?= $Telefone ?>" id="tel" class="form-control" disabled>
    </div>

    <div class="col-md-3 col-sm-12 mb-3">
      <label class="form-label">Área de Especialização: </label>
      <select class="form-select" name="Especialidade" required disabled>
      <option></option>
        <option value="Química" <?= $quimica ?>>Química</option>
        <option value="Desenvolvimento de Sistemas" <?= $desenv ?>>Desenvolvimento de Sistemas</option>
        <option value="Arquitetura/Engenharia" <?= $arquitetura ?>>Arquitetura/Engenharia</option>
        <option value="Mecânica Industrial" <?= $mecanica ?>>Mecânica Industrial</option>
        <option value="Enfermagem" <?= $enfermagem ?>>Enfermagem</option>
        <option value="Qualidade de Produção" <?= $qualidade ?>>Qualidade de Produção</option>
      <div class="invalid-feedback">
        Campo obrigatório.
      </div>
      </select>
    </div>
  </div>

     <div class="row">

        <div class="col-md-6 col-sm-12 mb-3">
          <label class="form-label">Escola:</label>
          <input type="text" name="Escola" value="<?= $Escola ?>" class="form-control" required disabled>
          <div class="invalid-feedback">
            Campo obrigatório.
          </div>
        </div>


      <div class="col-md-4 col-sm-12 mb-3">
            <label class="form-label">Status: </label>
            <select class="form-select" name="Status" required disabled>
            <option></option>
              <option value="Estudando" <?= $estudando ?>>Estudando</option>
              <option value="Estudos Concluídos" <?= $estudoC ?>>Estudos Concluídos</option>
              <option value="Empregado" <?= $empregado ?>>Empregado</option>
              <option value="Empregado e Estudando" <?= $empregadoE ?>>Empregado e Estudando</option>
            <div class="invalid-feedback">
              Campo obrigatório.
            </div>
            </select>
          </div>

          <div class="col-md-2 col-sm-12 mb-3">
            <label class="form-label">Ano Letivo: </label>
            <select class="form-select" name="Ano_Letivo" required disabled>
            <option></option>
              <option value="1" <?= $ano1 ?>>1</option>
              <option value="2" <?= $ano2 ?>>2</option>
              <option value="3" <?= $ano3 ?>>3</option>
              <option value="4" <?= $ano4 ?>>4</option>
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
        <input type="text" name="Descricao" value="<?= $Descricao ?>" class="form-control" disabled>
      
        </div>
      </div>

<br>

  

<br>
    
<!--botao envio inicio-->
    <div class="row fimForm">
      <div class="col-12 ">
      
        <button type="button" id="editButton" class="btn btn-info btncolor" onclick="toggleEdit()">Editar</button>
        <button type="submit" id="saveButton" class="btn btn-success btncolor" style="display: none;">Salvar</button>
      
        <?php 
        echo $tex;
        echo $mensagem;
        ?>

    
        

       
      </div>
    </div>
<!--botao envio fim-->
</form>
</div>
</div>
                    <?php if (($mensagem != "")){
                          echo "<script>
                          document.addEventListener('DOMContentLoaded', function () {
                              var toastElement = document.querySelector('.toast');
                              if (toastElement) {
                                  var myToast = new bootstrap.Toast(toastElement);
                                  myToast.show();
                              }
                          });</script>";}
                      ?>



<!--fim container introducao-->

<br>

<!--inicio container-->

<div class="margemBaixo"></div>
<!--fim container-->
<br><br>

<?php
  require('assets/footer.html');
?>

<script type="text/javascript">
    function toggleEdit() {
        const form = document.getElementById('myForm');
        const inputs = form.querySelectorAll('input');
        const selector = form.querySelectorAll('select');
        const button = document.getElementById('editButton');

        if (button.innerText === 'Editar') {
            inputs.forEach(input => input.disabled = false);
            selector.forEach(select => select.disabled = false);
            button.style.display = 'none';  // Esconde o botão "Editar"
            saveButton.style.display = 'inline';  // Mostra o botão "Salvar"
        }
    }
</script>

<script>

    function validaCEP(cep) {
      cep = cep.replace(/\D+/g, '');
      if (cep.length !== 8) return false;

      else
      return true;
    }

    document.addEventListener('DOMContentLoaded', function() {
      document.getElementById('myForm').addEventListener('submit', function(e) {
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
      document.getElementById('myForm').addEventListener('submit', function(e) {
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
    
<!--<script type="text/javascript">
  function toggleEdit() {
    const form = document.getElementById('myForm');
    const inputs = form.querySelectorAll('input');
    const selector = form.querySelectorAll('select');
    const button = document.getElementById('editButton');

    if (button.innerText === 'Editar') {
        inputs.forEach(input => input.disabled = false);
        selector.forEach(select => select.disabled = false);
        button.innerText = 'Salvar';
    } else {
        inputs.forEach(input => input.disabled = true);
        selector.forEach(select => select.disabled = true);
        button.innerText = 'Editar';
       
    }
}
</script>-->



<!--inicio script-->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
<!--fim script-->

</body>
</html>