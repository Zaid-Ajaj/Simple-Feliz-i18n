module App

open Locales
open Feliz
open Feliz.Recoil

[<ReactComponent>]
let DutchButton() =
    let changeLocale = Recoil.useSetState(Atoms.locale)
    Html.button [
        prop.text "Dutch"
        prop.onClick(fun _ -> changeLocale(Dutch))
    ]

[<ReactComponent>]
let EnglishButton() =
    let changeLocale = Recoil.useSetState(Atoms.locale)
    Html.button [
        prop.text "English"
        prop.onClick(fun _ -> changeLocale(Default))
    ]

[<ReactComponent>]
let SpanishButton() =
    let changeLocale = Recoil.useSetState(Atoms.locale)
    Html.button [
        prop.text "Spanish"
        prop.onClick(fun _ -> changeLocale(Spanish))
    ]

[<ReactComponent>]
let LocalizedGreeting() =
    let translator = Recoil.useValue(Atoms.translator)
    Html.div [
        Html.h3 (translator.greet "John")
        Html.div [
            EnglishButton()
            DutchButton()
            SpanishButton()
        ]
    ]

[<ReactComponent>]
let Main() = Recoil.root [ LocalizedGreeting() ]