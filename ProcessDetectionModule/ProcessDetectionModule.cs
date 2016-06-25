﻿/* ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Author:
    Developer: Xynous (Also known as "Evention")
    IMPORTANT!
    All credit goes to Xynous.
    DO NOT REMOVE CREDITS ON WHO DEVELOPED THIS CLASS, as I have worked hard to get this class working.
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
                Process[] PC1I = Process.GetProcessesByName("Process name here");
                Process[] PC2I = Process.GetProcessesByName("Process name here");
                Process[] PC3I = Process.GetProcessesByName("Process name here");

                #endregion

                #region External (Applications)

                // External application strings goes here what processes you want to detect.

                Process[] PC1E = Process.GetProcessesByName("Process name here");
                Process[] PC2E = Process.GetProcessesByName("Process name here");
                Process[] PC3E = Process.GetProcessesByName("Process name here");

                #endregion

                #region Internal Checks

                // If the cheat is not running, do nothing
                if (PC1I.Length == 0)
                {
                    // Do nothing.
                }

                // If the cheat is running, perform the following action/task.
                else if (PC1I.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process name here"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running). 
                        process1.Kill();

                        // Puts a 1 ms sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }
                }

                // If the cheat is not running, do nothing
                if (PC2I.Length == 0)
                {
                    // Do nothing
                }

                // If the cheat is running, perform the following action/task.
                else if (PC2I.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process name here"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running).
                        process1.Kill();

                        // Puts a 1 ms sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }
                }

                // If the cheat is not running, do nothing
                if (PC3I.Length == 0)
                {
                    // Do nothing
                }

                // If the cheat is running, perform the following action/task.
                else if (PC3I.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process name here"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running).
                        process1.Kill();

                        // Puts a 1 ms sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }
                }
                #endregion

                #region External Checks

                // If the cheat is not running, do nothing
                if (PC1E.Length == 0)
                {
                    // Do nothing.
                }

                // If the cheat is running, perform the following action/task.
                else if (PC1E.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process name here"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running).
                        process1.Kill();

                        // Puts a 1 ms sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }
                }

                // If the cheat is not running, do nothing
                if (PC2E.Length == 0)
                {
                    // Do nothing.
                }

                // If the cheat is running, perform the following action/task.
                else if (PC2E.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process name here"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running).
                        process1.Kill();

                        // Puts a 1 ms sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }
                }

                // If the cheat is not running, do nothing
                if (PC3E.Length == 0)
                {
                    // Do nothing.
                }

                // If the cheat is running, perform the following action/task.
                else if (PC3E.Length == 1)
                {
                    // Passes the process name string into process1 variable
                    foreach (var process1 in Process.GetProcessesByName("Process name here"))
                    {
                        // Kills game process or whatever process you passed and set to kill. So if the process is detected running (which is set above), then kill this process what is set here (if its running).
                        process1.Kill();

                        // Puts a 1 ms sleep on the thread to prevent exception error after process is killed.
                        Thread.Sleep(1000);
                    }
                }

                #endregion
            }
        }
    }
}
