function myFunction()
{
    let getname: string = "";
    //takes the var and sets it equal to the fname that was entered
    getname = (<HTMLInputElement> document.getElementById("fname")).value;
    //compiles what will be printed when the button is pressed
    document.getElementById("greeting")!.innerHTML = "Hello there " + getname + "!";
}