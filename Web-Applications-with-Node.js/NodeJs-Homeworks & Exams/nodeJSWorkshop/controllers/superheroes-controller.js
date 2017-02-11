module.exports = function(superheroesData) {
    // superheroesData.createSuperhero("Ironman", "Tony Stark", "Guns", "Lasers", "Stuff")
    //     .then((superhero) => {
    //         console.log("Created new superheroe");
    //         console.log(superhero);
    //     })
    //     .catch(() => {
    //         console.log("Error");
    //         console.dir(err, { colors: true });
    //     });

    // superheroesData.createSuperhero("Spiderman", "Peter Parker", "Super strength", "Wall crawling")
    //     .then((superhero) => {
    //         console.log("Created new superheroe");
    //         console.log(superhero);
    //     })
    //     .catch(() => {
    //         console.log("Error");
    //         console.dir(err, { colors: true });
    //     });

    superheroesData.getSuperheroesWithPower("Super strength")
        .then((superheroes) => {
            console.log(superheroes);
        });
}