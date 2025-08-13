using CodeLab.Facets.Models;
using Facet;

namespace CodeLab.Facets;

/// <summary>
/// This class will have all of the mappings we want using Facet
/// </summary>
internal class Facets
{
    /// <summary>
    /// Here we define a Facet for the Person model.
    /// The source is Person and the target is PersonDto.
    /// Then, we say that we want to exclude the Email property from the mapping.
    /// </summary>
    [Facet(typeof(Person), exclude: nameof(Person.Email))]
    public partial class PersonDto;
}