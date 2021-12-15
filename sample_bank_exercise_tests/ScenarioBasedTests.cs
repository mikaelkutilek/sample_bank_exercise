using Microsoft.VisualStudio.TestTools.UnitTesting;
using sample_bank_exercise_business.entities;
using sample_bank_exercise_interfaces.enums;

namespace sample_bank_exercise_tests;

[TestClass]
public class ScenarioBasedTests
{
    //Normally I might take advantage of the unit test framework to do initialization and teardown - but for this im just going to handle it within the 3 classes.

    

  



    [TestMethod]
    public void TestDeposit()
    {
        //arrange

        var bank = new Bank("My Bank");
        bank.AddAccountToBank(new CheckingAccount("My Checking"));
        bank.AddAccountToBank(new InvestmentAccount("Investment Individual", InvestmentAccountType.Individual));
        bank.AddAccountToBank(new InvestmentAccount("Investment Corporate", InvestmentAccountType.Corporate));




        //bank.Accounts.Find(b => b.Name == "Investment Individual").ExecuteTransaction(new Transaction());







        //act

        //assert


    }

    [TestMethod]
    public void TestWithdrawal()
    {

    }

    [TestMethod]
    public void TestTransfer()
    {

    }

}