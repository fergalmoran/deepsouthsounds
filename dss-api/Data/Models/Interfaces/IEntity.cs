using System;

namespace DSS.Api.Data.Models.Interfaces
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime CreateDate { get; set; }
        DateTime UpdateDate { get; set; }
    }
}
