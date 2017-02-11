module.exports = function(fractionsData) {
    fractionsData.createFraction("The Unfuckables", "evil", ["Earth", "Mars", "Jupiter"], ["Monkeyman", "Drunkman"])
        .then((fraction) => {
            console.log("Created new Fraction");
            console.log(fraction);
        })
        .catch(() => {
            console.log("Error");
            console.dir(err, { colors: true });
        });
}