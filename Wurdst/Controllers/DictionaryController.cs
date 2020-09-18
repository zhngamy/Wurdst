using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wurdst.Models;
using Wurdst.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wurdst.Controllers
{
    public class DictionaryController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            DateTime now = DateTime.Now;

            Word word = new Word()
            {
                Definition = "Example definition",
                SentenceUsage = "Example sentence",
                WhenCreated = now
            };

            Tag tag = new Tag()
            {
                TagName = "Biology",
                WhenCreated = now
            };

            //Create the new viewmodel
            DictionaryIndexViewModel vm = new DictionaryIndexViewModel()
            {
                Word = word,
                Tag = tag
            };

            return View(vm);
        }
    }
}
