// Write function avg which calculates average of numbers in given list.

function find_average(array) {
  var sumTotal = array.reduce(function(a, b) {
    return a + b;
  }, 0);
  
   var arrayLength = array.length;
   var average = sumTotal / arrayLength;
   
   return average;
   
}

// Read about array.reduce() method