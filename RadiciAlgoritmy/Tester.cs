namespace RadiciAlgoritmy
{
    public static class Tester
    {
        public static bool JePoleSerazeno(int[] pole)
        {
            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i - 1] > pole[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}