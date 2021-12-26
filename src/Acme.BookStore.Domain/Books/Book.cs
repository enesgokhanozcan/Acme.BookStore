using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{
    //Guid primary key type of the book entitiy.
    //AudiatedAggregateRoot added base auditing properties.For example CreationTime,CreatorId,LastModificationTime.
    public class Book : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public BookType Type { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.Now;
        public float Price { get; set; }

    }
}
