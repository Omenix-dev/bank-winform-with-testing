using System.Collections.Generic;
using System;

namespace Utility
{
    public static class AccountGenerator
    {
        private static List<string> AccountHistory = new List<string>();
        public static string Generate()
        {
            var accountNumber = "";
            while (true)
            {
                string AccountNumberGenerator = "0000000000";
                var Random = new Random();
                int NumberGenerated = Random.Next(0, 10000);
                int len = NumberGenerated.ToString().Length;
                accountNumber = $"{AccountNumberGenerator.Substring(0, 10 - len)}{NumberGenerated.ToString()}";
                if (AccountHistory.Contains(accountNumber))
                {
                    // unreachable by test testatable
                    continue;
                }
                else
                {
                    break;
                }
            }
            AccountHistory.Add(accountNumber);
            return accountNumber;
        }
    }
}
