using System;
using System.Runtime.InteropServices;

namespace IObitUnlocker.Wrapper
{
    [Flags]
    public enum LoadLibraryFlags : uint
    {
        None = 0
    }
    internal static class Native
    {

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hReservedNull, LoadLibraryFlags dwFlags);

        [DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string exportname);


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool FreeLibrary(IntPtr hModule);
    }
}
