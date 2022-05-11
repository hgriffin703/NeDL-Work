function checkAndAdd() {
    // place the values in the form into variables
    var theNewWord = document.forms["wordForm"]["enterWord"].value;
    var theNewNumber = document.forms["wordForm"]["enterNumber"].value;
    // validate that something was entered as a word
    if (theNewWord == "") {
      // no word was entered so tell the user
      alert("Please enter a word to check");
      return false;
    }
    // validate that a 1 or 2 was entered as a number
    else if ((theNewNumber != 1) && (theNewNumber != 2)) {
      // a 1 or 2 was not entered as the number so tell user and clear the field
      alert("Please enter a 1 or 2 for the list.");
      document.forms["wordForm"]["enterNumber"].value = "";
      return false;
    }
    else {
        // a word was entered and a 1 or 2 was entered as the number 
        // so add the word to the proper table 
        if (theNewNumber==1)
        {
           var tableRef = document.getElementById("List1");
           (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
        }
        else
        {
           var tableRef = document.getElementById("List2");
           (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
        }
        // erase the form fields
        document.forms["wordForm"]["enterWord"].value = "";
        document.forms["wordForm"]["enterNumber"].value = "";
        return true;
        }
  }

  function clearthelist1() {
    // clear the table of all rows
    var tableRef = document.getElementById("List1");
    tableRef.innerHTML = " ";
  }

  function clearthelist2() {
    // clear the table of all rows
    var tableRef = document.getElementById("List2");
    tableRef.innerHTML = " ";
  }