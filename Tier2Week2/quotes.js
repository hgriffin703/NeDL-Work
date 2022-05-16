async function getquotes()
{
    var quotesLink = "https://api.quotable.io/random";
    var theNewLength = document.getElementById("quoteSearch").value;

    var minLength = 0;   
    var maxLength = 1000;
    if (theNewLength==1)  // the user wants a short one
        maxLength = 50
    else if (theNewLength==2)
        {  // the user wants a medium one
         minLength = 50;
         maxLength = 500;
        }
    else // the user wants a long one
        minLength = 500;

    quotesLink = quotesLink + "?minLength=" + minLength + "&maxLength=" + maxLength;
    alert(quotesLink);

}