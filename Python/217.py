#217. Contains Duplicate
from typing import List

class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        hash = set(nums)
        nums1 = len(hash)
        nums2 = len(nums)

        if (nums1 != nums2):
            return True
        else:
            return False


def test_true():
    nums = [1,2,3,1]
    solution = Solution()
    assert solution.containsDuplicate(nums) == True

def test_false():
    nums = [1,2,3]
    solution = Solution()
    assert solution.containsDuplicate(nums) == False


if __name__ == '__main__':
    test_true()
    test_false()
    print("Everything passed")
