namespace _26;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
            return 0;
        var counter = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[counter] != nums[i])
            {
                counter++;
                nums[counter] = nums[i];
            }
        }
        return counter + 1;
    }
}
