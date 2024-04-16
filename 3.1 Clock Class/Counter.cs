using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1_Clock_Class
{
    public class Counter
    {
        private int _count;
        private string _name="";

        public Counter(string name) {
        
            _name = name;  
            _count = 0;
        }   
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //public int Count
        //{
        //    get { return _count; } 
        //    set { _count = value; }

        //}

        public void increment()
        {
            _count++;
        }

        public void reset() { _count = 0; }

        public int Ticks
        {
            get { return _count; }
        }
    }
}
