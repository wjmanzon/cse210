using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Reference
{
    public List<Reference> _reference = new List<Reference>();
    private string _fileName = "scripture-references.txt";

    public string _book;
    public int _chapter;
    public int _verseStart;
    public int _verseEnd;

    public void LoadReference()
    {
        var lines = File.ReadAllLines(_fileName).Where(line => !string.IsNullOrWhiteSpace(line)).ToList();
        foreach (var line in lines)
        {
            var parts = line.Split(';');
            if (parts.Length >= 5) // Ensure that each line has enough parts
            {
                _reference.Add(new Reference
                {
                    _book = parts[1],
                    _chapter = int.Parse(parts[2]),
                    _verseStart = int.Parse(parts[3]),
                    _verseEnd = int.Parse(parts[4]),
                });
            }
        }
    }

    public void ReferenceDisplay()
    {
        foreach (var item in _reference)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public override string ToString()
    {
        return _verseEnd == 0 ? 
            $"\n{_book} {_chapter}:{_verseStart}" : 
            $"\n{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }

    public string GetReference(Scripture scripture)
    {
        if (scripture._index < _reference.Count)
        {
            var reference = _reference[scripture._index];
            return reference.ToString();
        }
        return "Reference not found";
    }
}
