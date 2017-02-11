module.exports = function(citiesData) {
    citiesData.createCity("Pazardjik")
        .then((city) => {
            console.log("Created new City");
            console.log(city);
        })
        .catch(() => {
            console.log("Error");
            console.dir(err, { colors: true });
        });

    // superheroesData.createSuperhero("Spiderman", "Peter Parker", "Super strength", "Wall crawling")
    //     .then((superhero) => {
    //         console.log("Created new superheroe");
    //         console.log(superhero);
    //     })
    //     .catch(() => {
    //         console.log("Error");
    //         console.dir(err, { colors: true });
    //     });
}