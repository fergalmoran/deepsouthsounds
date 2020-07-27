using System;

namespace DSS.Api.Data.Annotations {
    [AttributeUsage(AttributeTargets.Property)]
    public class SlugFieldAttribute : Attribute {
        public string SourceField { get; }

        public SlugFieldAttribute(string sourceField) {
            SourceField = sourceField;
        }
    }
}
