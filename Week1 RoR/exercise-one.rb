# Write function avg which calculates average of numbers in given list.

def average_array(array)
  
  if array.length < 1
   return 0
  else 
    arraySum = array.inject(0) { |sum,x| sum + x }
    arrayLength = array.length
    arrayAverage = arraySum / arrayLength
  end 
end

average_array([17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16])

# Read about array.inject method
