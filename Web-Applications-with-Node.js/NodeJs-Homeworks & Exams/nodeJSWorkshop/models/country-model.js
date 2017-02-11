/* globals requier module */
"use strict";

const mongoose = require("mongoose");

let countrySchema = new mongoose.Schema({
    name: {
        type: String,
        required: true,
        unique: true
    }
});

mongoose.model("Country", countrySchema);

let CountryModel = mongoose.model("Country");

module.exports = CountryModel;