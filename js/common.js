$(document).ready(function () {
    $("#two .container").hide();
    $("#three .container").hide();
    $("#four .container").hide();

    $("#start-msg").fadeIn(3000);
    $("#one img").animate({
        left: $("#start-msg").css('left'),
        top: $("#start-msg").css('top')
    }, 0);
});
$(window).resize(function () {
    if ($(window).width() < 768) {
        $('.navbar-nav>li').on('click', function () {
            $('.navbar-toggle').click();
        });
    }
});
$(document).on('click', '#btnOne', function () {
    $("#one .container").fadeIn();
    $("#two .container").fadeOut(1500);
    $("#three .container").fadeOut(1500);
    $("#four .container").fadeOut(1500);
    doSliding("one", "0px", 300);
    doSliding("two", "0px", 200);
    doSliding("three", "0px", 100);
});

$(document).on('click', '#btnTwo', function () {
    $("#two .container").fadeIn();
    $("#three .container").fadeOut(1500);
    $("#four .container").fadeOut(1500);
    doSliding("one", "-=" + $(window).width(), 100);
    doSliding("two", "0px", 300);
    doSliding("three", "0px", 200);
});
$(document).on('click', '#btnThree', function () {
    $("#three .container").fadeIn();
    $("#four .container").fadeOut(1500);
    doSliding("one", "-=" + $(window).width(), 100);
    doSliding("two", "-=" + $(window).width(), 200);
    doSliding("three", "0px", 0);
});
$(document).on('click', '#btnFour', function () {
    $("#four .container").fadeIn();
    doSliding("one", "-=" + $(window).width(), 100);
    doSliding("two", "-=" + $(window).width(), 200);
    doSliding("three", "-=" + $(window).width(), 300);
    doSliding("four", "0px", 0);
});
$(document).on('click', '#start-msg', function () {
    var count = 0;
    count++;
    moveBunny("one-msg", count, 100);
    count++;
    moveBunny("two-msg", count, 3000);
    count++;
    moveBunny("three-msg", count, 6000);
    count++;
    moveBunny("four-msg", count, 9000);
    count++;
    moveBunny("five-msg", count, 12000);
    count++;
    moveBunny("six-msg", count, 15000);
    count++;
    moveBunny("end-msg", count, 18000);
    count++;
    setTimeout(function () {
        $("#one img").animate({
            left: '+=10%',
            top: $("#end-msg").css('top')
        }, 1500);
//        $("#one img").attr("src", "images/bunny-rev.gif");
    }, 19000);

    setTimeout(function () {
        $("#one img").attr("src", "images/bunny-rev.gif");
        $("#one-msg").fadeOut(3000);
        $("#two-msg").fadeOut(3000);
        $("#three-msg").fadeOut(3000);
        $("#four-msg").fadeOut(3000);
        $("#five-msg").fadeOut(3000);
        $("#six-msg").fadeOut(3000);
        $("#end-msg").fadeOut(3000);
        $("#one img").animate({
            left: $("#start-msg").css('left'),
            top: $("#start-msg").css('top')
        }, 3800);
    }, 24000);
    setTimeout(function () {
        $("#one img").attr("src", "images/bunny.gif");
    }, 28000);
});

var doSliding = function (id, leftPosition, timeDelay) {
    setTimeout(function () {
        $("#" + id).animate({
            left: leftPosition
        }, 1500);
    }, timeDelay);
};

var moveBunny = function (nextId, count, timeDelay) {
    setTimeout(function () {
        if ($(window).width() < 900) {
            if (count == 1 || count == 2 || count == 3 || count == 6 || count == 7) {
                $("#one img").attr("src", "images/bunny.gif");
                $("#one img").css("margin-left", '-18px');
            } else {
                $("#one img").attr("src", "images/bunny-rev.gif");
                $("#one img").css("margin-left", '100px');
            }
        }
        $("#one img").animate({
            left: $("#" + nextId).css('left'),
            top: $("#" + nextId).css('top')
        }, 1500);
        $("#" + nextId).fadeIn(3000);
    }, timeDelay);
};