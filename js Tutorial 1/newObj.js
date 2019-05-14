var obj = function(){
    var _this = this;
    this.hello = 'hello';
    //por mas que le ponga return no va funcionar
    this.greet = function(){
        //console.log(this);
        console.log(_this.hello);
    }
    this.delayGreeting = function(){
        //console.log(this);
        setTimeout(this.greet,1000);
    }
    //caundo pongo el new hace un implicito new this
}


//obj(); no funciona

var greeter  = new obj();
greeter.delayGreeting();
