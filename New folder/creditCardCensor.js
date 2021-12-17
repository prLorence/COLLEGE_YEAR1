function censor(cardNumber) {

  const cardNumberString = cardNumber.toString(); // converts the card number to string 

  const cardNumberArray = cardNumberString.split(''); // splits the card number into an array

  for (let i = 0; i <= cardNumberArray.length - 4; i++) { 

    // NaN = Not a Number 
    // isNaN = checks if the current element is a number, could be true or false

    if (isNaN(cardNumberArray[i])) {
      return null;
    }

  }
  
  let lastFour = cardNumber.slice(-4) // get last 4 of a string (negative numbers indicate from the end)
  let rest = cardNumber.slice(0,-4) // get all but last numbers. Could also do string.length(-4)
  rest = rest.replace(/\S/g,'x') // replace with a regex find all instances of non-whitespace characters and replace with 'x'
  return rest+lastFour //combine and return
}

console.log(censor(`1234 5678 9100 1112`));


