using Microsoft.VisualStudio.TestTools.UnitTesting;
using sample_bank_exercise_business.entities;
using sample_bank_exercise_interfaces.enums;
using System;

namespace sample_bank_exercise_tests;

[TestClass]
public class ScenarioBasedTests
{
    //Normally I might take advantage of the unit test framework to do initialization and teardown - but for this im just going to handle it within the 3 methods.

    
    [TestMethod]
    public void TestDeposit()
    {
        //arrange

        var deposit = new Deposit(500);


        var bank = new Bank("My Bank");
        bank.AddAccountToBank(new CheckingAccount("My Checking", 21));

        //act

        Assert.IsTrue(bank.Accounts[0].ExecuteTransaction(deposit));
        Assert.AreEqual(521, bank.Accounts[0].Balance);

        bank.Accounts[0].TransactionLogs.DisplayLog();


        //assert

    }

    //req - withdrawal on an individual investment account limited to 500
    [TestMethod]
    public void TestWithdrawal_Individual_LessThan_500()
    {
        var withdrawal = new Withdrawal(50);

        var startingBalance = 500;


        var bank = new Bank("My Bank");
        bank.AddAccountToBank(new InvestmentAccount("Investment Individual", InvestmentAccountType.Individual, startingBalance));

        Assert.IsTrue (bank.Accounts[0].ExecuteTransaction(withdrawal));
        Assert.AreEqual(450, bank.Accounts[0].Balance);

        bank.Accounts[0].TransactionLogs.DisplayLog();


    }

    [TestMethod]
    public void TestWithdrawal_Individual_Over_500_Fails()
    {
        var withdrawal = new Withdrawal(550);
        var startingBalance = 1000;


        var bank = new Bank("My Bank");
        bank.AddAccountToBank(new InvestmentAccount("Investment Individual", InvestmentAccountType.Individual, startingBalance));

        Assert.IsFalse(bank.Accounts[0].ExecuteTransaction(withdrawal));

        bank.Accounts[0].TransactionLogs.DisplayLog();
    }



    //req - withdrawal works normally for non-individual investment accounts.
    [TestMethod]
    public void TestWithdrawal_Corporate()
    {
        var withdrawal = new Withdrawal(550);
        var startingBalance = 1000;


        var bank = new Bank("My Bank");
        bank.AddAccountToBank(new InvestmentAccount("Investment Corporate", InvestmentAccountType.Corporate, startingBalance));

        Assert.IsTrue(bank.Accounts[0].ExecuteTransaction(withdrawal));
        Assert.AreEqual(450, bank.Accounts[0].Balance);
        bank.Accounts[0].TransactionLogs.DisplayLog();
    }

    [TestMethod]
    public void TestTransfer()
    {
        var startingBalance = 200;


        var transfer = new Transfer(100);

        var bank = new Bank("My Bank");
        bank.AddAccountToBank(new CheckingAccount("My Checking", startingBalance));
        bank.AddAccountToBank(new InvestmentAccount("Investment Individual", InvestmentAccountType.Individual, startingBalance));


        Assert.IsTrue(bank.Accounts[0].ExecuteTransaction(transfer,bank.Accounts[1]));
        Assert.AreEqual(100, bank.Accounts[0].Balance);
        Assert.AreEqual(300, bank.Accounts[1].Balance);

        //hmm probably should be on both accounts -
        bank.Accounts[0].TransactionLogs.DisplayLog();

    }
}