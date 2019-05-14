var obj = {
    a:{
        b:{
            c: "hello"
        }
    }
}

var c = "this";//esta varaible no existe en el contexto de with
// se puede resolver con iife
/*
with(obj.a.b){
    console.log(c);
}*/

(function(newVar){
    console.log(newVar);
    console.log(c);
}(obj.a.b.c))
//newvar es lo que se pasa por obj.a.b.c