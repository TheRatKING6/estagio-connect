<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<title></title>
</head>
<body>
	<a href="login.php">Home</a>

	<hr>

</body>
</html>
<?php 

		$login = "";
		

			$login = $_GET["login"];

		try {
            include("conexaoBD.php");
            
            $stmt = $pdo->prepare("select * from Connect_Aluno where CPF = :login");
            $stmt->bindParam(':login', $login);
            $stmt->execute();

            $rows = $stmt->rowCount();

            if ($rows == 1 ) {
              	$stmt = $pdo->prepare("delete from Connect_Aluno where CPF = :login");
	            $stmt->bindParam(':login', $login);
	            $stmt->execute();
	            header("Location: logout.php");
            }
              else{
            
                  $stmt = $pdo->prepare("select * from Connect_Empresa where CNPJ = :login");
                  $stmt->bindParam(':login', $login);
                  $stmt->execute();

                  $rows = $stmt->rowCount();

                  if ($rows == 1) {
                    	$stmt = $pdo->prepare("delete from Connect_Empresa where CNPJ = :login");
			            $stmt->bindParam(':login', $login);
			            $stmt->execute();
			            header("Location: logout.php");
              }


             
          }
          	
      }catch (PDOException $e) {
          
          echo 'Error: ' . $e->getMessage();
           
        }
        
 ?>