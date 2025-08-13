using CodeLab.Facets;
using CodeLab.Facets.Models;
using Facet.Extensions;

var dbCotnext = new AppDbContext();

var person = new Person
{
    FirstName = "John",
    LastName = "Cena",
    Birthday = new DateTime(1977, 4, 23),
    Email = "john.cena@gmail.com"
};

//Here we are refering that we want to map the Person model to the PersonDto model.
var dto = person.ToFacet<Person, PersonDto>();

Console.WriteLine($"Here we have {dto.FirstName} {dto.LastName}! He was born in {dto.Birthday.ToShortDateString()}!");
Console.ReadLine();