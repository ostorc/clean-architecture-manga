namespace Manga.Domain.Customers
{
    using System;
    using System.Collections.Generic;
    using Manga.Domain.ValueObjects;

    interface ICustomer
    {
        Guid Id { get; }
        Name Name { get; }
        SSN SSN { get; }
        IReadOnlyCollection<Guid> Accounts { get; }
        void Register(Guid accountId);
    }
}