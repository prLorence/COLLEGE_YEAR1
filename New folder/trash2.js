function countElement(molecule) {
  // your code here
  var element = {};
  var elementArray = molecule.split(/[^A-Z]/);
  for (var i = 0; i < elementArray.length; i++) {
    if (elementArray[i] in element) {
      element[elementArray[i]] += 1;
    } else {
      element[elementArray[i]] = 1;
    }
  }
  return element;
}

console.log(countElement("H2O"));