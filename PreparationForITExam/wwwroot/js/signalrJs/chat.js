//var connection = new signalR.HubConnectionBuilder()
//    .withUrl('/Home/Index')
//    .build();

//connection.on('receiveMessage', addMessageToChat);

//connection.start()
//    .catch(error => {
//        console.error(error.message);
//    });

//function sendMessageToHub(message) {
//    connection.invoke('sendMessage', message);
//}





"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/Chat/Index").build();

document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");

    var msgContent = document.createElement("div");
    msgContent.classList.add("msg-content");
    var msgMessage = document.createElement("span");
    msg.textContent = msg;
    msgMessage.classList.add("msg-message");

    msgContent.appendChild(msgMessage);

    document.getElementById("msg").appendChild(msgContent);
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var senderId = document.getElementById("senderId").value;
    var sender = document.getElementById("senderName").value;
    var receiverId = document.getElementById("receiverId").value;
    var receiver = document.getElementById("receiverName").value;
    var message = document.getElementById("messageInput").value;

    connection.invoke("SendMessageToUser", sender, receiver, message).catch(function (err) {
        return console.error(err.toString());
    });

    event.preventDefault();
});