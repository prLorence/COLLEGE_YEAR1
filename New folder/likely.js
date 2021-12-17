function likely(array) {
 
  
  for (let i = 0; i <= array.length; i++) {
    
  let s = array[i] + array[i+1];
  
    if (array.length === 0 || s % 2 === 0) {
      return "Likely";
    } else {
      return "Unlikely";
    } 
    
  }
  
}

console.log(likely([7, -7, 30, 5, 10]));