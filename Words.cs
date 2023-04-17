using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class Word
{
    public bool english { get; set; }
    public bool russian { get; set; }
    public bool german { get; set; }

    public string Translation { get; set; }
    public Dictionary<string, string> Translations { get; set; }
}

public class WordsWriter
{
    public static void WriteWordTranslation(string filename, string fLang, string fWord, string translationLanguage, string translation)
    {
        var words = new List<Word>();

        if (File.Exists(filename))
        {
            var json = File.ReadAllText(filename);
            words = JsonSerializer.Deserialize<List<Word>>(json);
        }
        Word word = new Word();

        switch (fLang)
        {
            case "english":
                //word = words.Find(w => w.english == fWord);
                break;
            case "russian":
                //word = words.Find(w => w.russian == fWord);
                break;
            case "german":
                //word = words.Find(w => w.german == fWord);
                break;
            default:
                throw new ArgumentException($"Ошибка.");
        }

        if (word == null)
        {
            //word = new Word { english = fWord, Translations = new Dictionary<string, string>() };
            words.Add(word);
        }

        switch (translationLanguage)
        {
            case "russian":
                word.Translations["russian"] = translation;
                break;
            case "german":
                word.Translations["german"] = translation;
                break;
            default:
                throw new ArgumentException($"Ошибка.");
        }

        var jsonToWrite = JsonSerializer.Serialize(words, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, jsonToWrite);
    }
}

public class WordsReader
{
    public static string GetWordTranslation(string filename, string fLang, string fWord, string translationLanguage)
    {
        var words = new List<Word>();

        if (File.Exists(filename))
        {
            var json = File.ReadAllText(filename);
            words = JsonSerializer.Deserialize<List<Word>>(json);
        }
        Word word = new Word();
        switch (fLang)
        {
            case "english":
                //word = words.Find(w => w.english == fWord);
                break;
            case "russian":
                //word = words.Find(w => w.russian == fWord);
                break;
            case "german":
                //word = words.Find(w => w.german == fWord);
                break;
            default:
                throw new ArgumentException($"Ошибка.");
        }
        if (word != null && word.Translations.ContainsKey(translationLanguage))
            return word.Translations[translationLanguage];

        return null;
    }
}

namespace Program1
{
    class Program
    {
        static void Main123()
        {

            Console.Write("С какого языка перевести: ");
            string fLang = Console.ReadLine().ToLower();

            Console.Write("Получить перевод слова: ");
            string fWord = Console.ReadLine().ToLower();

            Console.Write("На какой язык перевести (русский или немецкий): ");
            string translationLanguage = Console.ReadLine().ToLower();

            Console.Write("Перевод слова: ");
            string translation = Console.ReadLine().ToLower();

            WordsWriter.WriteWordTranslation("words.json", fLang, fWord, translationLanguage, translation);

            if (translation != null)
            {
                Console.WriteLine($"{translation}");
            }
            else
            {
                Console.WriteLine($"Перевод слова '{fWord}' не найден.");
            }
        }
    }
}