/* ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Author: Ashleigh Day - (Xynous)
*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Threading;
using System.Diagnostics;

namespace NS_ProcessDetectionModule
{
    class ProcessDetectionModule
    {
        
        public static void ProcessDetection()
        {
            // Infinite for loop which will constanly loop to check the client.
            for (;;)
            {
                #region Internal (Injectors)

                // Injector Strings goes here what processes you want to detect.
                Process[] PC1I = Process.GetProcessesByName("Process you want to detect goes here");
                Process[] PC2I = Process.GetProcessesByName("Process you want to detect goes here");
                Process[] PC3I = Process.GetProcessesByName("Process you want to detect goes here");

                #endregion

                #region External (Applications)

                // External application strings goes here what processes you want to detect.

                Process[] PC1E = Process.GetProcessesByName("Process you want to detect goes here");
                Process[] PC2E = Process.GetProcessesByName("Process you want to detect goes here");
                Process[] PC3E = Process.GetProcessesByName("Process you want to detect goes here");

                #endregion

                #region Internal Checks

                // if the process array stores 1 element, then execute this if statement. In this case it is holding 1 element since the starting element starts at 1.
                if (PC1I.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process goes here to kill"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running). 
                        process1.Kill();

                        // Puts a 1 second sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }
                }

                // if the process array stores 1 element, then execute this if statement. In this case it is holding 1 element since the starting element starts at 1.
                else if (PC2I.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process goes here to kill"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running).
                        process1.Kill();

                        // Puts a 1 second sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }
                }


                // if the process array stores 1 element, then execute this if statement. In this case it is holding 1 element since the starting element starts at 1.
                else if (PC3I.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process goes here to kill"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running).
                        process1.Kill();

                        // Puts a 1 second sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }

                }

                else
                {
                    // Do nothing, will execute when all other if statements are false.

                }

                #endregion

                #region External Checks

                // if the process array stores 1 element, then execute this if statement. In this case it is holding 1 element since the starting element starts at 1.
                if (PC1E.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process goes here to kill"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running).
                        process1.Kill();

                        // Puts a 1 second sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }
                }

                // if the process array stores 1 element, then execute this if statement. In this case it is holding 1 element since the starting element starts at 1.
                else if (PC2E.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process goes here to kill"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running).
                        process1.Kill();

                        // Puts a 1 second sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }
                }

                // if the process array stores 1 element, then execute this if statement. In this case it is holding 1 element since the starting element starts at 1.
                else if (PC3E.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process goes here to kill"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running).
                        process1.Kill();

                        // Puts a 1 second sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }
                }

                else
                {
                    // Do nothing. will execute when all other if statements are false.
                }

                #endregion
            }
        }
    }
}
