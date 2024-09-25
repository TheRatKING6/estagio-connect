<!DOCTYPE html>
<html>
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
	<link rel="stylesheet" href="style1.css">
  <link rel="icon" href="favicon.ico">
	<title>Tutorial</title>

<style type="text/css">
   body {
          background-image: url("img/backimage.png");
          background-size: cover;
          background-position: center;
       }
  .accordion-body{
    text-align: center;
    position: relative;
  }

  .accordion{
    width: 80%;
    margin: auto;
    position: relative;
    align-items: center;
  }

  .linkcolor{
    color:darkcyan;
  }

  ul{
    text-align: left;
  }

  .card{
	margin-top: 400px;
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
    <div class="col-12 centralizaCont" style="color: white;">
      <h3 class="display-4 "><b>Tut<a class="estConne">o</a>rial</b></h3>
      <p class="lead">Um passo a passo para não se perder</p>
    </div>
  </div>

  <div>
    <div class="col-12"><hr class="estConne"></div>    
  </div>

</div>

<!--fim container introducao-->
<br>

<!--inicio tutorial-->

<!--inicio accordion-->
<div class="accordion" id="accordionExample">
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
        Como Baixar?
      </button>
    </h2>
    <div id="collapseOne" class="accordion-collapse collapse show" data-bs-parent="#accordionExample">
      <div class="accordion-body">
        Vá para página de <a href="download.html" class="linkcolor">download</a> e baixe o aplicativo.
        <br><br>


      </div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="false" aria-controls="collapseTwo">
        Entrando no Aplicativo
      </button>
    </h2>
    <div id="collapseTwo" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
      <div class="accordion-body">
       Ao entrar no aplicativo você poderá logar na sua conta caso já possua. Caso não possua, você poderá cadastrar-se ao clicar em "ainda não possuo uma conta" ou em nosso próprio site na aba de <a data-bs-toggle="modal" data-bs-target="#Modal" class="linkcolor">cadastro</a>.
       <br><br>
       Em caso de criar uma nova conta, você deverá escolher sua conta como <b>Aluno</b> ou <b>Empresa</b>

       <br>

       Preencha com as informações necessárias. Após o preenchimento bem-sucedido, tanto alunos quanto empresas podem explorar oportunidades em potencial dentro do sistema do Estágio Connect.
      </div>
    </div>
  </div>
  <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseThree" aria-expanded="false" aria-controls="collapseThree">
        Como o sistema de "Matching" funciona?
      </button>
    </h2>
    <div id="collapseThree" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
      <div class="accordion-body">
        O nosso sistema de "matching" permite que alunos e empresas se conectem de forma prática e fácil a partir de informações que foram fornecidas pelo usuário. Ele coleta e organiza todas as informações, criando uma base de dados abrangente com os detalhes de todas as empresas e estudantes registrados.<br><br>
        O núcleo do sistema é um algoritmo de "matching" sofisticado, que compara os perfis das empresas com os dos estudantes. O algoritmo leva em consideração vários critérios para determinar a compatibilidade, incluindo:
        <ul><br>
          <li>Habilidades e qualificações dos estudantes em relação às necessidades das empresas.</li>
          <li>Localização geográfica, permitindo que empresas encontrem estudantes em uma área específica.</li>
          <li>Preferências pessoais, como cultura da empresa e objetivos de carreira.</li>
        </ul>

        <br>

        O sistema de "matching" do Estágio Connect visa simplificar o processo de busca por estágios, economizando tempo e energia para empresas e estudantes. Ele faz isso ao automatizar a análise e a comparação de informações, permitindo que ambas as partes encontrem as correspondências mais adequadas para suas necessidades e objetivos. No geral, esse sistema otimiza o processo de conexão entre empresas e estudantes, criando oportunidades significativas para ambas as partes.

       
      </div>

    </div>
  </div>
    <div class="accordion-item">
    <h2 class="accordion-header">
      <button class="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseFour" aria-expanded="false" aria-controls="collapseFour">
        Seu perfil
      </button>
    </h2>
    <div id="collapseFour" class="accordion-collapse collapse" data-bs-parent="#accordionExample">
      <div class="accordion-body">
       O perfil do usuário dentro do Estágio Connect é a base de todas as operações do sistema de "matching". Os estudantes e empresas fornecem informações detalhadas ao criar seus perfis, e essas informações são essenciais para identificar as correspondências ideais.<br><br>

      Dentro do perfil, os interessados podem acessar e visualizar as informações do usuário, proporcionando uma visão abrangente de suas qualificações, interesses e objetivos. Por sua vez, o próprio usuário tem a capacidade de editar essas informações, garantindo que seu perfil esteja sempre atualizado e refletindo suas aspirações profissionais em constante evolução.<br><br>

      Com a base de perfis bem construída, o Estágio Connect se torna uma ferramenta eficaz para conectar estudantes talentosos a oportunidades de estágio relevantes, ao mesmo tempo em que permite que as empresas encontrem os candidatos mais adequados para suas necessidades. O perfil do usuário é o ponto de partida para uma experiência de busca de estágio personalizada e eficaz.
      </div>
    </div>
  </div>
</div>

<!--fim accordion-->
<br><br>

<?php
  require('assets/footer.html');
?>

<!--fim tutorial-->


<!--inicio script-->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL" crossorigin="anonymous"></script>
<!--fim script-->

</body>
</html>
