let exitIsClicked = false;

document.getElementById("exitBtn").onclick = function (e) {
    exitIsClicked = true;
}

document.getElementById("form1").onsubmit = function (e) {
    let one = document.querySelector('input[name="1"]:checked');
    let two = document.querySelector('input[name="2"]:checked');
    let three = document.querySelector('input[name="3"]:checked');
    let four = document.querySelector('input[name="4"]:checked');
    let five = document.querySelector('input[name="5"]:checked');
    let six = document.querySelector('input[name="6"]:checked');
    let seven = document.querySelector('input[name="7"]:checked');
    let eight = document.querySelector('input[name="8"]:checked');
    let nine = document.querySelector('input[name="9"]:checked');
    let ten = document.querySelector('input[name="10"]:checked');
    let eleven = document.querySelector('input[name="11"]:checked');
    let twelve = document.querySelector('input[name="12"]:checked');
    let threeteen = document.querySelector('input[name="13"]:checked');

    let elements = [one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, threeteen];

    if (elements.some(x => !x)) {
        return false;
    }

    let oneV = parseInt(one.value);
    let twoV = parseInt(two.value);
    let threeV = parseInt(three.value);
    let fourV = parseInt(four.value);
    let fiveV = parseInt(five.value);
    let sixV = parseInt(six.value);
    let sevenV = parseInt(seven.value);
    let eightV = parseInt(eight.value);
    let nineV = parseInt(nine.value);
    let tenV = parseInt(ten.value);
    let elevenV = parseInt(eleven.value);
    let twelveV = parseInt(twelve.value);
    let threeteenV = parseInt(threeteen.value);


    let result = oneV + twoV + threeV + fourV + fiveV + sixV + sevenV + eightV + nineV + tenV + elevenV + twelveV + threeteenV;
    document.getElementById("grade").innerHTML = result;
    document.getElementById("score").value = result;

    elements.forEach(x => {
        if (x.value != "0") {
            x.parentElement.style.color = 'green';
        }
        else {
            x.parentElement.style.color = 'red';
        }
    });

    document.querySelectorAll('input[type=radio]').forEach(x => {
        x.readonly = true;
        x.disabled = true;
    });
    
    if (!exitIsClicked) {
        return false;
    }

    exitIsClicked = false;
}

var countDownDate = new Date().getTime() + (60 * 60000);

var x = setInterval(function () {

    var now = new Date().getTime();

    var distance = countDownDate - now;

    var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
    var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
    var seconds = Math.floor((distance % (1000 * 60)) / 1000);

    document.getElementById("demo").innerHTML = hours + "h "
        + minutes + "m " + seconds + "s ";

    if (distance < 0) {
        clearInterval(x);
        document.getElementById("demo").innerHTML = 'END'
    }
}, 1000);
