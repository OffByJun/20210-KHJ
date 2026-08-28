namespace Monsters;

public static class mathUtil
{
    public static bool critical(int min = 0, int max = 100)
    {
        Random rnd = new Random();
        return rnd.Next(min, max) == 0;
    }
}