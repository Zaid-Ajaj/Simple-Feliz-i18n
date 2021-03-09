module Main

open Feliz
open Browser.Dom
open Fable.Core.JsInterop

importAll "./styles/global.scss"

ReactDOM.render(
    App.Main(),
    document.getElementById "feliz-app"
)