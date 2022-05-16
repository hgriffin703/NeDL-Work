async function paragraphgetter()
{
    //creates the variable for the API call
    var baconlink = "https://baconipsum.com/api/";
    var newParagraphs = document.getElementById("MeatPara").value;
    //creates the link that will be fetched below. (the type and paras are the parameters)
    baconlink = baconlink + "?type=meat-and-filler&paras=" + newParagraphs;

    //calls the API and waits until data is fetched to do anything
    var responseAPI = await fetch(baconlink);

    //clear what was there before
    document.getElementById("MeatList").innerHTML = ""; 

    //convert to a JSON
    var jsonData = await responseAPI.json();

    //loops through the JSON to display the response
    for(var paragraph in jsonData)
    {
        document.getElementById("MeatList").innerHTML += "<p>" + jsonData[paragraph] + "</p>";
    }
    return true;
}