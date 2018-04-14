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
    $(".tabButton").each(function () {
        $(this).click(function () {
            $(".tabButton").removeClass("current");
            $("#projectDetail").html($(this).siblings(".tabContent").html());
            $(this).addClass("current");
        });
    });
});