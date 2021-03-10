let sub=document.getElementById("sub");


sub.onclick=function(){
    let login=document.getElementById("login").value;
    let pass=document.getElementById("pass").value;

    $.ajax({
		url: 'test.php',
		method: 'post',
		dataType: 'html',
		data: {login: login, pass:pass} ,
		success: function(data){
			alert(data);
		}
	});
};