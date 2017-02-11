/* globals requier module */
"use strict";

const mongoose = require("mongoose");

let fractionSchema = new mongoose.Schema({
    name: {
        type: String,
        required: true,
        unique: true
    },
    alignment: {
        type: String,
        required: true
    }
});

mongoose.model("Fraction", fractionSchema);

let FractionModel = mongoose.model("Fraction");

module.exports = FractionModel;