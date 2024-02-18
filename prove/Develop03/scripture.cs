using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Scripture
{
    public List<Scripture> _scripture = new List<Scripture>();
    private string _fileName = "scripture-references.txt";
    private string _key;
    private string _text;
    public int _index;
    public string _scriptureText;

    public void LoadScriptures()
    {
        var lines = File.ReadAllLines(_fileName).Where(line => !string.IsNullOrWhiteSpace(line)).ToList();
        foreach (var line in lines)
        {
            var parts = line.Split(';');
            if (parts.Length > 6) // Ensure there are enough parts for key and text
            {
                var entry = new Scripture
                {
                    _key = parts[0],
                    _text = parts[6]
                };
                _scripture.Add(entry);
            }
        }
    }

    public void ScriptureDisplay()
    {
        foreach (var item in _scripture)
        {
            Console.WriteLine($"\n{item._text}");
        }
    }

    public int GetRandomIndex()
    {
        var random = new Random();
        _index = random.Next(_scripture.Count);
        return _index;
    }

    public string RandomScripture()
    {
        _index = GetRandomIndex();
        return _scriptureText = _scripture[_index]._text;
    }
}
