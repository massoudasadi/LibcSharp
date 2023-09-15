![LibcSharp workflow](https://github.com/massoudasadi/LibcSharp/actions/workflows/dotnet.yml/badge.svg)

# LibcSharp
`libc` Bindings for C#


# Examples
```C#
using LibcSharp;

int pid = Libc.getpid();
Console.WriteLine($"Current process ID: {pid}");

int result = Libc.kill(pid, (int)Signal.KILL); // or you can use Constants.SIGKILL
Console.WriteLine($"Kill result: {result}");
```
