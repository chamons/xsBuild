using System;
using AppKit;
using Foundation;

namespace xsBuild
{
	static class MainClass
	{
		static void Main (string[] args)
		{
			NSApplication.Init ();

			string scriptName = Environment.GetEnvironmentVariable ("XS_START_DEBUG") != null ? "ScriptRun" : "ScriptBuild";
			NSUrl path = NSBundle.MainBundle.GetUrlForResource (scriptName, "txt");

			NSDictionary err;
			NSAppleScript appleScript = new NSAppleScript (path, out err);
			if (err != null)
				throw new InvalidOperationException (err.ToString ());
			appleScript.ExecuteAndReturnError (out err);
			if (err != null)
				throw new InvalidOperationException (err.ToString ());
		}
	}
}
