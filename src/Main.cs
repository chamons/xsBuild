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
			NSUrl path = NSBundle.MainBundle.GetUrlForResource ("Script", "txt");

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
