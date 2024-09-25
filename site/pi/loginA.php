<?php
	session_start();
?>

	<!DOCTYPE html>
	<html>
		<head>
			<meta charset="utf-8">
			<meta name="viewport" content="width=device-width, initial-scale=1">
			<link rel="icon" href="favicon.ico">
			<title>Aluno</title>
		</head>
		<body>

			<?php
			if (!isset($_SESSION["login"])) {

				header('Location: erro.php');
				
				
			} else{
				include("loginAcontent.php");
			}
		
?>

</body>
</html>