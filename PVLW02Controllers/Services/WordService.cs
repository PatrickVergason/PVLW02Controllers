using PVLW02Controllers.Models;

namespace PVLW02Controllers.Services
{
    public class WordService : IWordService
    {
        private static List<MyDictionaryEntry> _words = new List<MyDictionaryEntry>();

        void IWordService.AddWord(string word, string meaning)
        {
            MyDictionaryEntry entry = new MyDictionaryEntry { Word = word, Meaning = meaning };
            _words.Add(entry);
        }

        List<MyDictionaryEntry> IWordService.GetWords()
        {
            return _words;
        }
    }
}
