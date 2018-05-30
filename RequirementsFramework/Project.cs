using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequirementsFramework
{
    public interface Project
    {
        string name { get; set; }
        IEnumerable<Requirement> requirements { get; set; }
        IEnumerable<Folder> rootFolders { get; set; }
    }
}
