using System;
using System.Linq;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int idk = str.Split(letter).Length - 1;
            return idk;
            //Stymto mi pomohol spoluziak.
        }
    }
}
