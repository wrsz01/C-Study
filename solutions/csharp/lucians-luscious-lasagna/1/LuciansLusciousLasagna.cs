class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;


    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minute) => 40 - minute;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int level) => 2 * level;

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int level, int minute) => level * 2 + minute;
}
