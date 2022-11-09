using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FannieExercise
{
    internal interface IGreeting
    {
        public enum Greetings
        {
            Hello, Goodbye
        }

        public void SayHello();
        public string SendGreeting(Greetings greetings);
    }
}
