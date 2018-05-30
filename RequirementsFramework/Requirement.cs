using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequirementsFramework
{
    public interface Requirement
    {
        string title { get; set; }
        string description { get; set; }
        string creator { get; set; }
        string contributor { get; set; }
        string type { get; set; }
        string ID { get; set; }
        DateTime created { get; set; }
        DateTime modified { get; set; }
        string status { get; set; }
        string priority { get; set; }
        Folder folder { get; set; }
        Project project { get; set; }
    }
}
