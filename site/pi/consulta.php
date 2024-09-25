<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
	<link rel="stylesheet" href="style1.css">
  <link rel="icon" href="favicon.ico">
	<title>Download</title>

  <style type="text/css">
    
    body{
     
          background-image: url("img/backimage.png");
          background-size: cover;
          background-position: center;

        }
      button{
        margin-bottom: 20px;
      }

      .boxInfo{
            text-align: center;
            height: auto;
            margin: 0 auto;
            margin-top: 20px;
            padding-top: 30px;
            position: relative;
            background-color: white;
            border-radius: 15px;
            padding-bottom: 30px;
            max-width: 60%;
        }
        .imgAparelho{
          height: 200px;
          width: 200px;
        }
        .styled-table {
          border-collapse: collapse;
          margin: auto;
          background-color: white;
          font-size: 0.9em;
          font-family: sans-serif;
          min-width: 500px;
          box-shadow: 0 0 20px rgba(0, 0, 0, 0.15);
          border-radius: 10px;
          overflow: hidden;
      }
      .styled-table thead tr {
          background-color: #009879;
          color: #ffffff;
          text-align: left;
      }
      .styled-table th,
      .styled-table td {
          padding: 12px 15px;
      }
      .styled-table tbody tr {
          border-bottom: 1px solid #dddddd;
      }

      .styled-table tbody tr:nth-of-type(even) {
          background-color: #f3f3f3;
      }

      .styled-table tbody tr:last-of-type {
          border-bottom: 2px solid #009879;
      }
        


  </style>
</head>
<body>
<?php
  session_start();
  
  
    include('assets/qualnavbar.php');
?>


          <!-- inicio container introdução-->
          <br>
          <div class="container md-3">
            <div class="row">
              <div class="col-12 centralizaCont"  style="color: white;">
                <h3 class="display-4 "><b>C<a class="estConne">o</a>nsulta</b></h3>
                <p class="lead"> Veja as empresas inscritas no Estágio Connect</p>
              </div>
            </div>

            <div>
              <div class="col-12"><hr class="estConne" ></div>    
            </div>


          </div>

          <!--fim container introducao-->

          <br>
          <!--inicio Pag-->

          <form method="post" style="text-align:center;">
    <b style="color: white;">Nome da empresa:</b><br>
    <input type="text" size="30" name="nome" style="border-radius: 10px;"><br><br>
    <input type="submit" class="btn btn-info btncolor" name="Consultar">
  </form>

  <hr>

</body>
</html>

<?php 
  if ($_SERVER["REQUEST_METHOD"] === 'POST') {
    include("conexaoBD.php");

    if (isset($_POST["nome"]) && ($_POST["nome"] != "")) {
      
      $nome = '%' . $_POST["nome"] . '%';

      

      $stmt = $pdo->prepare("select * from Connect_Empresa where Nome like :nome");
      $stmt->bindParam(':nome', $nome);
    
    } else{
      
      $stmt = $pdo->prepare("select * from Connect_Empresa order by Nome");
    }
    try{
      //buscando dados
      $stmt->execute();

      echo "<table border='2px' cellspacing='1'  class='styled-table'>";
      echo "<thead>";
      echo "<tr>";
      echo "<th>Nome</th>";
      echo "<th>Ramo</th>";
      echo "</tr>";
      echo "</thead>";
      //buscando dados
      $stmt->execute();
      echo "<tbody>";
      while($row = $stmt->fetch()){
        echo "<tr>";
        echo "<td>" . $row['Nome'] . "</td>";
        echo "<td>" . $row['Ramo'] . "</td>";
        echo "</tr>";
      }
      echo "</tbody>";


      echo "</table>";
    
    } catch (PDOException $e){
      echo 'Error: ' . $e->getMessage();
    }

    $pdo = null;
  }//fechamento do if do post

?>
               

          <!--fim pag-->

          <?php
             require('assets/footer.html');
          ?>


<!--inicio script-->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
<!--fim script-->

<script type="text/javascript">
  
  const tooltipTriggerList = document.querySelectorAll('[data-bs-toggle="tooltip"]')
const tooltipList = [...tooltipTriggerList].map(tooltipTriggerEl => new bootstrap.Tooltip(tooltipTriggerEl))
</script>
</body>
</html>