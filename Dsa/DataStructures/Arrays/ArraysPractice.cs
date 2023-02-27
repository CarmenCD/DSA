namespace DataStructures.Arrays
{
    public class ArraysPractice
    {
        /// <summary>
        /// Remove Element
        /// Time O(n); Space O(1)
        /// https://leetcode.com/explore/featured/card/fun-with-arrays/526/deleting-items-from-an-array/3247/
        /// </summary>
        /// <param name="input"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] input, int val)
        {
            var left = 0;
            var right = input.Length - 1;

            //validation
            if (input.Length == 0)
                return 0;

            while (left < right)
            {
                if (input[right] == val)
                {
                    right--;
                    continue;
                }

                if (input[left] != val)
                {
                    left++;
                    continue;
                }

                if (input[left] == val)
                {
                    if (input[right] == val)
                    {
                        right--;
                        continue;
                    }

                    var temp = input[left];
                    input[left] = input[right];
                    input[right] = temp;
                    right--;
                }
            }

            if (input[right] == val) return left;
            return left + 1;
        }

        /// <summary>
        /// Duplicate Zeros
        /// T - O(n); S - O(1)
        /// https://leetcode.com/explore/featured/card/fun-with-arrays/525/inserting-items-into-an-array/3245/
        /// </summary>
        /// <param name="arr"></param>
        public void DuplicateZeros(int[] arr)
        {
            var countZero = 0;
            var arrLength = arr.Length - 1;

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    countZero++;
            }
            
            while (arrLength > 0 && countZero > 0)
            {
                if (arrLength + countZero <= arr.Length - 1)
                    arr[arrLength + countZero] = arr[arrLength];

                if (arr[arrLength] == 0)
                    countZero--;

                arr[arrLength] = 0;
                arrLength--;
            }
        }
    }
}
