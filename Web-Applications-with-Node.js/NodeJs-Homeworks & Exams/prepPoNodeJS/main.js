'use strict';

const mongodb = require('mongodb');
const MongoClient = mongodb.MongoClient;

const protocol = 'mongodb:/';
const server = 'localhost:27017';
const databaseName = 'Students';

const connectionString = `${protocol}/${server}/${databaseName}`;
//или вместо горното пишем едно и също е: const connectionString = 'mongodb://localhost:27017/Students';
// ето тука можем да си ровим в документацията и да видим кое, как, защо http://mongodb.github.io/node-mongodb-native/2.0/reference/connecting/connection-settings/
MongoClient.connect(connectionString)
    .then((db) => {
        const collectionName = "Names"; // за да е по прегледно си вадим името на колекцията(таблицата) в отделна променлива
        db.collection(collectionName) // иначе може и директно тука в скобите да си я напишем, като стринг и готово!с
            .insert({
                firstName: 'Ivan',
                lastName: 'Ivanov',
                age: '53'
            })
            .then((result) => {
                console.log(result);
            });
    })
    .catch((error) => {
        console.log(error);
    })