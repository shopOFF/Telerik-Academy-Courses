/* globals requier module */

"use strict";

module.exports = function(Fraction) {
    return {
        createFraction(name, alignment, planets, members) {
            var fraction = new Fraction({
                name,
                alignment,
                planets,
                members
            });

            return new Promise((resolve, reject) => {
                fraction.save((err) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(fraction);
                });
            });
        },

        getAllFractions() {
            return new Promise((resolve, reject) => {
                Fraction.find((err, fractions) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(fractions)
                });
            });
        }
    };
};