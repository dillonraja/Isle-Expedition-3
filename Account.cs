using System;
using System.Collections.Generic;
using System.Text;

namespace IsleExpeditions
{


}
/// <summary>
/// 
/// </summary>
class Account
{
    private static int lastAccountNumber = 0;
    #region Properties
    /// <summary>
    /// Unique account number
    /// </summary>
    public int AccountNumber { get; private set; }
    public string AccountName { get; set; }
    public decimal Balance { get; private set; }

    public string EmailAddress { get; set; }
    public DateTime CreatedDate { get; set; }
    #endregion

    #region Constructor
    public Account()
    {
        //lastAccountNumber += 1;
        AccountNumber = ++lastAccountNumber;
        CreatedDate = DateTime.UtcNow;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Deposit money into account
    /// </summary>
    /// <param name="amount">Amount to deposit</param>
    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public decimal Withdraw(decimal amount)
    {
        Balance -= amount;
        return Balance;
    }
    #endregion
}

   
        /// <summary>
        /// This is an enemy on these Expeditions that can occasionally give loot.
        /// The user inputs how many of "Mogu", "Pirates", "Void Dragons", "Vrykrul", ect. they have defeated and are shown the percentage based chance of how likely thay are to obtain an item.
        /// There are 3 inputs in which enemy unites and give values "Rare" enemies which are an added 1% chance, Elite enemies that are a .33% chance, and normal enemies which are a 0.05% chance added.
        /// A thing to note here is all enemies should have the same given calculation no matter what kind of enemy, but differing enemies give differing loot rewards.
        /// Overall equation should be ((A+(B*0.33)+(c*0.05)= Answer of % based chance of obtaining loot.
        /// 
        ///This information is public to the user and has no personal data.
        /// </summary>
        ///
        /// 
        ///
        //Issue found that it is uncertain how to enable the code to do a multiplaction problems or if the computer follows the rule of PEMDAS. Will edit in future version

