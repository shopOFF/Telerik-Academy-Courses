/* globals requier module */

"use strict";

module.exports = function(City) {
    return {
        createCity(name) {
            // createCity("") - така си създаваме нов обект
            var city = new City({
                name
            });

            return new Promise((resolve, reject) => {
                city.save((err) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(city);
                });
            });
        },
        getAllCities() {
            return new Promise((resolve, reject) => {
                City.find((err, cities) => {
                    if (err) {
                        return reject(err);
                    }
                    return resolve(cities)
                });
            });
        },
    };
};