namespace Manga.Domain.Accounts
{
    using System;
    using System.Collections.Generic;
    using Manga.Domain.ValueObjects;

    public interface IAccount
    {
        Guid Id { get; }
        Guid CustomerId { get; }
        IReadOnlyCollection<ITransaction> GetTransactions();
        void Deposit(Amount amount);
        void Withdraw(Amount amount);
        void Close();
        Amount GetCurrentBalance();
        ITransaction GetLastTransaction();
    }
}