using System;
using System.Collections.Generic;
using Protocal;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var acBuilder = Account.CreateBuilder();

            acBuilder.Account_ = "1324";
            acBuilder.Password = "456";
            byte[] buff = acBuilder.Build().ToByteArray();

            Account account = Account.ParseFrom(buff);
            Console.WriteLine("Account = " + account.Account_);
            Console.WriteLine("Password = " + (account.Password));

            Console.ReadKey();
        }
    }
}
