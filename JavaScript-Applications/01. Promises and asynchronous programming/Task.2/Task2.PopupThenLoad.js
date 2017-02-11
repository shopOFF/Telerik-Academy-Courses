(function () {
    var div = document.createElement("div");
    div.innerHTML = "Redirecting to website in 2 seconds";
    document.body.appendChild(div);
    var promise = new Promise(function (resolve, reject) {
        setTimeout(function () {
            resolve(window.location = "http://www.tutorialspoint.com");
            // reject('something very bad happened')
        }, 2000);
    });

    spromise
        .then(function (data) {
            console.log(data);
        })
        .catch(function (error) {
            console.log(error);
        });
} ());