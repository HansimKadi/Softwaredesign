using System.Data;
using World.Models;
namespace World;

public interface ICountryMapper
{ // I know how to turn a database row into a country object safely 
    Country Map(IDataRecord record); //IdataRecord is from System.Data, it represents a row from a database query 
}
