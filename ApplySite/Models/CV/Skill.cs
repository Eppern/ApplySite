using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplySite.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public int MyProperty { get; set; }
        public string Name { get; set; }

        public int SkillLevelId { get; set; }

        public virtual SkillLevel SkillLevel { get; set; }
    }
}