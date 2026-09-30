public static class SquareRoot
{
    public static int Root(int number)
    {
      int guess=1;
        while(guess*guess<number) guess++;
        return guess;
    }
}
