namespace World;

public class City
{
    private int _Id;
    private string _Name;
    private string _CountryCo;
    private string _District;
    private int _population;

    public City(int? id, string? name, string? countryco, string? district, int? population)
    {
        _Id = id ?? 0;
        _Name = name ?? "";
        _CountryCo = countryco ?? "";
        _District = district ?? "";
        _population = population ?? 0;
    }
}
