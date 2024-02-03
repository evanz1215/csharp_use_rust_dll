// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;

// 引用dll
[DllImport("rust_lib.dll", CallingConvention = CallingConvention.Cdecl)]
static extern int add_one(int x);

// 重新命名
static int AddOne(int x) => add_one(x);

// 調用
Console.WriteLine(AddOne(5));