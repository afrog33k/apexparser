namespace ApexSharpDemo.ApexCode
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using SObjects;

    public interface IClassInterface : IClassInterfaceExt
    {
        string GetName();
    }
}
