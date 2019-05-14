//Revealing Module Pattern
//no se ocupa especificar module name porque ya esta en el nombre del archivo.js
//ademas como nuestro modulo depende de taskData requiereJS cargo un archivo con la ruta js
define([], function(){
    "use strict";

    /* load and save data */

    var STORE_NAME = "tasks";

    function saveTaskData (tasks) {
        localStorage.setItem(STORE_NAME, JSON.stringify(tasks));
    }

    function loadTaskData () {
        var storedTasks = localStorage.getItem(STORE_NAME);
        if(storedTasks) {
            return JSON.parse(storedTasks);
        }
        return [];
    }

    function clearTaskData () {
        localStorage.removeItem(STORE_NAME);
    }

    return{
        save:saveTaskData,
        load:loadTaskData,
        clear:clearTaskData
    }
    //cuando funcion requier se ejecute este return se lo que se le pasa al taskData de ese parametro
});