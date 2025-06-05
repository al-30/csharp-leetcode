// See https://aka.ms/new-console-template for more information
using csharp_leetcode.PlusOne;
using csharp_leetcode.RemoveDuplicatesFromSortedArray;
using csharp_leetcode.TwoSum;

Console.WriteLine("Hello, World!");

SolutionTwoSum sum = new SolutionTwoSum();
// int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

SolutionRemoveDuplicates rm = new SolutionRemoveDuplicates();
// rm.RemoveDuplicates(nums);
SolutionPlusOne pl = new SolutionPlusOne();

int[] nums = { 1,8,9,9 };
pl.PlusOne(nums);
