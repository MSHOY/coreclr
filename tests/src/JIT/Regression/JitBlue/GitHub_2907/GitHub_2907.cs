// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.CompilerServices;


public struct MyStruct
{
    public long v1;
    public long v2;

    public MyStruct(long a, long b)
    { v1 = a; v2 = b; }
}

class Program
{
    [MethodImplAttribute(MethodImplOptions.NoInlining)]
    static MyStruct Foo()
    {
        return new MyStruct(5,10);
    }
    
    static int Main()
    {
        MyStruct c1 = Foo();

        if (c1.v1 != 5)
        {
            Console.WriteLine("Fail");
            return -1;
        }

        if (c1.v2 != 10)
        {
            Console.WriteLine("Fail");
            return -1;
        }

        Console.WriteLine("Pass");
        return 100;
    }
}
