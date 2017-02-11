module.exports = function(countriesData) {
    countriesData.createCountry("Bulgaria", "Earth")
        .then((country) => {
            console.log("Created new Country");
            console.log(country);
        })
        .catch(() => {
            console.log("Error");
            console.dir(err, { colors: true });
        });
}