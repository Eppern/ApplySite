using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplySite.Models
{
    public class CV
    {
        public CV()
        {
            this.WorkExperiences = new HashSet<WorkExperience>();
            this.Educations = new HashSet<Education>();
        }

        public List<string> Hobbies { get; set; }

        public virtual ICollection<WorkExperience> WorkExperiences { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
    }
}