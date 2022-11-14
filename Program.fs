// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

type WidgetCode = string

let WidgetCode1 = WidgetCode "W1234"
let WidgetCode2 = WidgetCode "W1234"

printfn "%b" (WidgetCode1 = WidgetCode2)
