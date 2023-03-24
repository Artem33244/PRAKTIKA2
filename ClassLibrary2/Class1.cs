namespace ClassLibrary2
{
    public class NumberIncrementer
    {
        private int p = 0;

        public bool SetNumber(int number)
        {
            if (number == p + 1)
            {
                p = number;
                return true;
            }
            else
            {
                p = 0;
                return false;
            }
        }

        public int GetExpectedNumber()
        {
            return p + 1;
        }
    }
}