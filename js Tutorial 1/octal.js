var x = 120,
    y = 0x12,
    z = 0x2;
    
//dice 12 en hexadecimal es 18
//o podria usar parse int
var oct = parseInt(12,16)
//cuando declaramos un variable con ceros adelante eso lo lee como un numero octal
//si ponemos 0x y numero lo lee como hexadecimal
//por lo que no es bueno poner numeros con 0 a la izquierda.

console.log(oct);