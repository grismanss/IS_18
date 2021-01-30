let bg=new Image();
bg.src="img/flappy_bird_bg.png";

let bird=new Image();
bird.src="img/flappy_bird_bird.png";

let fg=new Image();
fg.src="img/flappy_bird_fg.png";

let pipeUp=new Image();
pipeUp.src="img/flappy_bird_pipeUp.png";

let pipeBottom=new Image();
pipeBottom.src="img/flappy_bird_pipeBottom.png";

let car=new Image();
car.src="img/111.jpg";

let canvas=document.getElementById("my_cs");
let context=canvas.getContext("2d");

let canvas2=document.getElementById("my_cs2");
let context2=canvas2.getContext("2d");


let x=15;
let y=150;
let k=1.5;

//document.addEventListener("keydown", key);

function key(){
    y=y-30;
}


function KeyDown(e)
{
    switch(e.keyCode)
    {
        case 37: //Влево
            x=x-5;
            break; 
        case 39: //Вправо
            x=x+5;
            break; 
        case 38: //Вверх
            break; 
        case 40: //Вниз
            break; 
        case 27: //Esc
            break;
    }
}
document.addEventListener("keydown", function (e) { KeyDown(e); });

function draw(){
    context.drawImage(bg,0,0);
    context.drawImage(fg,0,bg.height-fg.height);
    context.drawImage(bird,x,y);
    y=y+k;
    requestAnimationFrame(draw);
}

//Вызов функции происходт после загрузки изображения
//pipeBottom.onload = draw;
let x1=0;
let y1=0;
function draw2(){
    context2.clearRect(0,0,512,512)
    
    context2.drawImage(car,c,y1);
    context2.drawImage(car,0,0);
    
    y1=y1+10;
    requestAnimationFrame(draw2);
}

car.onload = draw2;