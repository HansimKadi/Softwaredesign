namespace World.Models;
// Iknow how to read countries data from a data source
public interface ICountryRepository
{
    IReadOnlyList<Country> GetAll();
}
