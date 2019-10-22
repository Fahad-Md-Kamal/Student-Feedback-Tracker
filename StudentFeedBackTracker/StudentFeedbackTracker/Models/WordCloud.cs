using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class WordCloud
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public int NumberOfUse { get; set; }

        void CheckWord() { }
        void CountItsUse() { }

        void ShowWordsCloud() { } // Admin & Staff

    }
}
