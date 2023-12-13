using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace W6_Practice_WinForm_CRUD.Model;

public class Person
{
    public static Person? CreateInstance(string data)
    {
        string[] arr = data.Split(Separator);
        if (arr.Length < 4) return null;
        if (int.TryParse(arr[0], out int no) == false) return null;
        if (byte.TryParse(arr[3], out byte age) == false) return null;
        return new Person()
        {
            No = no,
            Name = arr[1].Trim(),
            Gender = arr[2].Trim(),
            Age = age,
        };
    }

    // fields
    public static string Separator { get; set; } = "/";
    // Properties
    public int No { get; set; } = 0;
    public string Name { get; set; } = default!;
    public string Gender { get; set; } = default!;
    public byte Age { get; set; } = default;
    public string info => $"name: {Name}, gender: {Gender}, age: {Age}";
}
