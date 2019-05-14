var myVariable = 10;

function func(){
    //hoisting declara primero myVariable
    //el segundo recorrido hace tengo una variable que se llame myVariable en este scope
    //si pues la igual a 25 
    //si no la tendria declarada se va al siguiente scope y pregunta lo mismo he iguala
    myVariable = 25;
    var myVariable;
}

func();
console.log(myVariable);
