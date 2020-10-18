namespace MedicCards
{
    static class Values
    {
        static string numCard = "";
        public static string getNum()
        {
            return numCard;
        }
        public static void setNum(string _numCard)
        {
            numCard = _numCard;
        }

        static bool isFirstForCard = true;
        public static bool getIsFirstForCard()
        {
            return isFirstForCard;
        }
        public static void setIsFirstForCard(bool _isFirst)
        {
            isFirstForCard = _isFirst;
        }

        static bool isFirstForName = true;
        public static bool getIsFirstForName()
        {
            return isFirstForName;
        }
        public static void setIsFirstForName(bool _isFirst)
        {
            isFirstForName = _isFirst;
        }

        static bool isFirstForBirth = true;
        public static bool getIsFirstForBirth()
        {
            return isFirstForBirth;
        }
        public static void setIsFirstForBirth(bool _isFirst)
        {
            isFirstForBirth = _isFirst;
        }

        static bool isFirstForHandOver = true;
        public static bool getIsFirstForHandOver()
        {
            return isFirstForHandOver;
        }
        public static void setIsFirstForHandOver(bool _isFirst)
        {
            isFirstForHandOver = _isFirst;
        }

        static bool isFirstForArrive = true;
        public static bool getIsFirstForArrive()
        {
            return isFirstForArrive;
        }
        public static void setIsFirstForArrive(bool _isFirst)
        {
            isFirstForArrive = _isFirst;
        }
    }
}
