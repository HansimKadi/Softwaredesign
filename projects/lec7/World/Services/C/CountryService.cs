using World.Models;
using World.Interfaces;
namespace World.Services;

public sealed class CountryService : ICountryService
{
    private readonly ICountryRepository _repository;

    public CountryService(ICountryRepository repository)
    {
        _repository = repository;
    }

    public IReadOnlyList<Country> LoadCountries()
    {
        var countries = _repository.GetAll();
        return countries;
    }
}
