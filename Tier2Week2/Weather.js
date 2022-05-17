async function getForecast()
{
  var APIstring = "https://api.weather.gov/gridpoints/";
  var cityselect = document.getElementById("forecast").value;
  APIstring = APIstring + cityselect + "/31,80/forecast";
  alert(APIstring);
  console.log(APIstring);

  var response = await fetch(APIstring);
  var jsonData = await response.json();

  days=jsonData.properties.periods.length;

/*   document.getElementById("myDate").innerHTML = "";
  document.getElementById("myForecast").innerHTML = "";
  document.getElementById("myTemp").innerHTML = ""; */

  for (let i=0;i<days;i++)
  {
    document.getElementById("myDate").innerHTML += jsonData.properties.periods[i].name + "<br><br>";
    document.getElementById("myForecast").innerHTML += jsonData.properties.periods[i].shortForecast + "<br><br>";
    document.getElementById("myTemp").innerHTML += jsonData.properties.periods[i].temperature + " degrees Farenheit" + "<br><br>";
  }
}