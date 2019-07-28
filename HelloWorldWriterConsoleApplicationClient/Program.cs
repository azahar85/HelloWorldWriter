using System;
using Autofac;
using HelloWorldWriter;
using ConsoleHelloWorldWriter;
using HelloWorldWriter.Contract;

namespace HelloWorldWriterConsoleApplicationClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ConsoleHelloWorldWriter.ConsoleHelloWorldWriter>().As<IHelloWorldWriter>();
            builder.RegisterType<HelloWorldWriter.HelloWorldWriter>().As<HelloWorldWriter.HelloWorldWriter>();

            IContainer Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                var helloworldwriter = scope.Resolve<HelloWorldWriter.HelloWorldWriter>();
                helloworldwriter.Write();
            }
        }
    }
}
