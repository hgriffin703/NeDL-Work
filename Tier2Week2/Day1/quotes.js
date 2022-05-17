async function getquotes()
{
    var quotesLink = "https://api.quotable.io/random";
    var theNewLength = document.getElementById("quoteSearch").value;

    var minLength = 0;   
    var maxLength = 1000;
    if (theNewLength==1)  // the user wants a short quote
        maxLength = 50
    else if (theNewLength==2)// the user wants a medium quote
        {  
         minLength = 50;
         maxLength = 250;
        }
    else// the user wants a long one
        minLength = 250;

    quotesLink = quotesLink + "?minLength=" + minLength + "&maxLength=" + maxLength;

    var response = await fetch(quotesLink);

    //this will show out the quote and the author of the quote
    var jsonData = await response.json();
    var theNewQuote = JSON.stringify(jsonData.content);
    theNewQuote = theNewQuote.substring(1,theNewQuote.length-1);
    document.getElementById("theQuote").innerHTML = theNewQuote;
    var theNewAuthor = JSON.stringify(jsonData.author);
    theNewAuthor = theNewAuthor.substring(1,theNewAuthor.length-1);
    document.getElementById("theAuthor").innerHTML = theNewAuthor;
}