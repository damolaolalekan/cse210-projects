using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Person p1 = new Person();
        p1.firstName = "John";
        p1.lastName = "Smith";
        p1._age = 30;

        Person p2 = new Person();
        p2.firstName = "Jane";
        p2.lastName = "Doe";    
        p2._age = 25;

        List<Person> people = new List<Person>();
        people.Add(p1);
        people.Add(p2);

        foreach (Person p in people)
        //{
            Console.WriteLine(p.firstName);          
        //}
        //SaveToFile(people);

        List<Person> newFromFile = ReadFromFile();
        foreach (Person p in newPeople)
        {
            Console.WriteLine(p.firstName);
        }
    }

    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to file...");
        string filename = "people.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine($"{p.firstName},{p.lastName},{p._age}");
            }
            
        }
    }

    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading list from file...");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in Lines)
        {
            //Console.WriteLine(line);
            //line will have something like "John,Smith,30"
            string[] parts = line.Split(",");

            //parts[0] will be the first name
            //parts[1] will be the last name
            //parts[2] will be the age


            Person newPerson = new Person();
            newPerson._firstName = parts[0];
            newPerson._lastName = parts[1];
            newPerson._age = int.Parse(parts[2]);

            people.Add(newPerson);
        }
        return people;
    }
}