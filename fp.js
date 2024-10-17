//function composition

const compose = (f,g) => (x) => f(g(x));

const add1 = (x) => x + 1;
const multiply2 = (x) => x * 2;

const addAndMultiply = compose(multiply2,add1);

const re = addAndMultiply(5);

console.log(re);