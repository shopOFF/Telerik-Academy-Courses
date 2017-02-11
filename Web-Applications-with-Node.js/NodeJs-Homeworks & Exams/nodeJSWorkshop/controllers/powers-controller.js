module.exports = function(powersData) {
    powersData.createPower("Super sticky")
        .then((power) => {
            console.log("Created new Power");
            console.log(power);
        })
        .catch(() => {
            console.log("Error");
            console.dir(err, { colors: true });
        });
}