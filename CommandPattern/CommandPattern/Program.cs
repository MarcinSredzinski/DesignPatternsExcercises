// See https://aka.ms/new-console-template for more information
using CommandPattern;
using CommandPattern.Command;

Console.WriteLine("Hello, World!");

var bankAccount = new BankAccount();
Console.WriteLine(bankAccount.ToString());
IUndoableCommand command = new BankAccountCommand(bankAccount, BankAccountCommand.Action.Deposit, 100);
command.Call();
Console.WriteLine(bankAccount.ToString());
command.Undo();
Console.WriteLine(bankAccount.ToString());