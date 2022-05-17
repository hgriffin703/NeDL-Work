async function getToDo()
{
    var APIstring = "https://www.boredapi.com/api/";
    var newThingtoDo = document.getElementById("bored").value;

    if (newThingtoDo==1)  // the user wants a short quote
        APIstring = APIstring + "activity";
        alert(APIstring);

    var response = await fetch(APIstring);
    else (newThingtoDo==2)// the user wants a medium quote
}