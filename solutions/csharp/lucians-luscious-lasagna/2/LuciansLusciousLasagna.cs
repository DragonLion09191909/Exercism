class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    // TODO: define the 'RemainingMinutesInOven()' method

    // TODO: define the 'PreparationTimeInMinutes()' method

    // TODO: define the 'ElapsedTimeInMinutes()' method

    private int ExpMin=40;
    public int ExpectedMinutesInOven()=>  ExpMin;
   
    public int RemainingMinutesInOven(int MinAmount)=>  ExpMin-=MinAmount;
   
    public int PreparationTimeInMinutes(int LayerAmount) => LayerAmount*2;
   
    public int ElapsedTimeInMinutes(int LayerAmount, int MinAmount)=> MinAmount+ PreparationTimeInMinutes(LayerAmount);
   
}
