using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.Tick += new Clock.TickHandler(clock.tickPrint);
            clock.Alarm += new Clock.AlarmHandler(clock.alarmPrint);
            clock.start();
        }
    }
    class Clock
    {
        DateTime alarmTime = DateTime.Now;
        public void setAlarmTime(DateTime time)
        {
            alarmTime = time;
        }
        public delegate void AlarmHandler(DateTime nowtime);
        public delegate void TickHandler(DateTime nowtime);
        public event AlarmHandler Alarm;
        public event TickHandler Tick;
  
        public void tickPrint(DateTime nowtime)
        {
            Console.WriteLine("现在是"+DateTime.Now);
        }
        public void alarmPrint(DateTime nowtime)
        {
            Console.WriteLine(DateTime.Now + "到了");
        }
         public void start()
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                Tick(now);
                if (now.ToString() == alarmTime.ToString())
                {
                    Alarm(now);
                }
                System.Threading.Thread.Sleep(1000);
            }
        }   
     }
    
}
