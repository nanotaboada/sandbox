require(["jquery", "bootstrap"], function($) {
    $(function (){
        $("#content")
            .append("<p>jQuery & Twitter Bootstrap successfully loaded from CDN via RequireJS!</p>")
            .addClass("alert alert-success");
    });
});
