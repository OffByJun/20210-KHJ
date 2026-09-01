using System;

namespace _001_Scripts.Utils
{
    public static class MathUtil
    {
        public static bool Critical(int min = 0, int max = 100, int target = 50)
        {
            Random rnd = new Random();
            return rnd.Next(min, max) < target;
        }

        public static int RandomInt(int min = 0, int max = 100)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        public static float ApplyDef(float def, float dmg)
            => dmg / def;
    }
}