C# Boolean Logic Operations (XOR and NOT)


This C# program demonstrates basic Boolean logic operations using XOR (Exclusive OR) and NOT operators.
It generates a small truth table for these logical operations using loops.

The program iterates through all possible Boolean values (true and false) and prints the result of the operations.

Concepts Used

Boolean data type (bool)

Logical operators:

XOR (^)

NOT (!)

Nested loops

Console output

Code Explanation
1. XOR Operation

The program first prints the XOR truth table.

XOR returns true only when the two inputs are different.

Example:

A	B	A ^ B
false	false	false
false	true	true
true	false	true
true	true	false

The nested loops generate all possible combinations of true and false.

2. NOT Operation

The program then prints the NOT truth table.

NOT simply reverses the Boolean value.

Example:
FOR NOT GATE:
A	!A
false	true
true	false
