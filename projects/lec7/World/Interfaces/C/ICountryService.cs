using World.Models;
namespace World.Interfaces;

// I know the workflow for getting and storing country data.
public interface ICountryService
{
    IReadOnlyList<Country> LoadCountries();
}
