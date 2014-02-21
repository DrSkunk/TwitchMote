TwitchMote
========
Simple chat to key emulator for Twitch IRC.

It uses the following assets and libraries:

* [Pokemon Pixel Font](http://www.fonts2u.com/pokemon-pixel-font-regular.font "pixel font").
* [ChatSharp IRC library](https://github.com/SirCmpwn/ChatSharp "irc")
* [Windows input simulator](http://inputsimulator.codeplex.com/ "inputsimulator")

[Download the compiled binary here.](https://github.com/whitebird/TwitchMote/releases "compiled binary")

How does it work?
--------
The program connects to an irc server and channel and reads every message said in that channel. If the message corresponds with one of the settings, it emulates a keypress.

The program is divided in three forms; Main form, keyboard configuration form and command form.

### Main form
This is the form that opens when you launch the program. It allows you to set the  game name, irc parameters as well as the optional Nickserv password.

You should note that on writing this page the twitch irc servers aren't stable enough.

From here you can start the irc client and open the keyboard settings.

![Main form](http://i.imgur.com/iYq5f65.png "Main form")

### Keyboard configuration
Here you set the irc command to the corresponding emulated key. In this example: when you give the command "up" it emulates the button "I". The "MENU" modifier is a fancy word for "ALT".

[A complete list of all keys can be found here](KEYS.md "keys")

![Keyboard configuration form](http://i.imgur.com/9TRKYfH.png "Keyboard configuration form")


### Commands
This is opened along with the main form. Most of the times it's hidden behind the main form.

It shows the name of the game, server time, elapsed time and the 10 most recent commands.

When broadcasting, this is the windows you capture.

![Commands form](http://i.imgur.com/JIka8sI.png "Commands form")

Example setup
--------
In this setup Pokemon is played in an emulator.

![Example setup](http://i.imgur.com/jahIV6l.jpg "Example setup")