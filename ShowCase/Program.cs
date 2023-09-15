using LibcSharp;

int pid = Libc.getpid();
Console.WriteLine($"Current process ID: {pid}");

int result = Libc.kill(pid, (int)Signal.KILL); // or you can use Constants.SIGKILL
Console.WriteLine($"Kill result: {result}");
