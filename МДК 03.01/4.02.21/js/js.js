let btn=document.getElementById("myBtn");
let win=document.getElementById("modal");

btn.onclick=function(){
    win.style.display="block";
}

let cl=document.getElementsByClassName("close");

cl[0].onclick=function(){
    win.style.display="none";
}