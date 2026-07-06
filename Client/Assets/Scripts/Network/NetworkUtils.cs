using System;
using System.Runtime.InteropServices;

public static class NetworkUtils
{
    public static byte[] Serialize<T>(T packet) where T : struct
    {
        int size = Marshal.SizeOf(packet);
        byte[] arr = new byte[size];
        IntPtr ptr = Marshal.AllocHGlobal(size);

        Marshal.StructureToPtr(packet, ptr, true);
        Marshal.Copy(ptr, arr, 0, size);
        Marshal.FreeHGlobal(ptr);

        return arr;
    }

    public static T Deserialize<T>(byte[] data) where T : struct
    {
        int size = Marshal.SizeOf(typeof(T));
        IntPtr ptr = Marshal.AllocHGlobal(size);

        Marshal.Copy(data, 0, ptr, size);
        T packet = Marshal.PtrToStructure<T>(ptr);
        Marshal.FreeHGlobal(ptr);

        return packet;
    }
}