#1. Two Sum
from typing import List

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        for i in range(len(nums)):
            for j in range(i + 1, len(nums)):
                if (i != j and nums[i] + nums[j] == target): return [i, j]

        return []

def test_1():
    nums = [2,7,11,15]
    target = 9 
    solution = Solution()
    assert solution.twoSum(nums, target) == [0, 1]

def test_2():
    nums = [3,2,4]
    target = 6
    solution = Solution()
    assert solution.twoSum(nums, target) == [1, 2]

def test_3():
    nums = [3,3]
    target = 6
    solution = Solution()
    assert solution.twoSum(nums, target) == [0, 1]


if __name__ == '__main__':
    test_1()
    test_2()
    test_3()
    print("Everything passed")
