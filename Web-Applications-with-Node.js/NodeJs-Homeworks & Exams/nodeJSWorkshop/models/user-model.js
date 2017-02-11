/* globals requier module */
"use strict";

const mongoose = require("mongoose");

let userSchema = new mongoose.Schema({
    username: {
        type: String,
        required: true,
        unique: true
    },
    displayName: String,
    imageUrl: {
        type: String,
        required: true
    }
});

mongoose.model("User", userSchema);

let UserModel = mongoose.model("User");

module.exports = UserModel;