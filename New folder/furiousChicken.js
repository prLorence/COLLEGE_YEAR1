function furiousChicken(initialVelocity, angleInDegrees, time) {
  
  const gravity = 9.81;
  const theta = angleInDegrees * Math.PI / 180;
  let coordinates = [];
 
  let x = Math.round(initialVelocity * Math.cos(theta) * time);
  let y = Math.round(initialVelocity * Math.sin(theta) * time - 1/2 * gravity * Math.pow(time, 2)); 
  
  coordinates.push(x, y);
     
  return coordinates;

}