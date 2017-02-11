/* globals require */

"use strict"

const mongoose = require("mongoose");

mongoose.connect("mongodb://localhost/superheroes")


let Superhero = require("./models/superhero-model");

let superheroesData = require("./data/superheroes-data")(Superhero);

let controller = require("./controllers/superheroes-controller")(superheroesData);

// just a test fot crating cities
let City = require("./models/city-model");

let citiesData = require("./data/cities-data")(City);

let cityController = require("./controllers/cities-controller")(citiesData);