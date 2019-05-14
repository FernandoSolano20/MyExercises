({
    name: "main",
    baseUrl: "../src/js",
    mainConfigFile: "../src/js/main.js",
    out: "../src/js/main-optimized.min.js",
    generateSourceMaps: true, 
    preserveLincenseComments:false,
    optimize: "uglify2"
})