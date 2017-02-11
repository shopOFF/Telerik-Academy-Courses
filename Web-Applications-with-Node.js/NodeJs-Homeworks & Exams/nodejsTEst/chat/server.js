const express = require('express');
const app = express();
const server = require('http').createServer(app);
const io = require('socket.io').listen(server);
const path = require('path');
// const mongoose = require("mongoose");

// mongoose.connect("mongodb://localhost/messages")

users = [];
connections = [];
messages = [];

server.listen(process.env.PORT || 3000);
console.log("Server running...");


// let Message = require("./models/message-model");

// let messageData = require("./data/message-data")(Message);

// let messageController = require("./controllers/message-controller")(messageData);

app.get('/', function(req, res) {
    res.sendFile(__dirname + '/public');
});

// // get all users at that /mess url
// app.get("/mess", function(req, res) {
//     res.send(users);
// });

// app.set('views', path.join(__dirname, 'views')); // тва бъгва и юзърите се презаписват 1 в/у друг
app.set('view engine', 'pug');

app.get('/messenger', function(req, res) { // тука e rauta
    res.render("index");
});

app.use(express.static(__dirname + '/public'));

io.sockets.on('connection', function(socket) {
    connections.push(socket);
    console.log('Connected: %s sockets connnected', connections.length);

    // Disconnect
    socket.on('disconnect', function(data) {
        users.splice(users.indexOf(socket.username), 1);
        updateUsernames();
        connections.splice(connections.indexOf(socket), 1);
        console.log('Disconnected %s sockets connected', connections.length);
    });

    // Send Message
    socket.on('send message', function(data) {
        io.sockets.emit('new message', { msg: data, user: socket.username });
        messages.push(data);
        console.log(messages);
    });

    // New User 
    socket.on('new user', function(data, callback) {
        callback(true);
        socket.username = data;
        users.push(socket.username);
        updateUsernames();
    });

    function updateUsernames() {
        io.sockets.emit('get users', users)
    }
});