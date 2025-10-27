using Microsoft.Data.Sqlite;
namespace World.Models;

public class Country
{
    private string _Code;
    private string _Name;
    private string _Continent;
    private string _Region;
    private double _SurfaceArea;
    private int _IndepYear;
    private int _Population;
    private double _LifeExpectancy;
    private double _GNP;
    private double _GNPOLD;
    private string _LocalName;
    private string _GovernmentFo;
    private string _HeadOfState;
    private int _Capital;
    private string _Code2;

    // Constructor
    public Country(string? code, string? name, string? continent, string? region, double? surfacearea, int? indepyear, int? population, double? lifeexpectancy, double? gnp, double? gnpold, string? localname, string? governmentfo, string? headofstate, int? capital, string? code2)
    {
        _Code = code ?? "";
        _Name = name ?? "";
        _Continent = continent ?? "";
        _Region = region ?? "";
        _SurfaceArea = surfacearea ?? 0;
        _IndepYear = indepyear ?? 0;
        _Population = population ?? 0;
        _LifeExpectancy = lifeexpectancy ?? 0;
        _GNP = gnp ?? 0;
        _GNPOLD = gnpold ?? 0;
        _LocalName = localname ?? "";
        _GovernmentFo = governmentfo ?? "";
        _HeadOfState = headofstate ?? "";
        _Capital = capital ?? 0;
        _Code2 = code2 ?? "";
    }

    public void info()
    {
        Console.WriteLine($"\nCode: {_Code} \nCountry: {_Name}\n Continent: {_Continent}\n Population: {_Population}\n Life Expectancy: {_LifeExpectancy}\n GNP: {_GNP}\n Head of State: {_HeadOfState}\n Capital ID: {_Capital}\n Code2: {_Code2}\n Region: {_Region}\n Surface Area: {_SurfaceArea}\n Independence Year: {_IndepYear}\n GNP Old: {_GNPOLD}\n Local Name: {_LocalName}\n Government Form: {_GovernmentFo}");
    }

}
