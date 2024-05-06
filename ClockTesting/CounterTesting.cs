using _3._1_Clock_Class;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace ClockTesting
{
    [TestFixture]
    public class CounterTesting
    {
        

        [Test]
        public void Counter_Initialization_IsZero()
        {
            Counter count = new Counter("Test");
            int getCount = count.Ticks;
            ClassicAssert.AreEqual(0, getCount);
            //NUnit.Framework.Assert.That(getCount, Is.EqualTo(0));

        }

        [Test]
        public void Counter_Increment_AddsOneToCount()
        {
            
            Counter counter = new Counter("TestCounter");
            counter.increment();
            int count = counter.Ticks;
            ClassicAssert.AreEqual(1, count);
        }

        [Test]
        public void Counter_MultipleIncrement_IncreasesCountToMatch()
        {
        
            Counter counter = new Counter("TestCounter");

       
            counter.increment();
            counter.increment();
            counter.increment();
            int count = counter.Ticks;

       
            ClassicAssert.AreEqual(3, count);
        }

        [Test]
        public void Counter_ResettingTimer_SetsCountToZero()
        {
       
            Counter counter = new Counter("TestCounter");

     
            counter.increment();
            counter.reset();
            int count = counter.Ticks;


            ClassicAssert.AreEqual(0, count);
        }
    }   
}