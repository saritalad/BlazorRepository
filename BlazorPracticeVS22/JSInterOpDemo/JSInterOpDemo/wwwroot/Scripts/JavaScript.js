function GetMessage(target) {
    return "Hello " + target + "!!!";
}
function GetSum(a, b) {

    return a + b;
}
function WireJQueryEventHandler() {

    $("#button1").mouseenter(function (e) {
        $(this).css("background-color", "lightgreen");
    });

    $("#button1").mouseover(function (e) {
        $(this).css("background-color", "lightgreen");
    });

    $("#button1").mouseleave(function (e) {
        $(this).css("background-color", "");
    });
}


function CallCSMethod(compRef) {

    alert("You will be calling a C# method!");

    compRef.invokeMethodAsync("SetMessage","Hello Universe!!!").then((result) => {
            if (result) {
                alert("C# method was successful!");
            }
        });

    return true;
}
