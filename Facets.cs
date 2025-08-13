using CodeLab.Facets.Mappings;
using CodeLab.Facets.Models;
using Facet;

namespace CodeLab.Facets;

/// <summary>
/// This class will have all of the mappings we want using Facet
/// </summary>
public class Facets
{
    /// <summary>
    /// Here we define a Facet for the Person model.
    /// The source is Person and the target is PersonDto.
    /// Then, we say that we want to exclude the Email property from the mapping.
    /// The configuration for the mapping is defined in the PersonMapConfig class, here we can override the mapping and add custom logic.
    /// </summary>
    [Facet(typeof(Person), exclude: [nameof(Person.Email), nameof(Person.Id)], Configuration = typeof(PersonMapConfig))]
    public partial class PersonDto;
}