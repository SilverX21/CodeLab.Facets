using CodeLab.Facets.Models;
using Facet.Mapping;

namespace CodeLab.Facets.Mappings;

/// <summary>
/// Here we can override the mapping and add custom logic.
/// </summary>
public class PersonMapConfig : IFacetMapConfiguration<Person, PersonDto>
{
    public static void Map(Person source, PersonDto target)
    {
        target.FirstName = $"{source.FirstName} {source.LastName}";
        target.Birthday = source.Birthday.ToUniversalTime();
    }
}