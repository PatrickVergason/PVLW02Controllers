using Microsoft.AspNetCore.Mvc;
using PVLW02Controllers.Services;
using System.Web;

namespace PVLW02Controllers.Controllers
{
    public class DictionaryController : Controller
    {

        private readonly IWordService _dictionary;
        public DictionaryController(IWordService _dictionary)
        {
            this._dictionary = _dictionary;
        }
        public IActionResult Index()
        {
            return View(_dictionary.GetWords());
        }
        public IActionResult AddWord()
        {
            return View();
        }
        public IActionResult AddNewWord(string word, string meaning)
        {
            var wordEncode = HttpUtility.HtmlEncode(word);
            var meaningEncode = HttpUtility.HtmlEncode(meaning);
            _dictionary.AddWord(wordEncode, meaningEncode);
            return RedirectToAction("Index");
        }
    }
}
