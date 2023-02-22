using PVLW02Controllers.Models;

namespace PVLW02Controllers.Services
{
    public interface IWordService
    {
        void AddWord(string word, string meaning);
        List<MyDictionaryEntry> GetWords();
    }
}
