using System.Collections.Generic;
using System;
using System.Timers;

namespace TamagotchiFarm.Models
{
  public class Update
  {
    private static System.Timers.Timer aTimer;

    public Update()
    {
      SetTimer();
    }

    private static void SetTimer()
    {
         // Create a timer with a two second interval.
         aTimer = new System.Timers.Timer(2000);
         // Hook up the Elapsed event for the timer.
         aTimer.Elapsed += OnTimedEvent;
         aTimer.AutoReset = true;
         aTimer.Enabled = true;
     }

     private static void OnTimedEvent(Object source, ElapsedEventArgs e)
      {
          Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                            e.SignalTime);
          Tamagotchi.MoveTime();
      }
  }
}
