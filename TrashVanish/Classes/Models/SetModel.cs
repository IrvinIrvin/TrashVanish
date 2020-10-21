using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashVanish.Classes
{
    public class SetModel
    {
        public string setID { get; set; }
        public string setName { get; set; }
        public List<setExtensionModel> extensions { get; set; }
        public string targetPath { get; set; }

        public int isCaseSensetive { get; set; }
    }
}