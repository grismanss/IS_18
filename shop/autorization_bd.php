<?php
session_start();
include("connect.php");
$login=$_POST['login'];
$pass=$_POST['pass'];

$s="select id from users where (phone='$login' and pass='$pass') 
or (email='$login' and pass='$pass')";

//echo $s;
$res=mysqli_query($link, $s);
$n=mysqli_num_rows($res);
$mass=array("status"=> "", "mess"  => "", "login"=>"");
//echo $n;
if ($n==0){
   // header("Location:index.php?mess=Неверный логин или пароль");
   //echo "Неверный логин или пароль";
   $mass['status']=0;
   $mass['mess']="Неверный логин или пароль";
}
else{
    $_SESSION['login']=$login;
    //header("Location:index.php");
   // echo "Добро пожаловать,".$login;
    $mass['status']=1;
    $mass['login']=$login;
    $mass['mess']="Добро пожаловать,".$login;
}

echo json_encode($mass);



?>