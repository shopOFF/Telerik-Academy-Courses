/* globals requier module */
"use strict";

const mongoose = require("mongoose");

let citySchema = new mongoose.Schema({
    name: {
        type: String,
        required: true,
        unique: true
    }
});

mongoose.model("City", citySchema);

let CityrModel = mongoose.model("City");

module.exports = CityrModel;