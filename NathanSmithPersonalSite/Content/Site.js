$(document).ready(function () {
    $('ul.nav').children().removeClass('active');
    var pathname = window.location.pathname.substring(1);
    var identity;
    if (pathname.length === 0)
        identity = '#Home';
    else
        identity = '#' + pathname;
    $(identity).addClass('active');
});

$('.navbar-toggle').click(function () {
    if ($(window).width() <= 600) //The social media bar does not need to move
        return;
    if ($('#social-media-bar').hasClass('sticky-container-low')) {
        $('#social-media-bar').fadeOut(0).removeClass('sticky-container-low').fadeIn(600);
    }
    else {
        $('#social-media-bar').fadeOut(0).addClass('sticky-container-low').fadeIn(700);
    }
});