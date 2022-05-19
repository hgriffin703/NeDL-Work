async function getToDo()
{
    var APIstring = "https://www.boredapi.com/api/";
    var newThingtoDo = document.getElementById("bored").value;
    var newCost = document.getElementById("cost").value;
    var minprice = 1;
    var maxprice = 4;

    if (newThingtoDo==1 && newCost == 0)
    {  
        APIstring = APIstring + "activity";

         var response = await fetch(APIstring);
        var jsonData = await response.json();
        var theNewHobby = JSON.stringify(jsonData.activity);

        document.getElementById("theHobby").innerHTML = theNewHobby; 

    }
   else if (newThingtoDo==1 && newCost==1)
   {
    minprice == 1;
   }
   else if(newThingtoDo ==1 && newCost==2)
   {
       minprice == 2;
       maxprice ==3;
   }

    APIstring = APIstring +"activity";

    var response = await fetch(APIstring);
    var jsonData = await response.json();
    var theNewHobby = JSON.stringify(jsonData.activity);
    theNewHobby = theNewHobby.substring(1,theNewHobby.length-1);
    document.getElementById("theHobby").innerHTML = theNewHobby;
    var theNewCost = JSON.stringify(jsonData.participants);
    //theNewCost = theNewCost.substring(1,theNewCost.length-1);
    document.getElementById("theCost").innerHTML = theNewCost;


/* 
    else if (newCost==2)// the user wants a medium quote
        {  
         minLength = .3;
         maxLength = .6;
        }
    else// the user wants a long one
        minLength = .6;

       APIstring = APIstring + "activity";

       var response = await fetch(APIstring);

       var jsonData = await response.json();
       var theNewHobby = JSON.stringify(jsonData.activity);
       theNewHobby = theNewHobby.substring(1,theNewHobby.length-1);
       document.getElementById("theHobby").innerHTML = theNewHobby;
       var theNewCost = JSON.stringify(jsonData.price);
       theNewCost = theNewCost.substring(1,theNewCost.length-1);
       document.getElementById("theCost").innerHTML = theNewAuthor; */



   
}