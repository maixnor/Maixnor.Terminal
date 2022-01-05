
# Welcome fellow human!

This is the Maixnor Terminal, which is my very own interactive terminal running in the browser.

It is currently operating as an [Azure Static App](https://gray-moss-0be855b03.azurestaticapps.net).

### Inspiration

I really love the linux operating system and use it as my daily driver.
Therefore I really love terminals and will choose a good CLI over a GUI any time.
So when I wanted to have a personal/portfolio website I thought about packing it in a 
terminal-styled web app. And as for as I am concerned my idea is unique.
I also wanted to try out Blazor and dotnet 6, so here goes the tech stack.

### What to do here

You might be here for the easter egg, go ahead and look through the files. Happy looking :)

You can leave me an issue if there is anything you would like me to add to the terminal (like a command or another easter egg).

### Technologies used

I have used the Blazor Framework to build this app. 

The application is running in an [Azure Static App](https://gray-moss-0be855b03.azurestaticapps.net)
without any backend (being Azure Functions) or database. 
This app is purely client-sided by the way.

The deployment is done automatically using GitHub Actions.

### Prerequisites

If you want to have a Maixnor Terminal running locally you can do so.

All you need is the `dotnet sdk 6.0.x`.

You can start up the app using `dotnet watch run --project Maixnor.Terminal` and use the great
hot reload functionality introduced with dotnet 6. 
