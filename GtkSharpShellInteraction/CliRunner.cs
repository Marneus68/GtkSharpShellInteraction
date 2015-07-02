using System;
using System.IO;
using System.Threading;
using System.Diagnostics;


namespace GtkSharpShellInteraction
{
	public class CliRunner
	{
		public static void Run(string exName, string arguments, int timeoutSeconds, Func<String, String> writer) {
			StreamReader outputStream = StreamReader.Null;
			string ret = "";
			bool success = false;

			try {
				Process newProcess = new Process();
				newProcess.StartInfo.FileName = exName;
				newProcess.StartInfo.Arguments = arguments;
				newProcess.StartInfo.UseShellExecute = false;
				newProcess.StartInfo.CreateNoWindow = true;
				newProcess.StartInfo.RedirectStandardOutput = true;
				newProcess.Start();

				if (0 == timeoutSeconds)
				{
					outputStream = newProcess.StandardOutput;
					ret = outputStream.ReadToEnd();
					newProcess.WaitForExit();
				}
				else
				{
					success = newProcess.WaitForExit(timeoutSeconds * 1000);

					if (success)
					{
						outputStream = newProcess.StandardOutput;
						ret = outputStream.ReadToEnd();
					}
					/*
					else
					{
						ret = "Timed out at " + timeoutSeconds + " seconds waiting for " + exName + " to exit.";
					}
					*/
				}

			} catch(Exception e) {
				//throw (new Exception ("An error occurred running " + exeName + ".", e));
				Console.WriteLine("Exception: " + e.Message);
			} finally {
				outputStream.Close();
			}

			writer (ret);
		}
	}
}
	