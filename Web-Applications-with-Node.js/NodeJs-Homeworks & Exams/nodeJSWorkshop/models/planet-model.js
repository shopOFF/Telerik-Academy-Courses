/* globals requier module */
"use strict";

const mongoose = require("mongoose");

let planetSchema = new mongoose.Schema({
    name: {
        type: String,
        required: true,
        unique: true
    }
});

mongoose.model("Planet", planetSchema);

let PlanetModel = mongoose.model("Planet");

module.exports = PlanetModel;