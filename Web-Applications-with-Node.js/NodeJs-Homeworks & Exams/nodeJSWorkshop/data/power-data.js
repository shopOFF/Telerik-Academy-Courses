/* globals requier module */

"use strict";

module.exports = function(Power) {
    return {
        createPower(name) {
            var power = new Power({
                name
            });

            return new Promise((resolve, reject) => {
                power.save((err) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(power);
                });
            });
        },

        getAllPowers() {
            return new Promise((resolve, reject) => {
                Power.find((err, powers) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(powers)
                });
            });
        }
    };
};