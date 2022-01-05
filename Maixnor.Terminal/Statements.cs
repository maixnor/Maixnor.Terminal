namespace Maixnor.Terminal;

public static class Statements
{

    public static string Pwa =>
@"
This app you are currently using is a PWA.
This is short for 'Progressive Web App' which
means that you can install this application to
your machine (if you have a chrome-based browser).

Your browser will indicate that the application
can be installed. The installed version 
automatically fetches the newest version,
so no updates or reinstalling necessary.

There are no 'pwa exclusive' features like 
push notification or file system access in this
terminal so far.

This PWA has been made using Blazor WASM.
";
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
  * pwa
  * source
  * github
  * linkedin
  * email
  * exit

Click anywhere to initiate typing mode 
and put in some commands.
There is also an 'easter' egg :).
";

    public static string Email =>
@"
I have a few emails to choose from:

  * my personal one:      benjamin@meixner.org
  * reach me at school:   mei18930@spengergasse.at
  * my work email:        benjamin.meixner@centauri.at

Happy emailing ^^.  
";

    public static string Easter =>
@"
You have not found the easter egg.... yet.

In any case you can find it in the 'source'
rather easily.

Here are the clues one by one. 

* It has been computed after 
  seven and a half million years of thought

* It is a rather popular reference to 
  'The Hitchhiker's Guide to the Galaxy'.

* It may have something to do with the
  packages installed pacman.
";

    public static string Projects => 
@"
I have done a lot during my education and career.
This includes:

  * The terminal you are currently using 
        shortcut to the code: 'source'
  * A neural network for the MNIST dataset
  * A shopfront based on the northwind database
  * A Time Management system for work
  * A Minesweeper App for Android

Have a look on my 'github' account.
";

    public static string MaixnorFetch =>
        
@" 
 __       __                                 guest@maixnor
|  \     /  \                                -------------
| ▓▓\   /  ▓▓__    __ _______   ______       OS: Who can guess?
| ▓▓▓\ /  ▓▓▓  \  /  \       \ /      \      Kernel: 5.15.8-zen1-1-zen
| ▓▓▓▓\  ▓▓▓▓\▓▓\/  ▓▓ ▓▓▓▓▓▓▓\  ▓▓▓▓▓▓\     Uptime: too long
| ▓▓\▓▓ ▓▓ ▓▓ >▓▓  ▓▓| ▓▓  | ▓▓ ▓▓   \▓▓     Packages: 42 (pacman)
| ▓▓ \▓▓▓| ▓▓/  ▓▓▓▓\| ▓▓  | ▓▓ ▓▓           Shell: mxnr
| ▓▓  \▓ | ▓▓  ▓▓ \▓▓\ ▓▓  | ▓▓ ▓▓           Terminal: maixnor
 \▓▓      \▓▓\▓▓   \▓▓\▓▓   \▓▓\▓▓           Weather: look out the window!
";
    
}