using IosDemoApp;

// This is the main entry point of the application.
// If you want to use a different Application Delegate class from "AppDelegate"
// you can specify it here.
UIApplication.Main (args, null, typeof (AppDelegate));



var widget = new IosBindingLib.MyWidget();
widget.DoSomething();
