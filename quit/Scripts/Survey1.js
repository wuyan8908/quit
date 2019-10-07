$(document).ready(function () {
    $(".button1").click(function () {
        var answer = [];
        var check = [0, 0, 0];
        for (var i = 1; i < 4; i++) {
            for (var j = 1; j < 7; j++) {
                var QuID = i * 10 + j;
                var checkBox = document.getElementById(QuID.toString());
                if (checkBox.checked === true) {
                    var a = "input[id='" + QuID + "']:checked";
                    var b = $(a).val();
                    answer.push(b);
                }
                else {
                    ++check[i - 1];
                }
            }
        }
        for (var i = 0; i < 3; i++) {
            if (check[i] === 6) {
                alert("Please finish all the questions first");
                return;
            }
        }

        var result = [0, 0, 0, 0, 0, 0];
        var score = [0, 0, 0, 0, 0, 0];

        for (var i = 0; i < answer.length; i++) {
            switch (answer[i]) {
                case 'A': ++result[0]; ++score[0]; break;
                case 'B': ++result[1]; ++score[1]; break;
                case 'C': ++result[2]; ++score[2]; break;
                case 'D': ++result[3]; ++score[3]; break;
                case 'E': ++result[4]; ++score[4]; break;
                case 'F': ++result[5]; ++score[5]; break;
            }
        }
        score.sort();
        var index = 0;
        if (score[5] === score[4]) {
            for (var i = 0; i < result.length; i++) {
                if (result[i] === score[5]) {
                    index = i;
                }
            }
        }
        else {
            for (var i = 0; i < result.length; i++) {
                if (result[i] === score[5]) {
                    index = i;
                    break;
                }
            }
        }
        switch (index) {
            case 0: window.location.href = "../Survey/CalmNegativeEmotions"; break;
            case 1: window.location.href = "../Survey/SocialSmoking"; break;
            case 2: window.location.href = "../Survey/Indulgence"; break;
            case 3: window.location.href = "../Survey/Addiction"; break;
            case 4: window.location.href = "../Survey/SensorimotorStimulation"; break;
            case 5: window.location.href = "../Survey/Habit"; break;
        }


    });
});