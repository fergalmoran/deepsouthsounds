using System;
using System.ComponentModel.DataAnnotations.Schema;
using DSS.Api.Data.Interfaces;

namespace DSS.Api.Data.Models
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDate { get; set; } = DateTime.UtcNow;

    }
}
