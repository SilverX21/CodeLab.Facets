using BenchmarkDotNet.Attributes;
using CodeLab.Facets.Models;
using Facet.Extensions;

namespace CodeLab.Facets;

public class Benchmarks
{
    private static readonly Person _person = new()
    {
        FirstName = "John",
        LastName = "Cena",
        Birthday = new DateTime(1977, 4, 23),
        Email = "john.cena@gmail.com"
    };

    [Benchmark]
    public PersonDto Facet()
    {
        return _person.ToFacet<Person, PersonDto>();
    }

    [Benchmark]
    public PersonDto2 ManualMapping()
    {
        return new PersonDto2
        {
            FirstName = $"{_person.FirstName} {_person.LastName}",
            Birthday = _person.Birthday.ToUniversalTime()
        };
    }
}

public class PersonDto2
{
    public string FirstName { get; set; }
    public DateTime Birthday { get; set; }
}