# Unexpected Behavior with Mutable Variables in F# Expressions

This example demonstrates a potential point of confusion for developers new to F#. While F# is known for its immutability, the use of `mutable` allows modification of variables.  However, this modification doesn't retroactively change the value in expressions where the variable was previously used. 

The `bug.fs` file shows the issue. The `bugSolution.fs` file provides a solution using functions or recalculating to address the unexpected behavior.

## Solution
The `bugSolution.fs` file provides two solutions: One recalculates z after changing x, and another uses a function to return the sum for better clarity and immutability.