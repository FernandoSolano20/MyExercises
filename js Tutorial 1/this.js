var obj = {
    val: "Hi there",
    printVal: function(){
        console.log(this.val);
    }
};

var obj2 = {
    val: "What up",
};

var print = obj.printVal.bind(obj2);
print();

obj2.printVal = obj.printVal;

obj2.printVal();