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
        [DllImport(@"C:\Projects\Epson\POC_C++_C#\POCDLL\Debug\POCDLL.dll")]
        public static extern double Calc(double a, double b);
        [System.Runtime.InteropServices.DllImport(@"C:\Projects\Epson\POC_C++_C#\POCDLL\Debug\POCDLL.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern double Subtract(double a, double b);
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            double a = 2;
            double b = 1;
            double c = BindingDllClass.Subtract(a, b);

            Trace.WriteLine(string.Format("{0} - {1} = {2}", a, b, c));
        }
    }
}
