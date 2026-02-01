//*****************************************************************************
//** 3010. Divide an Array Into Subarrays With Minimum Cost I       leetcode **
//*****************************************************************************
//** Three cuts I place where the smallest leaders stand,                    **
//** Each subarray crowned by its first command,                             **
//** I scan for the cheapest trio to align,                                  **
//** And sum their starting stars to claim the minimum shine.                **
//*****************************************************************************

int minimumCost(int* nums, int numsSize) {
    int first = nums[0];
    int smallest = 100;
    int second = 100;
    for(int i = 1; i < numsSize; i++)
    {
        if(nums[i] < smallest)
        {
            second = smallest;
            smallest = nums[i];
        }
        else if (nums[i] < second)
        {
            second = nums[i];
        }
    }
    return first + smallest + second;
}