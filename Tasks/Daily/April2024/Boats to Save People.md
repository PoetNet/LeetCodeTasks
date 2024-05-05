# Intuition

We use two pointers, left and right to point from the lightest to the heaviest person after sorting the array.

if left + right value is less then limit, we can hold both of them in the same boat, so we move both the pointer to their next values,  
i.e., left++ and right--

if left + right is > limit, then we can hold only the right person in the boat, so we move only the right pointer

we repeat the same process until left and right meets.

# Approach

The approach used in this solution is to sort the array of people by their weights. Then, we use a two-pointer technique where the left pointer starts at the beginning of the array and the right pointer starts at the end of the array.

We initialize a variable boats to keep track of the number of boats required. We iterate through the array using the left and right pointers, moving them towards each other.

At each step, we check if the sum of the weights of the person at the left pointer and the person at the right pointer is less than or equal to the limit (the maximum weight a boat can carry). If it is, we increment the left pointer to move to the next person, as both persons can fit into the boat.

If the sum exceeds the limit, it means only the person at the right pointer can fit into the boat, so we decrement the right pointer.

In each iteration, we increment the boats counter to keep track of the number of boats required. We continue this process until the left pointer crosses the right pointer, indicating that we have considered all people in the array.

Finally, we return the boats counter, which represents the minimum number of boats required to rescue all people.

# Complexity

- Time complexity:O(nlogn) Since we sort

- Space complexity:O(1) onlu two pointers are used