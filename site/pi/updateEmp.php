<?php

          include("conexaoBD.php");
          session_start();

          $CNPJ = $_SESSION["login"];

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
          $_SESSION['mensagem'] = "";


         

          
          try{
              $stmt = $pdo->prepare("update Connect_Empresa set Nome= :Nome, Rua = :Rua, Numero = :Numero, Bairro = :Bairro, Complemento = :Complemento, Cidade = :Cidade, Estado = :Estado, CEP = :CEP, Email = :Email, Telefone = :Telefone, Ramo = :Ramo, Descricao = :Descricao where CNPJ = :CNPJ");

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
            $stmt->execute();



            
          }
          catch(PDOException $e){
              echo "Error: " . $e->getMessage();
          }
        

          $pdo = null;

         header("Location: loginB.php");
          exit();


?>