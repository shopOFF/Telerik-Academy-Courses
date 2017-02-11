/* globals requier module */

"use strict";

module.exports = function(Superhero) {
    return {
        createSuperhero(name, secretIdentity, ...powers) {
            // createSuperhero("", "", "1", "2", "3") - така си създаваме нов обект
            // createSuperhero("", "", ["1", "2", "3"]) - може и така  да подадем масив от powers - благодарение на този if 
            if (Array.isArray(powers[0])) {
                powers = powers[0];
            }

            var superhero = new Superhero({
                name,
                secretIdentity,
                powers
            });

            return new Promise((resolve, reject) => {
                superhero.save((err) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(superhero);
                });
            });
        },
        getAllSuperheroes() {
            return new Promise((resolve, reject) => {
                Superhero.find((err, superheroes) => {
                    if (err) {
                        return reject(err);
                    }
                    return resolve(superheroes)
                });
            });
        },

        getSuperheroesWithPower(power) {
            return new Promise((resolve, reject) => {
                Superhero.find({
                    powers: {
                        $in: [power]
                    }
                }, (err, superheroes) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(superheroes)
                });
            });
        }
    };
};