open System

let String_stuff() = 

    let str1 = "This is a random string"

    let str2 = @"Ignore backslashes"

    let str3 = """ "I igrnore double quated and backslashes" """

    let str4 = str1 + " " + str2

    printfn "Length : %i "(String.length str4)

    printfn "%c" str1.[1]

    printfn "1st word: %s"(str1.[0..3]) // start at index 0 and go to 3

    let upper_str = String.collect (fun c -> sprintf"%c, " c) "commas"
String_stuff()

Console.ReadKey() |> ignore 