<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Привет МИР!!</h1>

    <?php
        //это код php
        echo "<h4>".(2+2)."</h4>";

        $a=55;
        $b=18;
        // > < >= <= !=   || - или   && - и
        if ($a>$b){
            echo $a;
        }
        else{
            echo $b;
        }

        for ($i=0; $i<10; $i++){
            echo $i."<br>";
        }
        for ($i=0; $i<10; $i++){
            echo $i;
        }

    ?>

Сделать форму с двумя инпутами и кнопкой submit
При нажатии на кнопку получить ответ на новой странице
</body>
</html>