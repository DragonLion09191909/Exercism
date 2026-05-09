class BirdCount
{
    private static int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay) => _birdsPerDay = birdsPerDay;
    

    public static int[] LastWeek()=> [0, 2, 5, 3, 7, 8, 4];


    public int Today() => _birdsPerDay.Last();


    public void IncrementTodaysCount() => _birdsPerDay[_birdsPerDay.Length-1] += 1;

    public bool HasDayWithoutBirds() => _birdsPerDay.Any(x => x == 0) ? true : false;
   

    public int CountForFirstDays(int numberOfDays) => _birdsPerDay[0..numberOfDays].Sum();

    public int BusyDays() => _birdsPerDay.Where(x => x >= 5).Count();

  
    
}


