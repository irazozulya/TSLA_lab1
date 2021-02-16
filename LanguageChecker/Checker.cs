using System;

namespace LanguageChecker
{
    public class Checker
    {
        public string str { get; set; }
        public int n;
        public int m;

        public Checker(string str)
        {
            this.str = str;
        }

        public bool Check()
        {
            int length = str.Length;
            if (length == 0)
            {
                n = m = 0;
                return true;
            }
            else
            {
                int countN = 0;
                while (str[countN] == '0')
                {
                    countN++;
                    if(countN == length)
                    {
                        n = countN;
                        m = 0;
                        return true;
                    }
                }
                n = countN;
                int countM = 0;
                for(int i = countN; i < length; i++)
                {
                    if (str[i] != '1' || i + 1 == length)
                    {
                        return false;
                    }
                    else
                    {
                        i++;
                        if (str[i] == '0')
                        {
                            countM++;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                m = countM;
                return true;
            }
        }
    }
}
