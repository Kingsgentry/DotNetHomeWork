using System;
using System.Diagnostics.Tracing;
using System.Threading;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock(100, 10);
            new ClockPrinter(clock);

            clock.BeginCountDown();
        }
    }

    public class ClockPrinter
    {
        public ClockPrinter(Clock clock)
        {
            clock.tickEvent += TickPrint;
            clock.alarmEvent += AlarmPrint;
        }
        public void TickPrint()
        {
            Console.Write("T ");
        }

        public void AlarmPrint()
        {
            Console.WriteLine("Alarm!!");
        }
    }

    public class Clock
    {
        public delegate void ClockPrinterHandler();
        public event ClockPrinterHandler tickEvent;
        public event ClockPrinterHandler alarmEvent;

        private int countDown;
        private int alarmPeriod;


        public Clock(int countDown, int alarmPeriod)
        {
            this.countDown = countDown;
            this.alarmPeriod = alarmPeriod;
        }



        public void BeginCountDown()
        {

            Thread t = new Thread(new ThreadStart(CountDown));
            t.Start();

        }

        public void CountDown()
        {
            for(int i = this.countDown - 1; i > 0; i--)
            {
                if (i % alarmPeriod == 0)
                    alarmEvent();
                else
                    tickEvent();
                Thread.Sleep(1000);
            }



        }


        
    }
}
