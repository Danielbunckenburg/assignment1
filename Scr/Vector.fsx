//question #1



// Define vectors as tuples of floats
let x = (2.0, 3.0) // x is a vector (2.0, 3.0)
let y = (1.0, 2.0) // y is a vector (1.0, 2.0)

// Function to calculate the length (magnitude) of a vector
let lengthOfVector (vector: float * float) = 
    sqrt ((fst vector * fst vector) + (snd vector * snd vector))

// Function to add two vectors
let addOfVector (vector1: float * float) (vector2: float * float) = 
    (fst vector1 + fst vector2, snd vector1 + snd vector2)

// Function to scale a vector by a given scalar value
let scaleOfVector (vector: float * float) (scale: float) = 
    (fst vector * scale, snd vector * scale)

// Uncomment the following lines to test the functions
printfn "%A" (lengthOfVector x)      
printfn "%A" (addOfVector x y)       
printfn "%A" (scaleOfVector x 2.0)   
