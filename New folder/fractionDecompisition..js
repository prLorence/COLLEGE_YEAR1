// create a fraction decomposition calculator for a given fraction

function fractionDecompose(n) {
  if (!isNumber(parseInt(n))) return 'Not a number';
  let result = '';

  if (n === 0) {
    result = '0';
  } else {
    let n1 = Math.floor(n);
    let n2 = n - n1;
    if (n1 === 0) {
      result = n2.toString();
    } else {
      result = n1.toString() + ' ';
      result += '1/' + n2.toString();
    }
  }
  return result;

}

function isNumber(n) {
  return typeof n === 'number' && !isNaN(n);
}



console.log(fractionDecompose("2/3"));