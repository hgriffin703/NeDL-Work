function checkAndAdd()
{   //checks that a value is entered for miles
    var getMiles = document.forms["runsForm"]["enterMiles"].value;
    if(getMiles == "")
    {
        alert("Please enter the miles run");
        return false;
    }
    else
    {
        var tableRef = document.getElementById("milesList");
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = getMiles;

        //find the sum and show it
        var sum = 0;
        var count = tableRef.rows.length
        for(Rows = 0; Rows < count; Rows++)
        {
            sum += parseInt(((tableRef.rows[aRow]).innerHTML));
        }
        var labelRef2 = document.getElementById("theSum");
        labelRef2.innerHTML = sum.toFixed(2); //shows the sum

        //find the average and show it
        var theAverage = sum/count;
        var labelRef1 = document.getElementById("theAverage");
        labelRef1.innerHTML = theAverage.toFixed(2); //show the average to the user with 2 decimal points

        var theMiles = [];
        for(Rows = 0; Rows < count; Rows++)
        {
            theMiles.push(parseInt(((tableRef.rows[aRow]).innerHTML)));
        }

        console.log(Math.max(theMiles));
        console.log(Math.min(theMiles));

        
        document.forms["runsForm"]["enterMiles"].value = "";
    }
}
//this will clear list 1
function clearmiles() {
    // clear the table of all rows
    var tableRef = document.getElementById("milesList");
    tableRef.innerHTML = "";
    var labelRef1 = document.getElementById("theAverage");
    labelRef1.innerHTML = "n/a";
    var labelRef2 = document.getElementById("theSum");
    labelRef2.innerHTML = "n/a";
    var labelRef3 = document.getElementById("theMax");
    labelRef3.innerHTML = "n/a";
  }
