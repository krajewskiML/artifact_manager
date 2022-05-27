using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artifact_manager2.Database.EnhancedModels
{
    internal class FullCategory
    {
        public string Name { get; set; }

        public Dictionary<string, string> Attributes { get; set; }
    }
}
