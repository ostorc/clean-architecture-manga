namespace Manga.Domain.Accounts
{
    using System;
    using Manga.Domain.ValueObjects;

    interface IDebit
    {
        Guid Id { get; }
        Guid AccountId { get; }
        Amount Amount { get; }
        string Description { get; }
        DateTime TransactionDate { get; }
    }
}