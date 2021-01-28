let canvas=document.getElementById("my_canvas");
let cotext=canvas.getContext('2d');

/*Цвет заливки */
cotext.fillStyle="red";

/*Рисование закрашенного прямоугольника*/
cotext.fillRect(20,50,100,150); 

//Цвет обводки
cotext.strokeStyle="rgb(180,165,88)";
//толщина обводки
cotext.lineWidth =5;
//не закрашенный прямоугольник
cotext.strokeRect(200,200,50,40);

/*Рисоание пустой дуги */
cotext.arc(180, 180, 100, 0, 2*Math.PI, false);
cotext.stroke()

//cotext.ellipse(180,180,100,150,0,2*Math.PI);




var centerX = 0;
var centerY = 0;
var radius = 50;

// save state
cotext.save();

// translate context
cotext.translate(canvas.width / 2, canvas.height / 2);

// scale context horizontally
cotext.scale(1, 2);

// draw circle which will be stretched into an oval
cotext.beginPath();
cotext.arc(centerX, centerY, radius, 0, 2 * Math.PI, false);

// restore to original state
cotext.restore();

// apply styling
cotext.fillStyle = '#8ED6FF';
cotext.fill();
cotext.lineWidth = 5;
cotext.strokeStyle = 'black';
cotext.stroke();

let h=50;
let x=h;
let y=0;
cotext.fillStyle="black";
for(let j=1; j<9; j++){
    for (let i=0; i<4; i++){
        cotext.fillRect(x,y,h,h);         
        x=x+h*2
    }
    y=y+h;
    let mod = parseInt(j % 2);
    if (mod==0){
        x=h;
    }else{
        x=0;
    }
}

function cler_canvas(){
    cotext.clearRect(0,0,canvas.width,
        canvas.height);
}


let canvas2=document.getElementById("my_canvas2");
let cotext2=canvas2.getContext('2d');
let x1=canvas2.width/2;
let y1=canvas2.height/2;
let h1=50;

function draw(){
    cotext2.fillStyle="yellow";
    cotext2.fillRect(x1,y1,h1,h1);
}
draw();
function clear(){
    cotext2.clearRect(x1,y1,h1,h1);
}
function move_top(){
    clear();
    y1=y1-10;
    if (y1<0){
        y1=0;
    }
    draw();
}
function move_bottom(){
    clear();
    y1=y1+10;
    if (y1>(canvas2.height-h1)){
        y1=canvas2.height-h1;
    }
    draw();
}
function move_right(){
    
}
function move_left(){
    
}

let canvas3=document.getElementById("my_canvas3");
let cotext3=canvas3.getContext('2d');
let img=new Image();
img.src="sprite.png";
let y3=0;
let w3=128;
let h3=128;

function dw(){
    cotext3.clearRect(0,0, canvas3.width, canvas3.height);
    cotext3.drawImage(
        img,
        0,
        y3*h3,
        h3, 
        w3,
        50,
        80,
        h3,
        w3

    );

    y3=y3+1;
    if (y3>3){
        y3=0;
    }
    setTimeout(dw,150);
}
dw();















