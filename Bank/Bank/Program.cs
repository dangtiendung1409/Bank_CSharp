using System;
using Bank.demo1;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000);

        account.BalanceChanged += Account_BalanceChanged;

        Console.WriteLine($"Số dư hiện tại: {account.Balance}");

        account.Deposit(500);
        account.Withdraw(200);

        Console.WriteLine($"Số dư cập nhật: {account.Balance}");
    }

    private static void Account_BalanceChanged(object sender, EventArgs e)
    {
        Console.WriteLine("Số dư đã được thay đổi");
    }
}
