//TODO: look at data attributes
//look up kill biding to button click
function moveMediaBar() {
    if ($(window).width() >= 600) {
        $('#social-media-bar').hide().toggleClass('sticky-container-low').fadeIn(650);
        $('.navbar-toggle').off();
        setTimeout(function () { $('.navbar-toggle').on("click", moveMediaBar); }, 400);
    }
}

$('.navbar-toggle').click(moveMediaBar);