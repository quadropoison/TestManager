using System;
using System.Runtime.InteropServices;

namespace TestManager
{
    static class ExternalFunctionsImporter
    {
        private const string DllFilePath = "../../AppUnderTesting/SimpleRectangleShapeRotator.dll";

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        
        [DllImport(DllFilePath, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public extern static int main(int executionTimeLimit);

        [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl)]
        public extern static int exposeFullRotationsPerCycle();

        [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl)]
        public extern static float exposeFps();

        [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl)]
        public extern static float exposeDeltaTime();

        [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl)]
        public extern static double exposeFakeRenderTime();

        [DllImport(DllFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public extern static IntPtr exposeException();

        [DllImport(DllFilePath, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public extern static void forceExit();

        [DllImport(DllFilePath, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public extern static void setAppRunningStatusToFalse();

        [DllImport(DllFilePath, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        public extern static void destroyApp();                          
    }
}
