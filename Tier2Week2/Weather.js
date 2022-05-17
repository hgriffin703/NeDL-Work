async function getForecast()
{
var APIstring = "https://api.weather.gov/";
var cityselect = document.getElementById("forecast").value;
APIstring = APIstring + cityselect + "/31,80/forecast";
alert(APIstring);

    //calls the API and waits until data is fetched to do anything
    var response = await fetch(APIstring);

    //clear what was there before
    document.getElementById("ForecastTable").innerHTML = ""; 

    //convert to a JSON
    var jsonData = await response.json();
}