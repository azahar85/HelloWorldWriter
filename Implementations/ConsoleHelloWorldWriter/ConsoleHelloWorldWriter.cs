using System;
using System.Collections.Generic;
using System.Text;

using HelloWorldWriter.Contract;


namespace ConsoleHelloWorldWriter
{
   public class ConsoleHelloWorldWriter : IHelloWorldWriter
    {
        public void WriteHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
}
