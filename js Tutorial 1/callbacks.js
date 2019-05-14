var list = [5,8,9,2,7,6,3,1,4];

function callback(list){
    var newList = [];
    
    for (var index = 0; index < list.length; index++) {
        if(list[index] > 5){
            newList.push(list[index]);
        }
    }
    return newList;
}

function filter(lists, callbacks){
    return callbacks(lists);
}

var filtered = filter(list,callback);
console.log(filtered);