using System;
using System.Collections.Generic;

namespace Wurdst.Models
{
    public class Word
    {
        public Word()
        {
        }

        public int WordId { get; set; }

        public string Definition { get; set; }

        public string SentenceUsage { get; set; }

        public DateTime? WhenCreated { get; set; }

    }
}
