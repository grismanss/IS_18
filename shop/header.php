<?php
session_start();

?>
!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Магазин бытовой техники</title>
    <link rel="canonical" href="https://getbootstrap.com/docs/5.0/examples/carousel/">

    

<!-- Bootstrap core CSS -->
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous">

<style>
  .bd-placeholder-img {
    font-size: 1.125rem;
    text-anchor: middle;
    -webkit-user-select: none;
    -moz-user-select: none;
    user-select: none;
  }

  @media (min-width: 768px) {
    .bd-placeholder-img-lg {
      font-size: 3.5rem;
    }
  }
</style>


<!-- Custom styles for this template -->
<link href="css/carousel.css" rel="stylesheet">
<link href="css/style.css" rel="stylesheet">
</head>
<body>
<header>
  <nav class="navbar navbar-expand-md navbar-dark fixed-top bg-dark">
    <div class="container-fluid">
      <a class="navbar-brand" href="#"><img class="my_logo" src="img/logo.png">Бытовая техника</a>
      <div class="collapse navbar-collapse justify-content-end" id="navbarCollapse">
        <form class="d-flex">
          <input class="form-control me-2" type="search" placeholder="Поиск" aria-label="Search">
          <button class="btn btn-outline-primary" type="submit">Поиск</button>
        </form>
      </div>
    </div>
  </nav>
  <nav class="navbar navbar-expand-md navbar-dark bg-dark">
    <div class="container-fluid">
       <div class="collapse navbar-collapse" id="navbarCollapse">
        <ul class="navbar-nav me-auto mb-2 mb-md-0">
          <li class="nav-item active">
            <a class="nav-link" aria-current="page" href="#">Каталог</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Смартфоны</a>
          </li>
          <li class="nav-item">
            <a class="nav-link " href="#" >Техника для дома</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Красота и здоровье</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="#">Прочее</a>
          </li>
        </ul>
        <div>
       
            <div id="authorized">
            <a class="navbar-brand" href="#" ><span id="login_user"></span></a>
            <a class="navbar-brand" href="exit.php" >Выход</a>
            </div>
     
         <div id="unauthorized">
          <a class="navbar-brand" href="#" data-bs-toggle="modal" data-bs-target="#exampleModal">Авторизация</a>
          <a class="navbar-brand" href="#" data-bs-toggle="modal" data-bs-target="#exampleModal2">Регистрация</a>
          </div>
     
        </div>
        </div>
    </div>
  </nav>
</header>
<?php
//print_r($_SESSION);
?>