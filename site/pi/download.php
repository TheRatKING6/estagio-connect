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
                <h3 class="display-4 "><b>D<a class="estConne">o</a>wnl<a class="estConne">o</a>ad</b></h3>
                <p class="lead">Baixe agora nosso aplicativo </p>
              </div>
            </div>

            <div>
              <div class="col-12"><hr class="estConne" ></div>    
            </div>


          </div>

          <!--fim container introducao-->

          <br>
          <!--inicio Pag-->
                 <div class="container ">
          <div class="row">
            <div class="col-md-6">
              <div class="boxInfo">
              <div class="centralizaCont">
                <h3 class="estConne">Desktop</h3>
                <div>
                  <img src="img/pc.png" class="imgAparelho"><br>
                  <button type="button" class="btn btn-info" data-bs-toggle="tooltip" data-bs-placement="top" data-bs-title="Windows e macOS">Download</button>
                </div>
              </div>
            </div>
            </div>



            <div class="col-md-6">
              <div class="boxInfo">
              <div class="centralizaCont">
                <h3 class="estConne">Mobile</h3>
                <div>
                  <img src="img/celular.png" class="imgAparelho"><br>
                  <button type="button" class="btn btn-info" data-bs-toggle="tooltip" data-bs-placement="top" data-bs-title="iOS e Android">Download</button>
                </div>
              </div>
            </div>
            </div>
          </div>
        </div>

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