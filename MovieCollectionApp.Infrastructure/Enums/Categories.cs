
using MovieCollectionApp.Infrastructure.Attributes;

namespace MovieCollectionApp.Infrastructure
{
    public enum Categories
    {
        [StringValue("Thriller")]
        Thriller = 1,
        [StringValue("Sci-fi")]
        SciFi,
        [StringValue("Comedy")]
        Comedy,
        [StringValue("Drama")]
        Drama
    }
}
