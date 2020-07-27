using DSS.Api.Data.Annotations;
using DSS.Api.Data.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DSS.Api.Data.Models {
    public static class EntityExtesions {

    }
    public class ApplicationUser : IdentityUser, ISluggedEntity {
        // Extended Properties

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long? FacebookId { get; set; }
        public string TwitterHandle { get; set; }

        public string PictureUrl { get; set; }

        [SlugField(sourceField: "FullName")]
        public string Slug { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
