// create a program that counts the number of atoms of each element inside a formula

function countAtomsOfEachElementInFormula(formula) {
  
  const elements = {};

  for (let i = 0; i < formula.length; i += 1) {

    const currentElement = formula[i];
    if (currentElement.match(/[A-Z][a-z]*/)) {
      if (!elements[currentElement]) {
        elements[currentElement] = 0;
      }
    } 


    }

  return elements;
  
}

console.log(countAtomsOfEachElementInFormula('C6H12O6'));