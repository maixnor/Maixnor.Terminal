namespace Maixnor.Terminal;

public static class Statements
{
    public static string Help => 
@"
No need to worry, you are in a shell.
Just hammer away at your keyboard and 
find out what the commands do “¯\_(ツ)_/¯“.

Here is a list of commands:
  * maixnorfetch
  * help
  * clear
  * projects
  * source
  * github
  * linkedin
  * email
  * exit

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
        shortcut to the code: 'source'
  * A neural network for the MNIST dataset
  * A Webshop based on the northwind database
  * A Time Management system for work
  * A Minesweeper App for Android

Have a look on my 'github' account.
";

    public static string MaixnorFetch =>
@"
       ||\      /||         TM            guest@maixnor
       ||\\    //||                       -------------
       || \\  // ||                       OS: Can you guess?
       ||  \\//  ||                       Kernel: 5.15.8-zen1-1-zen
       ||        ||   \\ //               Uptime: too long
       ||        ||    \//                Packages: 12298.34
       ||        ||    /\\                Shell: mxnr
       ||        ||   // \\               Terminal: Maixnor
";
}