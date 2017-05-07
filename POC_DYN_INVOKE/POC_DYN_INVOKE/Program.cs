using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace POC_DYN_INVOKE
{
    public class BindingDllClass
    {
        [DllImport(@"C:\Projects\POC_IMPORT_C_C#\POCDLL\Debug\POCDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Sum(double a, double b);
        [DllImport(@"C:\Projects\POC_IMPORT_C_C#\POCDLL\Debug\POCDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Subtract(double a, double b);
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            double a = 2;
            double b = 1;
            double c = BindingDllClass.Subtract(a, b);
            double d = BindingDllClass.Sum(a, b);

            Trace.WriteLine(string.Format("{0} - {1} = {2}", a, b, c));
            Trace.WriteLine(string.Format("{0} + {1} = {2}", a, b, d));
        }
    }
}
