/* globals requier module */

"use strict";

module.exports = function(Planet) {
    return {
        createPlanet(name) {
            var planet = new Planet({
                name
            });

            return new Promise((resolve, reject) => {
                planet.save((err) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(planet);
                });
            });
        },

        getAllPlanets() {
            return new Promise((resolve, reject) => {
                Planet.find((err, planets) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(planets)
                });
            });
        }
    };
};