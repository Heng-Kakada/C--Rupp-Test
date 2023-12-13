using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W6_Practice_WinForm_CRUD.Model;

namespace W6_Practice_WinForm_CRUD.Service;

public class PersonService
{
    // methods
    public PersonService(string fileName)
    {
        LoadPeople(fileName);
    }
    private void LoadPeople(string fileName)
    {
        _people.Clear();
        string[] allLines = File.ReadAllLines(fileName);
        if (allLines.Length <= 0) return;
        foreach (string line in allLines)
        {
            Person? p = Person.CreateInstance(line);
            if (p == null) continue;
            _people.Add(p);
        }
    }
    public void SavePerson(Person person)
    {
        _people.Add(person);
    }
    public Person? FindPersonByNo(int no)
    {
        return _people.FirstOrDefault(p => p.No == no);
    }
    public List<Person> FindAllPersons() { return _people; }
    public bool DeletePerson(Person person)
    {
        if (_people.Remove(person)) return true;
        return false;
    }
    public List<Person> GenderGroupView()
    {
        List<Person> genderGroup = new();
        List<string> gender = _people.Select(p => p.Gender).Distinct().ToList();
        gender.ForEach(g =>
        {
            _people.Where(p => p.Gender == g).ToList().ForEach(
                p => genderGroup.Add(p)
             );
        });
        return genderGroup;
    }

    // fields
    private List<Person> _people = new();
    // properties
    public int CountPerson => _people.Count;
}
