/* ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    Author:
    Developer: Xynous (Also known as "Evention")

    IMPORTANT!
    All credit goes to Xynous.
    DO NOT REMOVE CREDITS ON WHO DEVELOPED THIS CLASS, as I have worked hard to get this class working and still am.

*/
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System.Diagnostics;
using System.Threading;

namespace NS_ProcessDetectionModule
{
    public class ProcessDetectionModule
    {
        // ProcessDetection Method
        public static void ProcessDetection()
        {   
            // Infinite loop, what will constanly loop. This is to keep a constant check of what process are running on the Windows Operating System.
            for (;;)
            {
               
                // Passes String in parameters to var variable.
                foreach (var Process1 in Process.GetProcessesByName("Add process name here"))
                {
                    // Kills the process on dectection
                    Process1.Kill();

                    // Puts a 1 milliseconds sleep on the running thread. Basically puts a pause in the thread before execution.
                    Thread.Sleep(1000);
                }

                // Passes String in parameters to var variable.
                foreach (var Process2 in Process.GetProcessesByName("Add process name here"))
                {
                    // Kills the process on dectection
                    Process2.Kill();

                    // Puts a 1 milliseconds sleep on the running thread. Basically puts a pause in the thread before execution.
                    Thread.Sleep(1000);
                }

                // Passes String in parameters to var variable.
                foreach (var Process3 in Process.GetProcessesByName("Add process name here"))
                {
                    // Kills the process on dectection
                    Process3.Kill();

                    // Puts a 1 milliseconds sleep on the running thread. Basically puts a pause in the thread before execution.
                    Thread.Sleep(1000);
                }
                
                
                /* Add more foreach iterators here to add more process names to be detected */  
            }
        }
    }
}


