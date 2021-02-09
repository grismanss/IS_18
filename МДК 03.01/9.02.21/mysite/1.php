<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>

    <form method="post" action="2.php">
        <input type="number" name="in1">
        <input type="number" name="in2">
        <input type="submit" name="sub1">
    </form>


    <form method="get" action="3.php">
        <input type="number" name="in3">
        <input type="number" name="in4">
        <input type="submit" name="sub2">
    </form>

    <form method="post" action="1.php">
        <input type="number" name="in5">
        <input type="number" name="in6">
        <input type="submit" name="sub3">
    </form>

    <?php
        print_r($_POST);
        if (isset($_POST['sub3'])){
            $a=$_POST['in5'];
            $b=$_POST['in6'];
            echo "сумма:".($a+$b);
        }
    ?>

</body>
</html>