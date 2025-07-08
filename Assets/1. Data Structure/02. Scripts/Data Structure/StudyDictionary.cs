using System.Collections.Generic;
using UnityEngine;

public class PersonData
{
    public int age;
    public float height;
    public float weight;
    public string name;
}

public class StudyDictionary : MonoBehaviour
{
   public Dictionary<string, int> persons = new Dictionary<string, int>();

    private void Start()
    {
        persons.Add("James", 30);
        persons.Add("Maria", 29);
        persons.Add("Mary", 27);

        int age = persons["James"];
        Debug.Log($"James is {age} years old");

        foreach (var person in persons)
        {
            if (person.Value == 30)
            {
                Debug.Log($"A person who is aged about 30 is {person.Key}");
            }
            Debug.Log($"{person.Key}'s age is {person.Value}");
        }

        if (persons.ContainsKey("James"))
        {
            Debug.Log("James is among us");
        }

        if (persons.ContainsValue(30))
        {
            Debug.Log("There are person who aged about 30");
        }
    }
}
