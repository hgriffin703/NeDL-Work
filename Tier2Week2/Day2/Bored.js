async function getParticipants()
{
    var APIstring = "https://www.boredapi.com/api/";
    var newPeople = document.getElementById("people").value;

    if(newPeople ==0)
    {
        alert("You must select at least 1 participant")
    }
    else(newPeople == 1 || newPeople == 2 || newPeople == 3 || newPeople ==4)
    {

    APIstring = APIstring +"activity?participants=" +newPeople;

    var response = await fetch(APIstring);
    var jsonData = await response.json();
    var theNewHobby = JSON.stringify(jsonData.activity);
    document.getElementById("theHobby").innerHTML = theNewHobby;
    var theNewPeople = JSON.stringify(jsonData.participants);
    document.getElementById("thePeople").innerHTML = theNewPeople;
    }

}

async function getToDo()
{
    var APIstring = "https://www.boredapi.com/api/";
    var newCost = document.getElementById("cost").value;

    var minprice = 0.0;
    var maxprice = 0.8;

    if(newCost==1)
        {
            minprice = 0.0;
            maxprice = 0.2;
        }
    else if(newCost == 2)
        {
            minprice = 0.21;
            maxprice = 0.45;
        }
    else
        {
            minprice = 0.46;
            maxprice = 0.79;
        }

    APIstring = APIstring +"activity?minprice=" + minprice + "&maxprice=" + maxprice;


    var response = await fetch(APIstring);
    var jsonData = await response.json();
    var theNewHobby = JSON.stringify(jsonData.activity);
    document.getElementById("theHobby").innerHTML = theNewHobby;
    var theNewCost = JSON.stringify(jsonData.price);
    document.getElementById("thePeople").innerHTML = theNewCost;
}

function savehobby()
{
    localStorage.setItem("content", document.getElementById("theHobby").innerHTML);
    var content = localStorage.content;
    if(content !== undefined)
    {
        var tableRef = document.getElementById("SavedHobbies");
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = content;
    }
}

function crossoffhobby() {
    var theToDoList = document.getElementById("myHobbyTable");
    var inputValue = document.forms["hobbygenerator"]["clearItemValue"];
    if ((inputValue.value) == null) {
        // no number was enter; tell the user
        alert("Please enter the row number of the To Do to remove");
        return false;
    }
    else {
        console.log(inputValue.value);
        theToDoList.strike(inputValue.value);
        document.forms["hobbygenerator"]["clearItemValue"].value = "";
    }
}

function clearAll() {
    // clear the table of all rows
    var tableRef = document.getElementById("SavedHobbies");
    tableRef.innerHTML = " ";
}
