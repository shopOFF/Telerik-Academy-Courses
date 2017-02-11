/* globals requier module */
"use strict";

const mongoose = require("mongoose");

let superheroSchema = new mongoose.Schema({
    name: {
        type: String,
        required: true
    },
    secretIdentity: String,
    alignment: String,
    story: String,
    imageUrl: {
        type: String,
        required: true
    },
    fractions: [{}],
    powers: [{}],
    city: {},
    country: {},
    planet: {}
});

mongoose.model("Superhero", superheroSchema);

let SuperheroModel = mongoose.model("Superhero");

module.exports = SuperheroModel;