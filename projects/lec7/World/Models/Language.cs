namespace World;

public class Language
{
    private string _countryco;
    private string _name;
    private string _official;
    private double _percentage;

    public Language(string? countryco, string? name, string? official, double? percentage)
    {
        _countryco = countryco ?? "";
        _name = name ?? "";
        _official = official ?? "";
        _percentage = percentage ?? 0f;
    }
}
