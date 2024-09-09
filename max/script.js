const maxValue = (nums) => {
  
    const numbers = [...nums];
    
    let maxValue = -Infinity;
      
    for(let i = 0; i<numbers.length; i++)
    {
       if(numbers[i] > maxValue)
         {
            maxValue = numbers[i];
         }   
    }

    return maxValue;
    
};

console.log(maxValue([4, 7, 2, 8, 10, 9]));