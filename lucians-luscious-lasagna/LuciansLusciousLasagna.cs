using System.Timers;

class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int timeRemaining)
    {
        int expectedMinutes = ExpectedMinutesInOven();
        return (expectedMinutes - timeRemaining);
    }

    public int PreparationTimeInMinutes(int numberOfLayers)
    {
        return numberOfLayers + numberOfLayers;
    }

    public int ElapsedTimeInMinutes(int addedLayer, int elapsedTime)
    {
        int preparationTime = PreparationTimeInMinutes(addedLayer);

        return (preparationTime + elapsedTime);
    }
}
