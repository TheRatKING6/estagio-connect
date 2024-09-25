<?php

$login = "";
if (isset($_SESSION["login"])) {
$login = $_SESSION["login"];

try {
            include("conexaoBD.php");
            
            $stmt = $pdo->prepare("select * from Connect_Aluno where CPF = :login");
            $stmt->bindParam(':login', $login);
            $stmt->execute();

            $rows = $stmt->rowCount();

            if ($rows == 1 ) {
              require('assets/navbarLogadoA.html');
            }
              else{
            
                  $stmt = $pdo->prepare("select * from Connect_Empresa where CNPJ = :login");
                  $stmt->bindParam(':login', $login);
                  $stmt->execute();

                  $rows = $stmt->rowCount();

                  if ($rows == 1) {
                    require('assets/navbarLogadoB.html');
              }

             
          }}catch (PDOException $e) {
          
          echo 'Error: ' . $e->getMessage();
           
        }
        } else{
		       	 require('assets/navbar.html');
		       }
       
?>