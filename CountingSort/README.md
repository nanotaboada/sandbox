# Time and Space Complexity

## Time Complexity

### Finding Min and Max

$O(n)$, where $n$ is the length of the input array.

### Initializing Occurrences Array

$O(k)$, where $k$ is the range of values `max - min + 1`.

### Counting Occurrences

$O(n)$, where $n$ is the length of the input array.

### Calculating Cumulative Occurrences

$O(k)$, where $k$ is the range of values `max - min + 1`)`.

### Building Sorted Array

$O(n)$, where n is the length of the input array.

The dominant terms are $O(n)$ and $O(k)$, and since $k$ can be at most $n$ in the worst case (when all values are distinct), the overall time complexity is $O(n + k)$.

## Space Complexity

### Occurrences Array

$O(k)$, where $k$ is the range of values `max - min + 1`.

### Sorted Array

$O(n)$, where $n$ is the length of the input array.

The overall space complexity is $O(k + n)$.

## Conclusion

The _Counting Sort_ algorithm has a linear time complexity when the range of input values is not significantly greater than the number of elements. It is a stable sorting algorithm and performs well when the input is within a limited range. However, it is important to note that its efficiency decreases when the range of input values becomes large.
