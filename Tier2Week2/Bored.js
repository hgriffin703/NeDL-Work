async function GetToDo()
{
    var APIstring = "https://www.boredapi.com/api/"
    var newThingtoDo = document.getElementById("areyoubored").value;
    APIstring = APIstring + "activity"
    alert(APIstring);
}