var obj = {a:100,b:200},
myVar = 10;

delete obj.b;
//aqui deberia borrarme la variable pero js al tratar que no se caiga imprime el 10
//use strict hace que se caiga
//delete se usa para elminar elementos dentro de un obj no para borrar objs o vars
delete myVar;

console.log(obj);
console.log(myVar);