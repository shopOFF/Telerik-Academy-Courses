/* globals requier module */

"use strict";

module.exports = function(User) {
    return {
        createUser(username, imageUrl) {
            var user = new User({
                username,
                imageUrl
            });

            return new Promise((resolve, reject) => {
                user.save((err) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(user);
                });
            });
        },

        getAllUsers() {
            return new Promise((resolve, reject) => {
                User.find((err, users) => {
                    if (err) {
                        return reject(err);
                    }

                    return resolve(users)
                });
            });
        }
    };
};