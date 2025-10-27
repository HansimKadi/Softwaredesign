namespace upper_lower_card_game;

public class Dealer
{
    private string _name = "Kingpin";
    public string Name { get { return _name; } }
    private string speak = "waiting for line";

    //public override string ToString()
    //  {
    //      return ;
    //  }
    private string _introduction =
    "Well, howdy there boys and gals.\n" +
    "Name’s Kingpin — keeper of cards, crusher of dreams,\n" +
    "and your host for this fine mess of chance.\n" +
    "Out here, luck’s got a short fuse and I’m holdin’ the match.\n" +
    "So grab your drink, place your bets, and pray those hands don’t tremble.\n" +
    "YEEEEHAAAW!";

    public void say_hi()
    {
        Console.WriteLine(_introduction);
    }

    private Dictionary<RuleBook.Outcomes, string> lines = new()
    {
        { RuleBook.Outcomes.corr_value_guess, "Well I’ll be damned, you hit one! Guess the deck had mercy today." },
        { RuleBook.Outcomes.incor_value_guess, "Aw, don’t cry — math was never everyone’s strength." },
        { RuleBook.Outcomes.corr_color_guess, "Oh, congratulations, you guessed red or black. Truly a mastermind at work." },
        { RuleBook.Outcomes.incorr_color_guess, "You got two colors, two! And you still found a way to screw it up!" },
        { RuleBook.Outcomes.streak, "Well, look at you climbing the ladder of delusion. Don’t trip on it." },
        { RuleBook.Outcomes.streak_break, "And there it is! The streak’s over—order restored, pride demolished." },
        { RuleBook.Outcomes.corr_upper_guess, "Well, well, look who finally crawled out of mediocrity! You shock me, player — I didn’t think luck took bribes." },
        { RuleBook.Outcomes.incorr_upper_guess, "Too high? Fitting, considering your confidence level." },
        { RuleBook.Outcomes.corr_lower_guess, "Bravo, you managed to go low without hitting rock bottom." },
        { RuleBook.Outcomes.incor_lower_guess, "Lower? Not that low, genius — we’re not digging for fossils." }
    };
    // private ChooseLine choose what to say when 



}
