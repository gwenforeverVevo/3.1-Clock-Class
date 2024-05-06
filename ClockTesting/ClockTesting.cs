using _3._1_Clock_Class;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace ClockTesting
{
    [TestFixture]
    public class ClockTesting
    {
        [Test]
        public void InitialiseClock()
        {
            Clock clock = new Clock();
            ClassicAssert.AreEqual("00:00:00", clock.getTime());
        }
        [Test]
        public void TickClock()
        {
            Clock clock = new Clock();
            clock.tick();
            ClassicAssert.AreEqual("00:00:01", clock.getTime());
        }
        [Test]
        public void TickingClock()
        {
            Clock clock = new Clock();
            for (int i = 0; i < 3665; i++) // 1 hour, 1 minute, 5 seconds
            {
                clock.tick();
            }
            ClassicAssert.AreEqual("01:01:05", clock.getTime());
        }
        [Test]
        public void Reset()
        {
            Clock clock = new Clock();
            clock.tick();
            clock.reset();
            ClassicAssert.AreEqual("00:00:00", clock.getTime());
        }
    }

}
