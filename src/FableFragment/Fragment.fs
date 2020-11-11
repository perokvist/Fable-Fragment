module Fragments

open Fable.Core.JsInterop
//open Fable.Import

let window = Browser.Dom.window

let mutable myButton : Browser.Types.HTMLElement = unbox window.document.getElementById "buy-btn"
myButton.textContent <- "changed!"
