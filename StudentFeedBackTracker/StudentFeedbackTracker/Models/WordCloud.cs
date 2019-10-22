using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class WordCloud
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Word { get; set; }
        public int NumberOfUse { get; set; }

        void CheckWord() { }
        void CountItsUse() { }

        void ShowWordsCloud() { } // Admin & Staff

    }
}
