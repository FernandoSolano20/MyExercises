//module patter
define(function(requiere, exports, module){

    //Simplified CommonJs Wrapper
    //alternativa por si son muchos parametros, se debe poner esos 3 paramentros en ese orden y hacer lo de abajo
    //llamar las dependenciad del modulo  
    var $ = require("jquery");
    var tasks = require("tasks");

    //modulo app es para la aplicacion para la inicializacion
    //configura los componentes especificos de la app
    //el main se configura el requiere

    /* register event handlers */
    function _addTask(){
        tasks.add();
    }

    function _deleteAllTask(){
        tasks.clear();
    }

    function _saveChanges(){
        tasks.save();
    }

    function _cancelChanges(){
        tasks.cancel();
    }

    function _deleteTask(clickEvent){
        tasks.remove(clickEvent);
    }

    function _registerEventHandlers() {
        $("#new-task-button").on("click", _addTask);
        $("#delete-all-button").on("click", _deleteAllTask);
        $("#save-button").on("click", _saveChanges);
        $("#cancel-button").on("click", _cancelChanges);
        $("#task-list").on("click", ".delete-button", _deleteTask);
    }

    exports.init = function(){
        _registerEventHandlers();
        tasks.render();
    }
});