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
