namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    public class ClassInitialization
    {
        public List<Contact> contactList;

        public ClassInitialization()
        {
            contactList = Soql.Query<Contact>("SELECT ID FROM Contact LIMIT 1");
        }

        public static Map<string, string> colorMap = new Map<string, string>();

        static ClassInitialization()
        {
            colorMap.put("red", "255, 0, 0");
            colorMap.put("cyan", "0, 255, 255");
            colorMap.put("magenta", "255, 0, 255");
        }
    }
}
