printfn "Hello World from F#"

let square x = x * x

let num1 = square 2
printfn "square: %A" num1

[0..100] |> List.map square |> printfn "%A"

let squareToN n = [0..n] |> List.map square

squareToN 5 |> printfn "square: %A"