﻿module TinyFS.Core.Utils

open FSharp.Compiler.Symbols

let convertInt (o: obj) =
    match System.Int32.TryParse(o.ToString()) with
    | true, int -> Some int
    | _ -> None

let convertUInt (o: obj) =
    match System.UInt32.TryParse(o.ToString()) with
    | true, uint -> Some uint
    | _ -> None

let determineExprPattern (expr) =
    match expr with
    | FSharpExprPatterns.AddressOf (a1) -> "AddressOf"
    | FSharpExprPatterns.AddressSet (a1, a2) -> "AddressSet"
    | FSharpExprPatterns.AnonRecordGet (p1, p2, p3) -> "AnonRecordGet"
    | FSharpExprPatterns.Application (p1) -> "Application"
    | FSharpExprPatterns.BaseValue (p1) -> "BaseValue"
    | FSharpExprPatterns.CallWithWitnesses (p1) -> "CallWithWitnesses"
    | FSharpExprPatterns.Call (p1) -> "Call"
    | FSharpExprPatterns.Coerce (p1) -> "Coerce"
    | FSharpExprPatterns.Const (p1) -> "Const"
    | FSharpExprPatterns.DebugPoint (p1) -> "DebugPoint"
    | FSharpExprPatterns.DecisionTreeSuccess (p1) -> "DecisionTreeSuccess"
    | FSharpExprPatterns.DecisionTree (p1) -> "DecisionTree"
    | FSharpExprPatterns.DefaultValue (p1) -> "DefaultValue"
    | FSharpExprPatterns.FSharpFieldGet (p1) -> "FSharpFieldGet"
    | FSharpExprPatterns.FSharpFieldSet (p1) -> "FSharpFieldSet"
    | FSharpExprPatterns.FastIntegerForLoop (p1) -> "FastIntegerForLoop"
    | FSharpExprPatterns.ILAsm (p1) -> "ILAsm"
    | FSharpExprPatterns.ILFieldGet (p1) -> "ILFieldGet"
    | FSharpExprPatterns.ILFieldSet (p1) -> "ILFieldSet"
    | FSharpExprPatterns.IfThenElse (p1) -> "IfThenElse"
    | FSharpExprPatterns.Lambda (p1) -> "Lambda"
    | FSharpExprPatterns.LetRec (p1) -> "LetRec"
    | FSharpExprPatterns.Let (p1) -> "Let"
    | FSharpExprPatterns.NewAnonRecord (p1) -> "NewAnonRecord"
    | FSharpExprPatterns.NewArray (p1) -> "NewArray"
    | FSharpExprPatterns.NewDelegate (p1) -> "NewDelegate"
    | FSharpExprPatterns.NewObject (p1) -> "NewObject"
    | FSharpExprPatterns.NewRecord (p1) -> "NewRecord"
    | FSharpExprPatterns.NewTuple (p1) -> "NewTuple"
    | FSharpExprPatterns.NewUnionCase (p1) -> "NewUnionCase"
    | FSharpExprPatterns.ObjectExpr (p1) -> "ObjectExpr"
    | FSharpExprPatterns.Quote (p1) -> "Quote"
    | FSharpExprPatterns.Sequential (p1) -> "Sequential"
    | FSharpExprPatterns.ThisValue (p1) -> "ThisValue"
    | FSharpExprPatterns.TraitCall (p1) -> "TraitCall"
    | FSharpExprPatterns.TryFinally (p1) -> "TryFinally"
    | FSharpExprPatterns.TryWith (p1) -> "TryWith"
    | FSharpExprPatterns.TupleGet (p1) -> "TupleGet"
    | FSharpExprPatterns.TypeLambda (p1) -> "TypeLambda"
    | FSharpExprPatterns.TypeTest (p1) -> "TypeTest"
    | FSharpExprPatterns.UnionCaseGet (p1) -> "UnionCaseGet"
    | FSharpExprPatterns.UnionCaseSet (p1) -> "UnionCaseSet"
    | FSharpExprPatterns.UnionCaseTag (p1) -> "UnionCaseTag"
    | FSharpExprPatterns.UnionCaseTest (p1) -> "UnionCaseTest"
    | FSharpExprPatterns.ValueSet (p1) -> "ValueSet"
    | FSharpExprPatterns.Value (p1) -> "Value"
    | FSharpExprPatterns.WhileLoop (p1) -> "WhileLoop"
    | FSharpExprPatterns.WitnessArg (p1) -> "WitnessArg"
    | _ -> "Unknown"
