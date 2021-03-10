<?php
include("connect.php");
//print_r($_POST);
//Array ( [last_name] => 55 [first_name] => 66
// [patronymic] => vhng [phone] => 6556 [email] => 222@mail.ru
// [pass] => 11 [pass2] => 11 [date_of_brith] => 2021-03-24 [sex] => 1 )


$last_name=$_POST['last_name'];
$first_name=$_POST['first_name'];
$patronymic=$_POST['patronymic'];
$phone=$_POST['phone'];
$email=$_POST['email'];
$pass1=$_POST['pass1'];
$date_of_brith=$_POST['date_of_brith'];
$sex=$_POST['sex'];
$s="";
if ($email!="" && $phone!="")
    $s="SELECT * FROM users WHERE email='$email' or phone='$phone'";
else if ($email==""){
    $s="SELECT * FROM users WHERE phone='$phone'";
}
else{
    $s="SELECT * FROM users WHERE email='$email' ";
}
$r=mysqli_query($link,$s);
$n=mysqli_num_rows($r);
if ($n!=0){
    //header("Location:index.php?mess=Данный email или телефон уже зарегистрирован");
    echo "Данный email или телефон уже зарегистрирован";
   //echo $s;
}
else{
    $s1="INSERT INTO `users`( `last_name`, `first_name`, `patronymic`, 
    `email`, `phone`, `pass`, `date_of_birth`, `registration_date`, `sex`)
     VALUES ('$last_name','$first_name','$patronymic',
    '$email','$phone','$pass','$date_of_brith', CURRENT_DATE(),$sex)";
    $r1=mysqli_query($link,$s1);
    //header("Location:index.php?mess=Пользователь успешно зарегистрирован");
    echo "Пользователь успешно зарегистрирован";
}

?>