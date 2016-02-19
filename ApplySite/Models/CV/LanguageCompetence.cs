using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplySite.Models.CV
{
    public class LanguageCompetence
    {
        public int LanguageCompetenceId { get; set; }
        public string Language { get; set; }

        public virtual LanguageCompetenceLevel Level { get; set; }
    }
}