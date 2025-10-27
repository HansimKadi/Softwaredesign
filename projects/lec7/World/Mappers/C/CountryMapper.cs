using System.Data;
using World.Models;
namespace World.Mappers;

public class CountryMapper : ICountryMapper
{


    public Country Map(IDataRecord r)
    {
        // Strings
        int iName = r.GetOrdinal("Name");
        string name = r.IsDBNull(iName) ? "Unknown" : r.GetString(iName);

        int iCode = r.GetOrdinal("Code");
        string code = r.IsDBNull(iCode) ? "Unknown" : r.GetString(iCode);

        int iCont = r.GetOrdinal("Continent");
        string continent = r.IsDBNull(iCont) ? "Unknown" : r.GetString(iCont);

        int iReg = r.GetOrdinal("Region");
        string region = r.IsDBNull(iReg) ? "Unknown" : r.GetString(iReg);

        int iLoc = r.GetOrdinal("LocalName");
        string localName = r.IsDBNull(iLoc) ? "Unknown" : r.GetString(iLoc);

        int iGov = r.GetOrdinal("GovernmentForm");
        string governmentForm = r.IsDBNull(iGov) ? "Unknown" : r.GetString(iGov);

        int iHos = r.GetOrdinal("HeadOfState");
        string headOfState = r.IsDBNull(iHos) ? "Unknown" : r.GetString(iHos);

        int iCode2 = r.GetOrdinal("Code2");
        string code2 = r.IsDBNull(iCode2) ? "Unknown" : r.GetString(iCode2);

        // Doubles (SQLite REAL → Double)
        int iSurf = r.GetOrdinal("SurfaceArea");
        double surfaceArea = r.IsDBNull(iSurf) ? 0.0 : r.GetDouble(iSurf);

        int iLife = r.GetOrdinal("LifeExpectancy");
        double lifeExpectancy = r.IsDBNull(iLife) ? 0.0 : r.GetDouble(iLife);

        int iGnp = r.GetOrdinal("GNP");          // <-- use exact column/alias name
        double gnp = r.IsDBNull(iGnp) ? 0.0 : r.GetDouble(iGnp);

        int iGnpOld = r.GetOrdinal("GNPOld");
        double gnpOld = r.IsDBNull(iGnpOld) ? 0.0 : r.GetDouble(iGnpOld);

        // Integers (SQLite often returns Int64 → read as Int64, then cast)
        int iInd = r.GetOrdinal("IndepYear");
        int indepYear = r.IsDBNull(iInd) ? 0 : (int)r.GetInt64(iInd);

        int iPop = r.GetOrdinal("Population");
        int population = r.IsDBNull(iPop) ? 0 : (int)r.GetInt64(iPop);

        int iCap = r.GetOrdinal("Capital");
        int capital = r.IsDBNull(iCap) ? 0 : (int)r.GetInt64(iCap);

        return new Country(
            code, name, continent, region,
            surfaceArea, indepYear, population,
            lifeExpectancy, gnp, gnpOld,
            localName, governmentForm, headOfState,
            capital, code2
        );
    }

}


