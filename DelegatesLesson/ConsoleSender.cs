using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesLesson
{
    class ConsoleSender : Isender
    {
        public void SendMessage(string text)
        {
            Console.WriteLine(text);
        }
    }
}
