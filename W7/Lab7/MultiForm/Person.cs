using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiForm;

class Person
{
    private static int count = 0;
    public int No { get; set; }
    public string Name { get; set; } = "";
    public string Gender { get; set; } = "";
    public byte Age { get; set; }
    public Person(String n, String g, byte a)
    {
        No = ++count;
        Name = n;
        Gender = g;
        Age = a;
    }
}
