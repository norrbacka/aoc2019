﻿module Day2

    let d = "1,12,2,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,10,19,1,6,19,23,2,23,6,27,2,6,27,31,2,13,31,35,1,10,35,39,2,39,13,43,1,43,13,47,1,6,47,51,1,10,51,55,2,55,6,59,1,5,59,63,2,9,63,67,1,6,67,71,2,9,71,75,1,6,75,79,2,79,13,83,1,83,10,87,1,13,87,91,1,91,10,95,2,9,95,99,1,5,99,103,2,10,103,107,1,107,2,111,1,111,5,0,99,2,14,0,0"

    let part1() : int =
        let mutable skip = false
        d.Split ','
        |> Array.toList
        |> List.map int
        |> List.toArray
        |> fun n ->
            for position in Seq.filter 
                (fun x -> (x % 4) = 0) 
                (seq {0 .. n.Length}) do
                    if (skip.Equals(false)) then 
                        let inputPos1 = n.[position+1];
                        let inputPos2 = n.[position+2];
                        let outputPos = n.[position+3];
                        let a = n.[inputPos1]
                        let b = n.[inputPos2]   
                        match n.[position] with
                            | 1 -> Array.set n outputPos (a + b)
                            | 2 -> Array.set n outputPos (a * b)
                            | 99 -> skip <- true
                            | _ -> ()
            n.[0]
                    