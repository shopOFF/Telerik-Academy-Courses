module.exports = function(planetsData) {
    planetsData.createPlanet("Earth")
        .then((planet) => {
            console.log("Created new Planet");
            console.log(planet);
        })
        .catch(() => {
            console.log("Error");
            console.dir(err, { colors: true });
        });
}