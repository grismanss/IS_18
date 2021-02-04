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



let canvas=document.getElementById("my_cs");
let context=canvas.getContext("2d");



let x=15;
let y=150;
let k=1.5;

let p=[];

p[0]={
    x:canvas.width,
    y:0
}

let h=100;
let count=0;

document.addEventListener("keydown", key);

function key(){
    y=y-30;
}


function draw(){
    context.drawImage(bg,0,0);

    for (let i=0; i<p.length; i++){
        context.drawImage(pipeUp,p[i].x, p[i].y);
        context.drawImage(pipeBottom,p[i].x, p[i].y+h+pipeUp.height);

        p[i].x=p[i].x-1;

        if (p[i].x==Math.floor(bg.width/2)){
            p.push({
                x:bg.width,
                y: Math.floor(Math.random()*pipeUp.height)-pipeUp.height
            });
        }
        
        if(x + bird.width >= p[i].x
            && x <= p[i].x + pipeUp.width
            && (y <= p[i].y + pipeUp.height
            || y + bird.height >= p[i].y + pipeUp.height + h) 
            || (y + bird.height >= bg.height - fg.height)) {
            location.reload(); // Перезагрузка страницы
        }
            /*if( y + bird.height >= bg.height - fg.height ){
                    location.reload();
                    //history.go(0);
                    //count--;
                     // Перезагрузка страницы
                }*/   
        if (p[i].x==0){
            count++;
        }   
        if (p[i].x<-pipeBottom.width){            
            p.shift();
        }      

    }
   
    context.drawImage(fg,0,bg.height-fg.height);
    context.drawImage(bird,x,y);
    y=y+k;

    context.fillStyle = "#000";
    context.font = "24px Verdana";
    context.fillText("Счет: " + count, 10, canvas.height - 20);

    requestAnimationFrame(draw);
}


pipeBottom.onload = draw;