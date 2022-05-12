function addNewItem() {
    var addToDo = "";
    //takes the var and sets it equal to the fname that was entered
    addToDo = document.getElementById("enterToDo").value;
    document.getElementById("greeting").innerHTML = "Hello there " + addToDo + "!";
    if (addToDo == "") {
        alert("Please enter a task to add");
        return false;
    }
    //else
    //{
    //var tableRef = document.getElementById("ToDoList");
    //(tableRef.insertRow(tableRef.rows.length)).innerHTML = addToDo;
    //}
}
function clearthelist() {
    // clear the table of all rows
    var tableRef = document.getElementById("ToDoList");
    tableRef.innerHTML = " ";
}
