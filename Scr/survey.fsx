
//question 2 - Survey


// Question a) 

//First methode
let studentsquiz: (int * string list) list = [
    (1, ["A"; "B"; "C"; "D"])
    (2, ["A"; "B"; "D"; "D"])
    (3, ["B"; "B"; "B"; "A"])
    (4, ["A"; "B"; "C"; "D"])
]

(*
Second methode
let student1 = ["A";"B";"C";"D"]
let student2 = ["A";"B";"D";"D"]
let student3 = ["B";"B";"B";"A"]
let student4 = ["A";"B";"C";"D"]
let studentsquiz = [1;2;3;4]
*)

//Question b)

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


// Function that finds the IDs of students with the same answers
let compare = 
    studentsquiz
    |> List.groupBy (fun (_, answers) -> answers) // group by the second element (answers)
    |> List.filter (fun (_, students) -> List.length students >= 2) // filter out groups with fewer than 2 students
    |> List.map (fun (_, students) -> List.map (fun (studentID, _) -> studentID) students) // extract the student IDs


printfn"comparefunction %A" compare




