class Stat {
  constructor(data) {
    this.data = data
  }

  get mean() {

    let sum = 0;

    for (let i in data) {
      sum += data[i]
    }

    let numberOfItems = data.length;

    return sum / numberOfItems;
    
  }

  get median() {
    
    values.sort(function(first,last){
    return first - last;
    });
    
    let middle = Math.floor(values.length / 2);
    
    if (values.length % 2)
      return values[half];
    
    return (values[half - 1] + values[half]) / 2.0;
  }

  get mode() {
    let modeList = [];
    
    if (data.length === 0)
      return null;
    
    
    for (let i = 0; i < data.length; i++) {
      let pointer;
      
      if (pointer[i] == pointer[i - 1] ) {
        return numList.push(pointer[i])
      } else {
        return;
      }
    }
    
  }

  get range() {
    // code here
  }
}
