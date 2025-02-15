﻿module TinyFS.Test.Helpers

open Fable
open TinyFS.Test.TestObjs
open Wasmtime
open TinyFS.Shared.Objs



let printWasm (bytes: byte list) =
    let stringRepresentation =
        bytes
        |> List.map (fun by -> by.ToString())
        |> String.concat ""
    //let str = stringRepresentation |> String.concat ""
    System.IO.File.WriteAllText("./atest.txt", stringRepresentation)
    System.IO.File.WriteAllBytes("./atest.wasm", List.toArray bytes)

let private buildInstance (wasmBytes: byte list) =
    let engine = new Engine()

    let byteArray = List.toArray wasmBytes
    let modd = Module.FromBytes(engine, "fsharpWasm", byteArray)

    let linker = new Linker(engine)
    let store = new Store(engine)

    linker.Instantiate(store, modd)

let runFuncInt32Return (funcName: string) (wasmBytes: byte list) =
    let instance = buildInstance wasmBytes

    let func = instance.GetFunction<int32>(funcName)
    func.Invoke()

let makeCompiler (input: string) =
    let compilerOptions = CompilerOptionsHelper.Make()
    let compiler = TestCompiler("test", compilerOptions, input)
    compiler
