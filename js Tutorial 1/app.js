function asyncMethod(message, num){
    //fufill funcion funciono
    //reject no funciono
    return new Promise(function(fulfill, reject){
        setTimeout(function(){
            console.log(message + ' ' + num);
            fulfill(num+1);
        }, 500)
    })
}

async function main(){
    var one = await asyncMethod('Open DB Connection', 0)
    var two = await asyncMethod('Fin User', one)
    var three = await asyncMethod('validate user', two)
    var four = await asyncMethod('do stuff', three)
}

main();