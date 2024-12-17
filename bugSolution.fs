let x = ref 1
let y = ref 2
let z = !x + !y
printf "%d\n" z
x := 3
let z2 = !x + !y // Recalculate to see the updated value
printf "%d\n" z2 // z2 will print 5

//Alternative solution using function
let calculateSum x y = x + y
let x1 = 1
let y1 = 2
let z1 = calculateSum x1 y1
printf "%d\n" z1
let x2 = 3
let z3 = calculateSum x2 y1
printf "%d\n" z3