let b1=document.getElementById("b1");
b1.onclick=function(){
    $('.www').html('Новый текст!!!');
};


let b2=document.getElementById("b2");
b2.onclick=function(){
   // $('.www').css('color', 'red');
  //  $('.www').css('font-size', '25pt');
    $('.www').css({color:'red', font:'30pt Arial'});
};


let b3=document.getElementById("b3");
b3.onclick=function(){
    $('.www').html('Новый текст!!!').css('color', 'red');
    $('#b3').html('Новая надпись кнопки B3');
}


let b4=document.getElementById("b4");
b4.onclick=function(){
    //$('p:has(>b)').html('bbbbbbbb');
    $('p:has(b)').html('bbbbbbbb');
}

let b5=document.getElementById("b5");
b5.onclick=function(){
    $('p:contains("тегом")').html('*****');
}

let b6=document.getElementById("b6");
b6.onclick=function(){
  let k=$('#in1').attr('value');
  $('#in2').attr('value',k);
}

let it_type=true;
let b7=document.getElementById("b7");
b7.onclick=function(){
    if (it_type==true){
        $('#in2').attr('type','password');
        //it_type=false;
    }
    else{
        $('#in2').attr('type','text');
       // it_type=true;
    }
    it_type=!it_type;
}

let b8=document.getElementById("b8");
b8.onclick=function(){
    //$('#in1').attr('value','');
    $('#in1').removeAttr('value');
}


$('li').click(function(){
    $(this).html('!!!');
});

$('#hide').click(function(){
    $('#elem').hide(1000);
});

$('#show').click(function(){
    $('#elem').show(500);
});


$('#hide1').click(function(){
    $('#elem').slideUp(1000);
});

$('#show1').click(function(){
    $('#elem').slideDown(1000);
});