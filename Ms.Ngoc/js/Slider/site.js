$(function () {
    $('#myGalleryProject').galleryView({
        panel_width: 486,
        panel_height: 300
    });

    $('#Blogpost')
        .jcarousel({
            wrap: 'circular'
        })
        .jcarouselAutoscroll({
            interval: 2000,
            target: '+=1',
            autostart: true
        });
    // gan active
    var url = window.location.href;
    $("menu").find("a").each(function(){
        var $self = $(this);
        if (url.indexOf($self.attr("href")) > 0) {
           $("#menu").find("li").removeClass("menu_active");
            $self.closest("li").addClass("menu_active");
        }
    });

});