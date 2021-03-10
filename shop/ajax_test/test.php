<?php
include("connect.php");
$log=$_POST['login'];
$pass=$_POST['pass'];

$s="select id from users where (phone='$log' and pass='$pass') 
or (email='$log' and pass='$pass')";
$res=mysqli_query($link, $s);
$n=mysqli_num_rows($res);

if ($n==0){
    echo "Пользователь не найден!";
}
else{
    echo "Пользователь найден!";
}


?>