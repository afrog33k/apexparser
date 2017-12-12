namespace Demo.CSharpClasses
{
    using Apex.ApexSharp;
    using Apex.ApexSharp.ApexAttributes;
    using Apex.System;
    using ApexSharpApi.ApexApi;
    using SObjects;

    [WithSharing]
    public class MethodComplex
    {
        public static void methodOne()
        {
            foreach (Account a in Soql.Query<Account>("SELECT Id FROM Account"))
            {
                System.debug(a.Id);
            }

            for (int i = 0; i<10; i++)
            {
            }
        }

        public Database.QueryLocator queryLocator(Database.BatchableContext bc)
        {
            return Database.getQueryLocator(Soql.Query<Contact>("SELECT Id FROM Contact"));
        }
    }
}
