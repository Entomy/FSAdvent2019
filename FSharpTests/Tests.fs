namespace FSharpTests

open CSharpLibrary
open FSharpLibrary.DoubleStack
open Xunit

module DoubleStackTests =

    [<Fact>]
    let ``3 * 5 - 8`` () =
        let stack = 3.0 |=> 5.0 |> mul |=> 8.0 |> sub
        Assert.Equal(7.0, peek stack)
        ()