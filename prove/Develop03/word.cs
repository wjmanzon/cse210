using System;
using System.Collections.Generic;

public class Word
{
    public string _words = "";
    public string _ref = "";
    public string[] _result;
    public List<int> _hidden;

    public Word()
    {
    }

    public Word(string text, string visible)
    {
    }

    public void GetRenderedText(Scripture scripture)
    {
        _words = scripture._scriptureText;
        _result = _words.Split(" ");
        _hidden = new List<int>();
    }

    public void GetRenderedRef(Scripture scripture)
    {
    }

    public void Show(string ref1)
    {
        _ref = ref1;
        Console.Clear();
        Console.WriteLine("\nINSTRUCTIONS:\nPress enter to hide words\nType quit to exit the app\n");
        Console.WriteLine($"{_ref}");
        for (var i = 0; i < _result.Length; i++)
        {
            var str = _result[i];
            int len = str.Length;
            string dashedLine = new string('_', len);
            Console.Write(_hidden.Contains(i) ? $"{dashedLine} " : $"{str} ");
        }
    }

    public void GetReadKey()
    {
        var input = Console.ReadKey();
        if (input.Key == ConsoleKey.Spacebar || input.Key == ConsoleKey.Enter)
        {
            GetNewHiddenWord();
        }
        else if (input.Key == ConsoleKey.Q)
        {
            Environment.Exit(0);
        }
    }

    public void GetNewHiddenWord()
    {
        var random = new Random();
        while (true)
        {
            var index = random.Next(_result.Length);
            if (!_hidden.Contains(index))
            {
                _hidden.Add(index);
                break;
            }
        }
    }
}