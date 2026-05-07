static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
       
       if(speed>0 && speed<=4)return 100/100.0;
       else if(speed>=5 && speed<=8) return 90/100.0;
       else if(speed==9) return 80/100.0;
       else if(speed==10) return 77/100.0;
       return 0/100.0;
    
    }
    
    public static double ProductionRatePerHour(int speed)
    {
         return 221 * speed * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
       return (int)ProductionRatePerHour(speed)/60;
    }
}
