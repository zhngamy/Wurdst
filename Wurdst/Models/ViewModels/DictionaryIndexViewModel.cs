using System;
using System.Collections.Generic;
using Wurdst.Models;

namespace Wurdst.Models.ViewModels
{
    public class DictionaryIndexViewModel
    {
        public Word Word { get; set; }

        public Tag Tag { get; set; }

        public WordTag WordTag { get; set; }


        //public IEnumerator<Word> Words { get; set; }

        //public IEnumerator<Tag> Tags { get; set; }

        //public IEnumerator<WordTag> WordTags { get; set; }
    }
}