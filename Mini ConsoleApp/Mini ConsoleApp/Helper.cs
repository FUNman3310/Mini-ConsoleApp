using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_ConsoleApp
{
    public static class Helper
    {

        public static bool CheckName(string name)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (name.Length >= 3)
            {
                stringBuilder.Append(name[0].ToString().ToUpper());
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == ' ')
                    {
                        break;
                    }
                    stringBuilder.Append(name[i]);

                }
                return true;
            }
            return false;
        }
        public static string CheckClassName(string name)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (name.Length == 5)
            {
                if (name.Substring(0, 2).All(char.IsLetter) && name.Substring(2, 3).All(char.IsDigit))
                {
                    stringBuilder.Append(name.ToUpper());
                    return stringBuilder.ToString();
                }
            }
            return null;
        }
    }
}
