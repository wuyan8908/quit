window.onload = function () {
    var hours = document.getElementById("hours"),
        minute = document.getElementById("minute"),
        second = document.getElementById("second"),
        begin = document.getElementById("begin"),
        pause = document.getElementById("pause"),
        timer = null,
        Hours = 0,
        Minute = 0,
        Second = 0;

    begin.onclick = function () {
        timer = setInterval(function () {
            Second++;
            if (Second > 59) {
                Second = 0;
                Minute++;
                if (Minute > 59) {
                    Minute = 0;
                    Hours++;
                }
            }


            if (Second < 10) {
                second.innerText = "0" + Second;
            } else {
                second.innerText = Second;
            }


            if (Minute < 10) {
                minute.innerText = "0" + Minute;
            } else {
                minute.innerText = Minute;
            }


            if (Hours < 10) {
                hours.innerText = "0" + Hours;
            } else {
                hours.innerText = Hours;
            }
        }, 1000)
    }


    pause.onclick = function () {
        clearInterval(timer);
    }
}