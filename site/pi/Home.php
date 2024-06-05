
 <?php session_start(); ?>
<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <link rel="icon" href="favicon.ico">
	<link rel="stylesheet" href="style1.css">
	<link
    rel="stylesheet"
    href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"/>

	<title>Home</title>
	<style type="text/css">
    body {
          background-image: url("img/backimage.png");
          background-size: cover;
          background-position: center;
       }
		  .box {
            display: flex;
            position: relative;
            align-items: center;
 
        }
        .boxC{
        	text-align: right;
        	display: flex;
            margin-top: 150px;
            position: relative;
            margin-left: 10%;
            margin-right: 10%;
        }

        .imgEs{
        	max-width: 40%;
        
        }
        .boxInfo{
            text-align: center;
            max-width: 95%;
            height: auto;
            margin: 0 auto;
            margin-top: 20px;
            padding-top: 30px;
            position: relative;
            background-color: white;
            border-radius: 15px;
            padding-bottom: 30px;
        }

        .boxBEstagio {
          
            background-image: url("img/backestagio.jpeg");
            background-size: cover;
            background-repeat: no-repeat;
            width: 90%;
            max-width: 90%;
            height: 500px;
            margin: 0 auto;
            margin-top: 20px;
            padding: 0 20px;
            position: relative;
            border-radius: 10px;
        }

       .texto1{
  
       	position: relative;
       	align-items: flex-end;

       }
       .texto2{
       	position: relative;
       	align-items: flex-end;
    		transform: translateY(100%) translateX(-5%);
    		z-index: 1;

       }


       .texto3{
        margin: 0 10%;
       }

       .textoCorAqua{
        color: #256660;
        text-decoration: none;
       }

       

       

        /*tela 2*/
        @media (max-width:1200px){
          
            .texto1{

              font-size: 20px;
            }

            .texto2{
              transform: translateY(30%) translateX(-5%);
              font-size: 20px;
            }

            .texto3{
              font-size: 20px;
            }


        .imgC{

          max-height: 400px;
        }
        .boxC{
              
                margin-top: 90px;
             
    
            }


            .boxBEstagio{
     
              height: 350px;

            }
        

        

       
        }


        /*tela 3*/
         @media (max-width:750px){
          
            
            .texto1{
              font-size: 16px;
            }
            .texto2{
              text-align: center;
              transform: translateY(0%) translateX(0%);
              font-size: 16px;
            }

            .texto3{
              font-size: 16px;

            }

            .boxBEstagio{
     
              height: 300px;

            }


            .imgC{
          max-width: 100%;
          max-height: 300px;

        }
      .boxC{
              
                margin-top: 40px;
              align-items: center;
    
            }
           .carousel{
            align-items: center;
            margin-left: 6%;
           }
            
          

        }
       
        
        .imgC{
     
        	border-radius: 20px;
 			    height: 460px;
  


        }

        


		div[class="carousel-inner"]
		{
			padding-left: 20%;
			padding-right: 35%;

		}

		img[class="d-block w-100"]
		{
			height: 400px;
		}

		

		div[class="carousel-indicators"]{
			margin-right: 40%;
		}

		button[class="carousel-control-prev"]
		{
			margin-left: 6%;
		}

		button[class="carousel-control-next"]
		{
			margin-right: 20%;
		}
		
    hr{

      margin-left: 10%;
      margin-right: 10%;

    }
    .titulo{
      margin-top: 10%;
    }





     
	</style>
</head>
<body>
<?php

  if (isset($_SESSION["login"])) {

     require('assets/navbarLogado.html');;
  }
  else{
    
     require('assets/navbar.html');
  }
?>

<!-- inicio container introdução-->
<br>
<div class="boxBEstagio">
<div class="container md-3">
  <div class="row">
    <div class="col-12 centralizaCont titulo" >
      <h3 class="display-1 animate__animated animate__fadeInDown"><b>Estági<a class="textoCorAqua">o</a> C<a class="textoCorAqua">o</a>nnect</b></h3>
      <!--<img src="img/estagio.png" class="animate__animated animate__fadeInDown imgTitulo"> <br>
      <img src="img/connect.png" class="animate__animated animate__fadeInUp imgTitulo">-->
      <p class="display-6 lead animate__animated animate__fadeIn">Conectando empresas e alunos</p>
    </div>
  </div>

    </div>
  <div>
  
  </div>

</div>

<!--fim container introducao-->




<!--inicio pag-->
<br><br>

  <div class="container">
    <div class=" box row boxInfo">
      <p class="texto "> <h4 class="texto1 col-md-7 col-sm-12">O nosso aplicativo é a chave para desbloquear o estágio dos seus sonhos - encontre-o, apaixone-se por ele e conquiste o seu futuro profissional com um simples deslize.</p></h4>
      <img class="container1 col-md-5 col-sm-12"src="img/pssMostra.png" height="400px" width="400px" >
</div>


<!--carrosel-->
<br><br>
  <div>
    <div class="col-12"><hr class="estConne" style="color: white;"></div>    
  </div>
<br>
<div class="boxC row boxInfo">
<div id="carouselExampleIndicators" class="carousel slide  col-sm-12 col-md-6 carousel-dark" data-bs-ride="carousel">
  <div class="carousel-indicators">
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="0" class="active" aria-current="true" aria-label="Slide 1"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="1" aria-label="Slide 2"></button>
    <button type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide-to="2" aria-label="Slide 3"></button>
  </div>
  <div class="carousel-inner">
    <div class="carousel-item active">
      <img src="img/telaInicioM.png" class="d-block w-100 imgC" alt="...">
    </div>
    <div class="carousel-item">
      <img src="img/telaCadAluM.png" class="d-block w-100 imgC " alt="...">
    </div>
    <div class="carousel-item">
      <img src="img/telaHomeM.png" class="d-block w-100 imgC" alt="...">
    </div>
  </div>
  <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="prev">
    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Previous</span>
  </button>
  <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleIndicators" data-bs-slide="next">
    <span class="carousel-control-next-icon" aria-hidden="true"></span>
    <span class="visually-hidden">Next</span>
  </button>
</div>





<div class="col-md-6 col-sm-12">
	<p><br><br> <h4 class="texto2">	Fácil, prático e acessível. Com uma interface amigável e funcionalidades úteis que torna a busca de estágio mais completa para os usuários.</p></h4>
</div>
<br><br>
<!--fim carrosel-->
</div>

<br><br>
  <div>
    <div class="col-12"><hr class="estConne" style="color: white;"></div>    
  </div>
<br>

<div class="centralizaCont boxInfo">
<img class="imgEs"src="img/estagioconnect2.png">
<p><br><br> <h4 class="texto3">Acreditamos no poder da conexão. Alunos e empresas podem alcançar grandes conquistas quando trabalham juntos. Seja você um estudante buscando oportunidades para crescer ou uma empresa em busca de novos talentos, nossa plataforma oferece o ambiente ideal para você realizar seus objetivos.</p></h4>
</div>
</div>

<!--fim pag-->

<?php
  require('assets/footer.html');
?>

<!--inicio script-->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
<!--fim script-->


</body>
</html>