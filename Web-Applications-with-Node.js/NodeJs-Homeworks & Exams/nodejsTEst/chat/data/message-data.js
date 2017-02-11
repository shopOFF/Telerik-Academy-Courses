// /* globals requier module */

// "use strict";

// module.exports = function(Message) {
//     return {
//         createMessage(author, content, date) {
//             var message = new Message({
//                 author,
//                 content,
//                 date
//             });

//             return new Promise((resolve, reject) => {
//                 message.save((err) => {
//                     if (err) {
//                         return reject(err);
//                     }

//                     return resolve(message);
//                 });
//             });
//         }
//     };
// };