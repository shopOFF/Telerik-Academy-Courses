/* globals requier module */

"use strict";

module.exports = function(Country) {
    return {
        createCountry(name, planet) {
            var country = new Country({
                name,
                planet
            });

            return new Promise((resolve, reject) => {
                country.save((err) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(country);
                });
            });
        },

        getAllCountries() {
            return new Promise((resolve, reject) => {
                Country.find((err, countries) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(countries)
                });
            });
        }
    };
};