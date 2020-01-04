$(window).on('scroll', () => {
    // don't allow the return to top display on mobile (get's in the way)
    if ($(window).width() < 768) {
        $('#return-to-top').hide();
        return;
    }

    if (document.body.scrollTop > 1000 || document.documentElement.scrollTop > 1000) {
        $('#return-to-top').fadeIn(700);
    }
    else {
        $('#return-to-top').fadeOut(700);
    }
});

$('#return-to-top').on('click', () => {
    $('html, body').animate({
        scrollTop: 0
    }, 1000);
});