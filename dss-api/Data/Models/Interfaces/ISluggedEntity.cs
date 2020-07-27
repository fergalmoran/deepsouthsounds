namespace DSS.Api.Data.Models.Interfaces
{
    public interface ISluggedEntity : IUniqueFieldEntity
    {
        string Slug { get; set; }
    }
}
