function returnObject()
{
    var someThingTrue = true;
    if(typeof someThingTrue !== 'undefined')
    {
        if(someThingTrue)
        {
            return{
                hi: 'hello'
            }
        }
    }
    return {
        hi:"hooo"
    }
}
console.log(returnObject().hi)