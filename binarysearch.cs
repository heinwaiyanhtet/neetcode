public class Solution {

    public int BinarySearch(int[] nums, int target) {

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if(nums[mid] == target)
            {   
                Console.WriteLine(mid);
                return mid; 
            }else if(nums[mid] < target){
                left =  nums[mid] + 1; 
            }
            else if(nums[mid] > target){
                right =  nums[mid] - 1;
            }
        }

        return -1;
    }
}

Solution solution = new();
solution.BinarySearch([-1,0,3,5,9,12],9);

