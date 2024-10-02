
//question 2 - Survey


// Question a) 

let studentsquiz: (int * string list) list = [
    (1, ["A"; "B"; "C"; "D"])
    (2, ["A"; "B"; "D"; "D"])
    (3, ["B"; "B"; "B"; "A"])
    (4, ["A"; "B"; "C"; "D"])
]


let countAnswer(studentsquiz: (int * string list) list) questionIndex answer  = 
    studentsquiz
    |> List.filter (fun (_, answers) -> answers.[questionIndex] = answer)
    |> List.length 

let counta =  countAnswer studentsquiz 0 "A"
let countb =  countAnswer studentsquiz 0 "B"
let countc =  countAnswer studentsquiz 0 "C"
let countd =  countAnswer studentsquiz 0 "D"
//printfn "Number of students who answered 'A' to question 1: %A %A %A %A" counta countb countc countd


//Question C

let countquestionsprocent indexqueston =  
    let counta =  countAnswer studentsquiz indexqueston "A"
    let countb =  countAnswer studentsquiz indexqueston "B"
    let countc =  countAnswer studentsquiz indexqueston "C"
    let countd =  countAnswer studentsquiz indexqueston "D"
    let (procenta:float) = float counta/4.0
    let (procentb:float) = float countb/4.0
    let (procentc:float) = float countc/4.0
    let (procentd:float) = float countd/4.0
    printfn "Answer A: %A  Answer B: %A Answer c:  %A Answer D: %A"  procenta procentb procentc procentd 

//printfn "procents to question 1%A" (countquestionsprocent 0 )
//printfn "procents to question 2%A" (countquestionsprocent 1 )
//printfn "procents to question 3%A" (countquestionsprocent 2 )
//printfn "procents to question 4%A" (countquestionsprocent 3 )

//Question D



let rec findMatchingStudents students =
    match students with
    | [] -> None  // Base case: no more students to check
    | (id, answers) :: tail ->
        // Check if any remaining student in the list has the same answers
        match List.tryFind (fun (_, ans) -> ans = answers) tail with
        | Some (matchingId, _) -> Some (id, matchingId)  // Found a match
        | None -> findMatchingStudents tail  // Recursively check the rest of the list

// Example usage
let students = [
    (1, [|1; 2; 3; 4|])
    (2, [|2; 3; 4; 1|])
    (3, [|1; 2; 3; 4|])
    (4, [|4; 3; 2; 1|])
]

match findMatchingStudents students with
| Some (id1, id2) -> printfn "Students %d and %d have the same answers." id1 id2
| None -> printfn "No students have the same answers."






//printfn"comparefunction %A" compare




