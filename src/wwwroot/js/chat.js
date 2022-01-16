"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;


connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    var like = document.createElement("Button");
    like.textContent = "like";
    like.classList.add("btn");
    like.classList.add("btn-primary");
    document.getElementById("messagesList").appendChild(li);
    document.getElementById("messagesList").appendChild(like);
    // We can assign user-supplied strings to an element's textContent because it
    // is not interpreted as markup. If you're assigning in any other way, you 
    // should be aware of possible script injection concerns.
    li.textContent = `${user} says ${message}`;
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    var room = document.getElementById("room").value;
    connection.invoke("SendMessage", user, message,room,false).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});
document.getElementById("joinButton").addEventListener("click", function (event) {

    var room = document.getElementById("room").value;
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    connection.invoke("SendMessage", user, message, room,true).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});