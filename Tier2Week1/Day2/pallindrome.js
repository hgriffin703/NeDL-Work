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
           (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ": " + palindrome(theNewWord);
        }
        else
        {
           var tableRef = document.getElementById("List2");
           (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ": " + checkPalindrome(theNewWord);
        }
        // erase the form fields
        document.forms["wordForm"]["enterWord"].value = "";
        document.forms["wordForm"]["enterNumber"].value = "";
        return true;
        }
  }
// program to check if the string is palindrome or not

function checkPalindrome(string) 
{
    var palindrome = true;
    // find the length of a string
    const len = string.length;

    // loop through half of the string
    for (let i = 0; i < len / 2; i++) {

        // check if first and last string are same
        if (string[i] !== string[len - 1 - i]) {
            return palindrome == false;
        }
    }
    return palindrome == true;
}


//second test for if something is a palindrome
function reverse( str )
{
  // variable holds reverse string
  let rev_str = "";
  for( let i = str.length-1 ;i >= 0 ;i--)
  {
    rev_str+= str[i];
  }
  // return reverse string
  return rev_str;
}

//  function checking string is palindrome or not
function palindrome( str )
{
  reverse_str = reverse(str);
  //  condition checking if reverse str is
  // same as string it is palindrome
  // else not a palindrome
  if( reverse_str === str)
  {
    console.log("passing string is a palindrome");
  }
  else
  {
    console.log("False")
  }
}

//this will clear list 1
  function clearlist1() {
    // clear the table of all rows
    var tableRef = document.getElementById("List1");
    tableRef.innerHTML = " ";
  }

  //this will clear list 2
  function clearlist2() {
    // clear the table of all rows
    var tableRef = document.getElementById("List2");
    tableRef.innerHTML = " ";
  }