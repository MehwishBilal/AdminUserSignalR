"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/NotificationHub").build();

connection.start();

//connection.on("ReceiveMessage", function (msg) {
//    var li = document.createElement("li");
//    li.textContent = msg;
//    document.getElementById("NotificationList").appendChild(li);
//});

connection.on("ReceiveMessage", function (message) {
    var li = document.createElement("li");
    li.textContent = message;
    document.getElementById("NotificationList").appendChild(li);
   
});
