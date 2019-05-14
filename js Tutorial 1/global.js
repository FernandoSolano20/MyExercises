var toPrint = "aaa";

function print(out){
    'use strict';//para que se caiga cuando no declaremos una variable y quiera declararla de forma global
    stringToPrint = out;//LHS
    console.log(stringToPrint);
}

print("Hello");
console.log(stringToPrint);