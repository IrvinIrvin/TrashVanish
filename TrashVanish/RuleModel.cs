using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashVanish
{
    public class RuleModel
    {
        public string id { get; set; }
        public string ruleExtension { get; set; }
        public string rulePath { get; set; }
        public string ruleIncludes { get; set; }
    }
}
