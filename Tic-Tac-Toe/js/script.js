var valueArray = new Array(3);
$(document).ready(function () {
    var count = 0;
    fillArray();
    $(document).on('click', '.btn-default', function () {
        count++;
        if (count % 2 === 0) {
            $(this).html('O');
            $(this).css('color', 'limegreen');
            $(this).attr("disabled", true);
            fillArray();
            setTimeout(function () {
                if (checkStatus('O')) {
                    $('.alert').addClass('alert-success');
                    $('.alert').html("Player <strong>2</strong> winner !");
                    $('.alert').show();
                    setTimeout(function () {
                        $('.alert').hide();
                    }, 2000);
                    $('.btn-default').attr("disabled", true);
                }
            }, 200);
        } else {
            $(this).html('X');
            $(this).css('color', 'gold');
            $(this).attr("disabled", true);
            fillArray();
            setTimeout(function () {
                if (checkStatus('X')) {
                    $('.alert').addClass('alert-success');
                    $('.alert').html("Player <strong>1</strong> winner !");
                    $('.alert').show();
                    setTimeout(function () {
                        $('.alert').hide();
                    }, 2000);
                    $('.btn-default').attr("disabled", true);
                }
            }, 200);
        }
        if (count === 9) {
            if (!checkStatus('O') && !checkStatus('X')) {
                setTimeout(function () {
                    $('.alert').addClass('alert-info');
                    $('.alert').html("Draw !");
                    $('.alert').show();
                    setTimeout(function () {
                        $('.alert').hide();
                    }, 2000);
                }, 200);
            }
        }
    });

    $(document).on('click', '#playAgain', function () {
        $('.btn-default').html('');
        count = 0;
        $('.btn-default').attr("disabled", false);
        valueArray = [];
    });
});
var checkStatus = function (sign) {
    var i = 0;
    var j = 0;
    for (i = 0, j = 0; j < 3; j++, i = 0) {
        if ((valueArray[i][j] === sign && valueArray[++i][j] === sign && valueArray[++i][j] === sign)) {
            return true;
        }
        i = 0;
        if ((valueArray[j][i] === sign && valueArray[j][++i] === sign && valueArray[j][++i] === sign)) {
            return true;
        }
    }
    if ((valueArray[0][0] === sign && valueArray[1][1] === sign && valueArray[2][2] === sign) ||
            (valueArray[0][2] === sign && valueArray[1][1] === sign && valueArray[2][0] === sign)) {
        return true;
    }
};
var fillArray = function () {
    var i = 0;
    var j = 0;
    for (i = 0; i < 3; i++) {
        valueArray[i] = new Array(3);
        for (j = 0; j < 3; j++) {
            valueArray[i][j] = $('#' + parseInt(i) + parseInt(j)).html();
        }
    }
};