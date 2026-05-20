public static class LineUp
{
    public static string Format(string name, int number)
    {
        if (!string.IsNullOrEmpty(name))
        {
            string ending;
            char[] input = number.ToString().ToArray();
            ending = input.EndsWith("11")|| input.EndsWith("12")||input.EndsWith("13")? "th" : input[^1] switch
            {
                '1' => "st",
                '2' => "nd",
                '3' => "rd",
                _ => "th"
            };
            return $"{name}, you are the {number}{ending} customer we serve today. Thank you!";
        }
        throw new Exception("Name is missing!");

    }
}