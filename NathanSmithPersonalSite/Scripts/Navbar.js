//TODO: look at data attributes
//look up cyclomatic complexity
//change conditional to check for positive
//look for jquery toggle
//look up id convention
//look up kill biding to button click
$('.navbar-toggle').click(function () {
    if ($(window).width() >= 600) {
        $('#social-media-bar').hide().toggleClass('sticky-container-low').fadeIn(650);
    }
    //if ($(window).width() <= 600) //The social media bar does not need to move
    //    return;
    //if ($('#social-media-bar').hasClass('sticky-container-low')) {
    //    $('#social-media-bar').hide().removeClass('sticky-container-low').fadeIn(600);
    //}
    //else {
    //    $('#social-media-bar').hide().addClass('sticky-container-low').fadeIn(700);
    //}
});