namespace FSharpLibrary

open CSharpLibrary
open System.Runtime.InteropServices

module DoubleStack =
    type Pipeline =
        static member Pipe(left:DoubleStack, right:float) =
            left.Push(right)
            left
        static member Pipe(left:float, right:float) =
            let result = DoubleStack()
            result.Push(left)
            result.Push(right)
            result

    let inline private pipe< ^t, ^a when (^t or ^a) : (static member Pipe : ^a * float -> DoubleStack)> left right = ((^t or ^a) : (static member Pipe : ^a * float -> DoubleStack)(left, right))

    let inline ( |=> )(left:^a)(right:float) = pipe<Pipeline, ^a> left right

    let inline pop (stack:DoubleStack) = stack.Pop()

    let inline peek (stack:DoubleStack) = stack.Peek()

    let add (stack:DoubleStack) =
        stack.Add()
        stack

    let sub (stack:DoubleStack) =
        stack.Subtract()
        stack

    let mul (stack:DoubleStack) =
        stack.Multiply()
        stack

    let div (stack:DoubleStack) =
        stack.Divide()
        stack