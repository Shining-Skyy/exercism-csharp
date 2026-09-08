public static class LineUp
{
    public static string Format(string name, int number)
    {
        string suffix;
        int lastTwoDigits = number % 100;

        if (number % 10 == 1 && lastTwoDigits != 11) suffix = "st";
        else if (number % 10 == 2 && lastTwoDigits != 12) suffix = "nd";
        else if (number % 10 == 3 && lastTwoDigits != 13) suffix = "rd";
        else suffix = "th";

        return $"{name}, you are the {number + suffix} customer we serve today. Thank you!"; ;
    }
}
