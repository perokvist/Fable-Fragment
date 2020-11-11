module HtmlViews

open Giraffe.ViewEngine

let layout (content: XmlNode list) =
    html [] [
        head [] [
            title []  [ str "Product" ]
            link [ _rel "stylesheet"; _href "/styles/product.css" ] 
        ]
        body [] [
        main [] content  
        script [ _src "/dist/fragment.fs.js" ] []
        ]
    ]

let partial () =
    p [] [ str "Some partial text." ]

let productView (model : Models.Product) =
        section [ _id "prodcut-page"; _class "product-wrapper"; ] [
        div [ _class "product" ] [
                img [ _src "/assets/monitor.png"; _class "product-image" ] 
                div [ _class "product-info" ] [
                    h2 [] [ str "Title" ]
                    div [_class "price" ] [ str "1200" ] 
                    button [ _id "buy-btn"; _class "buy-btn" ] [ str "buy"]
                ]
            ]
        div [] [ partial() ]
        ]

