//Declarations
myFunc();
function myFunc(){
    console.log("Hi from my func");
}
//Expression
//al ser una variable se debee llamar despues de que se le asigne la funcion porque si la llamo arriba
//se va acaer porquw expression es undefined por hoisting 
var expression = function(){
    console.log("Hi from my expression");
}

expression();