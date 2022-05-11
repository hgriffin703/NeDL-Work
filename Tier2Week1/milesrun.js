function checkAndAdd()
{
    var getMiles = document.forms["runsForm"]["enterMiles"].value;
    alert("Here is your value of" + getMiles);
    if(getMiles == "")
    {
        alert("Please enter the miles run")
        return false;
    }
    else
    {
        var tableRef = document.getElementById("milesList");
        (tableRef.insertRow(tableRef.rows.ength)).innerHTML = getMiles;

        var sum = 0;
        var count = tableRef.rows.length
        for(aRow = 0; aRow < count; aRow++)
        {
            sum += parseInt(((tableRef.rows[aRow]).innerHTML));
        }
        var labelRef2 = document.getElementById("theSum");
        labelRef2.innerHTML = sum.toFixed(2);

        //find the average and show it
        var theAverage = sum/count;
        var labelRef1 = document.getElementById("theAverage");
        labelRef1.innerHTML = theAverage.toFixed(2); //show the average to the user with 2 decimal points

        var theMax = Math.ceil("milesList");
        var labelRef3 = document.getElementById("theMax");
        labelRef3.innerHTML = theMax.toFixed(2);
    }
}
function getAverage()
{
    var getAverageAmount = document.forms["runsForm"]["enterMiles"].value;
    const milesArray = [getMiles] 

}