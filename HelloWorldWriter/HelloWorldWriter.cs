using System;
using HelloWorldWriter.Contract;

namespace HelloWorldWriter
{
    public class HelloWorldWriter
    {
        public IHelloWorldWriter helloWorldWriter { get; set; }
        public HelloWorldWriter(IHelloWorldWriter helloWorldWriter)
        {
            this.helloWorldWriter = helloWorldWriter;
        }

        public void Write() {
            this.helloWorldWriter.WriteHelloWorld();
        }
    }
}
