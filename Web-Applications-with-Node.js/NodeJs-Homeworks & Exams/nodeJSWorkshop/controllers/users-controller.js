module.exports = function(usersData) {
    usersData.createUser("Gosho12", "http://stanlemmens.nl/wp/wp-content/uploads/2014/07/bill-gates-wealthiest-person.jpg")
        .then((user) => {
            console.log("Created new User");
            console.log(user);
        })
        .catch(() => {
            console.log("Error");
            console.dir(err, { colors: true });
        });
}