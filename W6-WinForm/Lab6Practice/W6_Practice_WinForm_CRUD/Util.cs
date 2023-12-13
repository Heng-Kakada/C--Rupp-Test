using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W6_Practice_WinForm_CRUD;

public class Util
{
    public static string CapitalizeFirstLetter(string str)
    {
        if (String.IsNullOrEmpty(str))
            return str;
        if (str.Length == 1)
            return str.ToUpper();
        return str.Remove(1).ToUpper() + str.Substring(1);
    }

    public static string CapitalizeName(string name) {
        string nameCap = "";
        if (name.Contains(" "))
        {
            string[] nameSplit = name.Split(' ');
            for (int i = 0; i < nameSplit.Length; i++)
            {
                nameSplit[i] = CapitalizeFirstLetter(nameSplit[i]);
                nameCap = nameCap + " " + nameSplit[i];
            }
            return nameCap;
        }
        return CapitalizeFirstLetter(name);
    }
}
