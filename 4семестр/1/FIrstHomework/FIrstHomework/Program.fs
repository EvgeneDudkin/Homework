let rec factorial x =
 if (x < 1) then 1 
 else factorial(x-1)*x

let testFactorial = factorial 5

printfn "%s" "Factorial 5 :"
printfn "%A" testFactorial

let rec fibonacci x =
 if (x < 3) then 1 
 else fibonacci(x-1) + fibonacci(x-2)

let testFibonacci = fibonacci 6

printfn "%s" "Fibonacci 6 :"
printfn "%A" testFibonacci 
