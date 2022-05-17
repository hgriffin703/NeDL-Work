async function getToDo()
{
    var APIstring = "https://www.boredapi.com/api/";
    var newThingtoDo = document.getElementById("bored").value;

    if (newThingtoDo==1)
    {  
        APIstring = APIstring + "activity";


        var response = await fetch(APIstring);
        var jsonData = await response.json();
        var theNewHobby = JSON.stringify(jsonData.activity);

        document.getElementById("theHobby").innerHTML = theNewHobby;

    }
   else if (newThingtoDo==2)
   {
        alert("Have a great day!");
   }
}