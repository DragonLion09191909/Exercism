class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method

    private int ExpMin=40;
    public int ExpectedMinutesInOven() 
    {
       return ExpMin;
        
        
    }
    public int RemainingMinutesInOven(int MinAmount)
    {
       
      return ExpMin-=MinAmount;
        
       
    }
    public int PreparationTimeInMinutes(int LayerAmount) 
    {
        int result=0;
        for (int i=0; i<LayerAmount; i++) 
        {
             result+=2;
        }
      return result;
    }
    public int ElapsedTimeInMinutes(int LayerAmount, int MinAmount)
    {
        return MinAmount+ PreparationTimeInMinutes(LayerAmount);
    }
}
