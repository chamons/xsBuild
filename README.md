# xsBuild

Script to invoke Build -> Build All in an open Xamarin Studio

# Instrucitions

* xbuild /p:Configuration=Release src/xsBuild.csproj
* mkdir -p ~/bin/
* cp -r src/bin/Release/xsBuild.app ~/bin/
* cp xsBuild ~/bin/
* System Preferences -> Security & Privacy -> Privacy Tab -> Accessibility and Add xsBuild and Terminal.app

# Why do you need a full Xamarin.Mac project for this?

Unfortunately osascript run from the command line is not allowed access to other applications:

/Users/donblas/bin/xsBuild.applescript:736:840: execution error: System Events got an error: osascript is not allowed assistive access. (-1719)

and it is not possible to add a script to System Preferences -> Security & Privacy -> Privacy Tab -> Accessibility

By creating a trivial Xamarin.Mac application, it can be added to that list (along with Terminal.app).

If there is a better way to handle this, Pull Requests are welcome.
