# Feliz.Bulma [![NuGet](https://img.shields.io/nuget/v/Feliz.Bulma.svg?style=flat)](https://www.nuget.org/packages/Feliz.Bulma/)

Bulma UI (https://bulma.io) wrapper for amazing Feliz DSL (https://github.com/Zaid-Ajaj/Feliz)

## Installation (recommended)
The easiest way is to use [Femto CLI](https://github.com/Zaid-Ajaj/Femto) tool which will take care of all dependencies including npm libraries.

    femto install Feliz.Bulma

## Installation (manual)
If you want to install this package manually, use usual NuGet package command 

    Install-Package Feliz.Bulma 

or using [Paket](http://fsprojects.github.io/Paket/getting-started.html) 

    paket add Feliz.Bulma 

but don't forget to add it to `package.json` file via `npm`/`yarn` command

    yarn add bulma  

## How does it work

This library brings Bulma UI elements into Zaid Ajaj's [Feliz](https://github.com/Zaid-Ajaj/Feliz) library.

Instead of writing 

```f#
Html.div [
    prop.className "columns"
    prop.children [
        Html.div [
            prop.className "column is-2"
            prop.children [
                Html.button [
                    prop.className "button"
                    prop.text "Click me"
                ]
            ]
        ]
    ]
]
```

you can write

```f#
Bulma.columns [
    Bulma.column [
        column.is2 // <-- note context helper here
        prop.children [
            Bulma.button "Click me"
        ]
    ]
]
```

Please note that this library is based on Feliz so you can still combine its syntax with Feliz.Bulma

```f#
Bulma.menu [
    Bulma.menuLabel "My Label"
    Bulma.menuList [
        Html.ul [                // <-- Normal Feliz elements
            Html.li "Option one" // <-- Normal Feliz elements
            Html.li "Option two" // <-- Normal Feliz elements
        ]
    ]
]
```

## How to start

Simply open `Feliz.Bulma` namespace in your code and start exploring available elements by typing `Bulma.<your element here>`.

To fully understand how the library was designed, it is more than recommended to go through official [Bulma UI documentation](https://bulma.io/documentation).