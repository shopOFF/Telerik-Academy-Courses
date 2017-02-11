/* globals requier module */
"use strict";

const mongoose = require("mongoose");

let powerSchema = new mongoose.Schema({
    name: {
        type: String,
        required: true,
        unique: true
    }
});

mongoose.model("Power", powerSchema);

let PowerModel = mongoose.model("Power");

module.exports = PowerModel;