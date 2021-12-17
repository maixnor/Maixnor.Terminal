namespace Maixnor.Terminal;

public static class Statements
{
    public static string Help => 
@"
No need to worry, you are in a shell.
Just hammer away at your keyboard and 
find out what the commands do “¯\_(ツ)_/¯“.

Here is a list of commands:
  * help
  * clear
  * exit
  * projects
  * github
  * linkedin
  * email

If stranded hit the tab key once. 
It focuses the terminal input.
";

    public static string Email =>
@"
I have a few emails to choose from:

  * my personal one:      benjamin@meixner.org
  * reach me at school:   mei18930@spengergasse.at
  * my work email:        benjamin.meixner@centauri.at

Happy emailing ^^.  
";

    public static string Projects => 
@"
I have done a lot during my education and career.
This includes:

  * The terminal you are currently using
  * A neural network for the MNIST dataset
  * A Webshop based on the northwind database
  * A Time Management system for work
  * A Minesweeper App for Android

Have a look on my 'github' account.
";
}