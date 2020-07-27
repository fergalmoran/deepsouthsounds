using System.Collections.Generic;
using DSS.Api.Data.Annotations;

namespace DSS.Api.Data.Models
{
    public class AudioItem : BaseEntity
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public virtual List<Tag> Tags { get; set; }

        public ApplicationUser User { get; set; }

        [SlugField(sourceField: "Title")]
        public string Slug { get; set; }
    }
}
