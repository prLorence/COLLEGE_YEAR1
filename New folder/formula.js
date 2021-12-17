function parseMolecule(formula) {
  //code here

  const formulaArray = formula.split('');

  formulaArray.map((element, atom, index) => {

    element = parseInt(formulaArray[index]);
    atom = parseInt(formulaArray[index + 1]);

    if (typeof element === 'string') {

      if (typeof atom === 'number') {
        return a += `${element}: ${atom}`;
      } else if (typeof atom === 'string') {
        return a += `${element}: ${atom}`;
      }
    }

  })



 
  
    
}

console.log(parseMolecule("H2O"));