# HelloWorld Console Writer

Currently this programme will write hello world in console

## How to see the output

Open HelloWorldWriter.sln using visual studio. Set HelloWorldWriterConsoleApplicationClient as startup project. Now run the programme.

## Changing implemantation

Currently this programe writes hello world in the console only. If you want to write in mobile, web or database you have to change code in Program.CS of HelloWorldWriterConsoleApplicationClient like bellow.
For web
```csharp
builder.RegisterType<WebHelloWorldWriter.WebHelloWorldWriter>().As<IHelloWorldWriter>();
```

For mobile
```csharp
builder.RegisterType<MobileHelloWorldWriter.MobileHelloWorldWriter>().As<IHelloWorldWriter>();
```

For database
```csharp
builder.RegisterType<DatabaseHelloWorldWriter.DatabaseHelloWorldWriter>().As<IHelloWorldWriter>();
```