using System.Runtime.InteropServices;

namespace LibcSharp;
public static class Libc
{
    private const string LibCPath = "libc";

    [DllImport(LibCPath)]
    public static extern int getpid();

    [DllImport(LibCPath)]
    public static extern int kill(int pid, int sig);
}