module Locales

open Fable.Core

[<Emit "Intl.DateTimeFormat().resolvedOptions().locale">]
let private currentLocale() : string = jsNative

type Locale =
    | Dutch
    | Spanish
    | Default

let initialBrowserLocale() =
    let locale = currentLocale().ToLower().Substring(0, 2)
    match locale with
    | "nl" -> Locale.Dutch
    | "es" -> Locale.Spanish
    | _ -> Locale.Default

type Translator(currentLocale) =
    member _.greet(name: string) =
        match currentLocale with
        | Dutch -> $"Hallo, {name}!"
        | Spanish -> $"Hola, {name}!"
        | Default -> $"Hello, {name}!"