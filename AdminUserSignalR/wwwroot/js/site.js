// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
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
