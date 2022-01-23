"use strict";

// var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

// //Disable send button until connection is established
// document.getElementById("sendButton").disabled = true;


// connection.on("ReceiveMessage", function (user, message) {
//     var li = document.createElement("li");
//     var like = document.createElement("Button");
//     like.textContent = "like";
//     like.classList.add("btn");
//     like.classList.add("btn-primary");
//     document.getElementById("messagesList").appendChild(li);
//     document.getElementById("messagesList").appendChild(like);
//     // We can assign user-supplied strings to an element's textContent because it
//     // is not interpreted as markup. If you're assigning in any other way, you 
//     // should be aware of possible script injection concerns.
//     li.textContent = `${user}: ${message}`;
//     var report = document.createElement("Button");
//     var reportForm = document.createElement("Form");
//     var hiddenInputMessage = document.createElement("input");
//     var hiddenInputUser = document.createElement("input");
//     report.textContent = "Report";
//     report.classList.add("btn");
//     report.classList.add("btn-primary");
//     report.classList.add("ReportMessage");
//     report.type = "sumbit";
//     report.formaction = "Report/reportMessage";
//     hiddenInputMessage.style.display = "None";
//     hiddenInputMessage.innerText = message;

//     hiddenInputUser.style.display = "None";
//     hiddenInputUser.innerText = user;

    
//     reportForm.appendChild(hiddenInputMessage);
//     reportForm.appendChild(hiddenInputUser);
//     reportForm.appendChild(report);
// });

// connection.start().then(function () {
//     document.getElementById("sendButton").disabled = false;
// }).catch(function (err) {
//     return console.error(err.toString());
// });

// document.getElementById("sendButton").addEventListener("click", function (event) {
//     // var user = await userManager.GetUserAsync(HttpContext.User);
//     var message = document.getElementById("messageInput").value;
//     var room = document.getElementById("room").value;
//     connection.invoke("SendMessage", user, message,room,false).catch(function (err) {
//         return console.error(err.toString());
//     });
//     event.preventDefault();
// });


// document.getElementById("joinButton").addEventListener("click", function (event) {

//     var room = document.getElementById("room").value;
//     //var user = document.getElementById("userInput").value;
//     var user = await userManager.GetUserAsync(HttpContext.User);
//     var message = document.getElementById("messageInput").value;

//     connection.invoke("SendMessage", user, message, room, true).catch(function (err) {
//         return console.error(err.toString());
//     });

//     event.preventDefault();
// });

