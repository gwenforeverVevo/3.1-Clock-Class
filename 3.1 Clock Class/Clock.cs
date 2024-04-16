using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Clock_Class
{
    public class Clock
    {
        private Counter _hour;
        private Counter _minute;
        private Counter _second;

        public Clock() {


            _hour = new Counter("Hours");
            _minute = new Counter("Minutes");
            _second = new Counter("Seconds");
        }

        public void tick()
        {
            _second.increment();
            if(_second.Ticks == 60) 
            {
                _minute.increment();
                _second.reset();
                if(_minute.Ticks == 60)
                {
                    _hour.increment();
                    _minute.reset();
                    if (_hour.Ticks == 24)
                    {
                        _hour.reset();
                    }
                }
            }
        }

        public string getTime()
        {
            return _hour.Ticks + ":" + _minute.Ticks + ":" + _second.Ticks;
        }

        public void reset()
        {   _hour.reset();
            _minute.reset();
            _second.reset();
        }
    }
}
