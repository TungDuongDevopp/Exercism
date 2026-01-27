using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly HashSet<string> _usedNames = new HashSet<string>();
    private static readonly Random _random = new Random();
    private string _name;

    public string Name
    {
        get
        {
            if (_name == null) _name = GenerateUniqueName();
            return _name;
        }
    }

    public void Reset()
    {
    
        _name = GenerateUniqueName();
    }

    private string GenerateUniqueName()
    {
        string newName;
        do
        {
            char c1 = (char)_random.Next('A', 'Z' + 1);
            char c2 = (char)_random.Next('A', 'Z' + 1);
            int num = _random.Next(0, 1000); 
            newName = $"{c1}{c2}{num:D3}";
        } while (_usedNames.Contains(newName));

        _usedNames.Add(newName);
        return newName;
    }
}