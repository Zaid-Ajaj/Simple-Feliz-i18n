module Atoms

open Feliz.Recoil
open Locales

let locale = atom {
    key "locale"
    def (initialBrowserLocale())
}

let translator = selector {
    key "translator"
    get (fun getter -> Translator(getter.get(locale)))
}