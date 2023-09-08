using LibcSharp;

int pid = Libc.getpid();
Console.WriteLine($"Current process ID: {pid}");