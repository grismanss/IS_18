function fun1(){
    alert("Вы нажали кнопку 1");
}

function fun2(){
    alert("Вы нажали тег p");
}

function fun3(){
    //alert("При навеедении на заголовок");
}

function test1(){
    let p=document.getElementById("test");
    p.innerHTML="Новый текст!";
    p.style.color="#FF4500";
    p.style.fontSize="35pt";
}

function test2(){
    let p=document.getElementsByTagName("p");
    for (let i=0; i<p.length; i++){
      p[i].style.fontSize="28pt";  
    }
}

function test3(){
    let p=document.getElementsByClassName("my_test");
    for (let i=0; i<p.length; i++){
        p[i].style.color="#00FF00";  
      }
}

function multiply(){
    let a1=document.getElementById("a1").value;
    let a2=document.getElementById("a2").value;
    let a3=a1*a2;
    document.getElementById("a3").value=a3;
   
}


