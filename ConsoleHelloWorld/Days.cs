namespace ConsoleHelloWorld
{
    public enum Days
    {
        None = 0,
        Sunday = 0x001,
        Monday = 0x002,
        Tuesday = 0x004,
        Wednesday = 0x008,
        Thursday = 0x010,
        Friday = 0x020,
        Saturday = 0x040,
        Weekend = Sunday | Saturday,
        Weekdays = Monday | Tuesday | Wednesday | Thursday | Friday
    }
}