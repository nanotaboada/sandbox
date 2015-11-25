requirejs.config({
    "baseUrl": "scripts",
    "shim": {
        "bootstrap" : { "deps" :['jquery'] }
    },
    "paths": {
        // http://goo.gl/GQs5dq
        "jquery": "http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js?noext",
        "bootstrap": "http://maxcdn.bootstrapcdn.com/bootstrap/3.3.1/js/bootstrap.min.js?noext"
    }
});

// Loads main app module
requirejs(["main"]);
