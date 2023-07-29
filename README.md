# O(1)-Sum-Of_The-Sequence

We need to calculate the sum of all numbers through 1 to N inclusively

As we can see for number 6: 

1+2+3+4+5+6 = 21
Equal to:
(1+6)+(2+5)+(3+4)= 7×3 = 21

And for number 7:
1+2+3+4+5+6+7 = 28
(1+6)+(2+5)+(3+4)+7 = 7*4 = 28

Based on this information, we can write a method that quickly sums a sequence of numbers.
The code presents a regular loop for comparison and a method that calculates the sum of the 
entire sequence of digits from 1 to N in three operations (bitwise shift, incrementation,multiplication).
