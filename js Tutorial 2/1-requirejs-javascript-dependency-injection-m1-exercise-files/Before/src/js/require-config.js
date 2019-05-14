//node build\r.js -o name=main baseUrl=src/js mainConfigFile=src/js/main.js out=src/js/main-optimized.min.js
//optimizar
//source map
//node build\r.js -o name=main baseUrl=src/js mainConfigFile=src/js/main.js out=src/js/main-optimized.min.js generateSourceMaps=true preserveLincenseComments=false optimize=uglify2
require.config({
    paths:{
        jquery:'jquery-2.1.1.min',
        templates:"../templates",
        hbs:"../../../../node_modules/require-handlebars-plugin/hbs"
    }
});