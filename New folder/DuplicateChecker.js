function duplicateEncode(word){
  //code here

    let wordString = word.toString();
    let wordArray = wordString.split('');

    return wordArray.map((letter, index) => {
      if (letter == wordArray[index + 1]) {
        return "(";
      } else {
        return ")";
      }
    }).join(''); ;

    // checks all letter inside the array
    // all same letters  return a )
    // if not, return a (

    // let newWord = '';
    // for (let i = 0; i < wordArray.length; i++) {
    //   if () {
    //     newWord += ')';
    //   } else if (wordArray[i] != wordArray[i + 1] && wordArray[i] == wordArray[i - 1]) {
    //     newWord += '('; 
    //   } else if (wordArray[i] != wordArray[i + 1] && wordArray[i] != wordArray[i - 1]) {
    //     newWord += ')';
    //   } else {
    //     return newWord += "(";
    //    }

    // }
    // return newWord;


  
}

console.log(duplicateEncode("din"));
console.log(duplicateEncode("recede"));