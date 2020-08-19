using System;

namespace Packt.Shared
{
    public class BankAccount
    {
        public string AccountName;
        public decimal Balance;
        public static decimal InterestRate; //shared member, meaning that this is shared accross all 'bankAccounts'


    }
}