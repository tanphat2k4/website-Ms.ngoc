$(function () {
   
    $('#jcarousel')
       .jcarousel({
           wrap: 'circular'
       })
       .jcarouselAutoscroll({
           interval: 2000,
           target: '+=1',
           autostart: true
       });
    var url = window.location.href;
    $("#menu").find("a").each(function() {
        var $self = $(this);
        if (url.indexOf($self.attr("href")) > 1) {
            $("#menu").find("li").removeClass("menu_active");
            $self.closest("li").addClass("menu_active");
        }
    });
});