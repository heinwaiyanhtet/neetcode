
public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {

       foreach (var i in matrix)
       {
            int currentArray = 0;
            int left = 0;
            int right = matrix[currentArray].Length;
             while (left <= right)
             {
                int mid = ( left + (right - left) ) / 2;
                if( matrix[currentArray][mid] == target ){
                    return true;
                }
                else if(matrix[currentArray][mid] < target)
                {
                    left =  matrix[currentArray][mid] + 1; 
                }
                else if(matrix[currentArray][mid] > target){
                    right =  matrix[currentArray][mid]  - 1;
                }
             }
             currentArray++;
        }

            return false;
          
       }

    }



Solution solution = new();
bool search = solution.SearchMatrix([[1,3,5,7],[10,11,16,20],[23,30,34,60]],7);
Console.WriteLine(search);

// Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
// Output: true


// Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 13
// Output: false

