//alert("Привет мир!");
/* var и let отличаются 
областью видимости 
Для простоты будем всегда 
использовать let */
var a="2";
let b="5";
b++;
a--;

//Вывод служебного сообщения 
//alert(a/b);

//Вывод данных в консоль
console.log(258);

//Вывод на html страницу
let p=document.getElementById("my_p");
p.innerHTML="Мой какой то текст";


let r;
console.log(r);
console.log(2/0);
//alert('abc'*3); 


//приведение к определенному типу данных
let h=Number("33");
console.log(h*5);

/*Работа с массивами js */
let mas1=[];
let mas2=[1,5,8,12];
let mas3=["dzbd","dgh","njn","ln"];
let mas4=["dzbd",66,"njn",12];

/*Добавление элемента в конец массива */
mas4.push(444);
console.log(mas4.length);

/*mas4.length количество элементо 
в массиве */

let mas5=new Array();

/*let mas1=[];
let mas5=new Array();
равнозначные способы 
объявления массивов
 */
mas4.shift();//удалит первый элемнт
mas4.pop();//удаляет последний элемент
mas4.unshift(88);//добавляет в начало
console.log(mas4[0]);
console.log(mas4[2]);
mas4.pop(mas4[1]);
console.log(mas4[2]);

/*Ассоциативные массивы */
let people={
    name:"Иван", 
    age:44,
    h:185
};
/*Обращение производится по имени ключа*/
console.log(people["name"]);
//к ассоциативным элементам 
//обратиться по немеру нельзя!!
console.log(people[1]);

let book={
    name:"Название",

    authors:{
        a1:"Иванов",
        a2:"петров"
    }
};

console.log(book["authors"]["a1"]);

if (6!=12){
    console.log("true");
}
else{
    console.log("false");
}

for (let i=0; i<10; i++){
    console.log(i);
}

/* Дана строка из 6-ти цифр. 
Проверьте, что сумма первых трех цифр равняется 
сумме вторых трех цифр. 
Если это так - выведите 
'да', в противном случае выведите 'нет'. */

let str="123321";
let a1=(Number(str[0])+Number(str[1])+Number(str[2]));
let a2=(Number(str[3])+Number(str[4])+Number(str[5]));
if (a1==a2){
    console.log("Да");
}
else{
    console.log("Нет");
}

/*Дан объект obj. С помощью цикла 
for-in выведите на экран ключи 
и элементы этого объекта. */
var obj = {green: 'зеленый', red: 'красный', blue: 'голубой'};
for (let k in obj){
    console.log(k);
    console.log(obj[k]);
}

/* Дан массив числами, например: [10, 20, 30, 50, 235, 3000]. 
Выведите на экран только 
те числа из массива, которые начинаются на цифру 1, 2 или 5. */

let m=[10, 20, 30, 50, 235, 3000];
for (let i=0; i<m.length; i++){
    let ff=String(m[i]);
    if (ff[0]=='1' || ff[0]=='2' || ff[0]=='5'){
        console.log(ff);
    }
}


/*Дан массив с элементами 1, 2, 3, 4, 5,
6, 7, 8, 9. С помощью цикла for создайте
 строку '-1-2-3-4-5-6-7-8-9-'.*/

 let st="";
 for (let i=0; i<m.length; i++){
     st=st+"-"+m[i];
 }
 st=st+"-";
 console.log(st);