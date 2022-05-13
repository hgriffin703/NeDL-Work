function addNewItem() {
    var theNewToDo = "";
    // place the values in the form into variables
    theNewToDo = document.forms["ToDoForm"]["enterToDo"].value;
    // validate that something was entered as a word
    if (theNewToDo == "") {
        // no word was entered so tell the user
        alert("Please enter a To Do to add");
        return false;
    }
    else {
        var tableRef = document.getElementById("ToDoList");
        var row = tableRef.insertRow(-1);
        row.innerHTML = theNewToDo;
        document.forms["ToDoForm"]["enterToDo"].value = "";
    }
}
function clearoneitem() {
    var toDoTable = document.getElementById("ToDoList");
    var inputValue = document.forms["ToDoForm"]["clearItemValue"];
    if (Number(inputValue.value) < 1 || Number(inputValue.value) == null || Number(inputValue.value) > toDoTable.rows.length - 1) {
        // no number was enter; tell the user
        alert("Please enter the row number of the To Do to remove");
        return false;
    }
    else {
        toDoTable.deleteRow(Number(inputValue.value));
    }
}
function clearthelist() {
    // clear the table of all rows
    var tableRef = document.getElementById("ToDoList");
    tableRef.innerHTML = " ";
}
