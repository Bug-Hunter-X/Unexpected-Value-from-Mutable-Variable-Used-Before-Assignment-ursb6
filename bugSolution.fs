let mutable x = 0
printf "%d" x //Prints 0
x <- 1
let y = x + 1
printf "%d" y //Prints 2
//Alternatively, for functional style:
let x = ref 0
let y = !x + 1
x := 1
printf "%d" y //Prints 1
printf "%d" !x //Prints 1