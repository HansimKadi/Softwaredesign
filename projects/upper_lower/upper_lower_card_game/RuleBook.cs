namespace upper_lower_card_game;

public class RuleBook
{
    int penaly_rate; // find out how to apply penaly to the players
    public enum Outcomes
    {
        corr_value_guess,
        incor_value_guess,
        corr_color_guess,
        incorr_color_guess,
        streak,
        streak_break,
        corr_upper_guess,
        incorr_upper_guess,
        corr_lower_guess,
        incor_lower_guess
    }

}
