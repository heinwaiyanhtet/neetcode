

// complment = target - nums[i]
// Two Sum
function TwoSum(nums, target) 
{
    let map = new Map();

    for (let i = 0; i < nums.length; i++) 
    {
        let complement = target - nums[i];
        
        if (map.has(complement)) 
        {
            return [map.get(complement), i];
        }
        
        map.set(nums[i], i);
    }

}


// function ValidAnagram

function isAnagram(s, t)    
{
    return s.split('').sort().join('') === t.split('').sort().join('');
}

let s = "racecar";
let t = "carrace";

console.log(isAnagram(s,t));




/// contain duplicate elements
function containsDuplicate(nums) 
{

    let set = new Set();

    for (let i = 0; i < nums.length; i++) 
    {

        if (set.has(nums[i])) 
        {
            return true;
        }

        set.add(nums[i]);

    }

    return false;
}



let numbers  = [1, 2, 3, 3]
console.log(containsDuplicate(numbers));




// revese array

function reverse(arr) 
{

    let n = arr.length;

    let temp = new Array(n);
    
    for (let i = 0; i < n; i++)
        temp[i] = arr[n - i - 1];

    for(i = 0 ; i < n; i ++)
        arr[i] = temp[i];

    return arr;

}

const arr = [1, 4, 3, 2, 6, 5];

const reverseArrary = reverse(arr);
console.log(reverseArrary);


