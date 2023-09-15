using System.Runtime.InteropServices;

namespace LibcSharp;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Ether_header
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.ETH_ALEN)]
    public byte[] ether_dhost; // destination eth addr

    [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.ETH_ALEN)]
    public byte[] ether_shost; // source ether addr

    public ushort ether_type; // packet type ID field
}