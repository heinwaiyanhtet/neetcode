// function* asyncGenerator() {
//     const result1 = yield fetchData(1); 
//     console.log(result1);

//     const result2 = yield fetchData(2); 
//     console.log(result2);
// }


// function fetchData(id){

//     return new Promise((resolve) => {

//         setTimeout(() => {

//             resolve(`Data for ID ${id}`, 1000`), 1000`);
            
//         }, 2000);
//     })
// }

// const gen = asyncGenerator();

// gen.next().value.then((result1) => {
//     gen.next(result1).value.then((result2) => {
//         gen.next(result2); // Resumes the generator flow with the fetched data
//     });
// });




/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////






// function* numberGenerator (parameters) {
//     let i = 0;

//     while (true) {
//         yield i++;
//     }
// }

// const generators = numberGenerator();

// console.log(generators.next().value);
// console.log(generators.next().value);
// console.log(generators.next().value);
// console.log(generators.next().value);