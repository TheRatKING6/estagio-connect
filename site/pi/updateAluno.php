 <?php

          include("conexaoBD.php");
          session_start();

          $CPF = $_SESSION["login"];

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
          $_SESSION['mensagem'] = "";


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
              
              $_SESSION['mensagem'] = $mensagem;
              
          }
          
          if($_SESSION['mensagem'] == ""){

          try{
              $stmt = $pdo->prepare("update Connect_Aluno set Nome= :Nome, Matricula = :Matricula, Nascimento = :Nascimento, Rua = :Rua, Numero = :Numero, Bairro = :Bairro, Complemento = :Complemento, Cidade = :Cidade, Estado = :Estado, CEP = :CEP, Email = :Email, Telefone = :Telefone, Especialidade = :Especialidade, Escola = :Escola, Status = :Status, Ano_Letivo = :Ano_Letivo, Descricao = :Descricao where CPF = :CPF");

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
            $stmt->execute();



            
          }
          catch(PDOException $e){
              echo "Error: " . $e->getMessage();
          }
        }

          $pdo = null;

          header("Location: loginA.php");
          exit();

?>