using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequirementsFramework
{
    public interface Folder
    {
        string name { get; set; }
        Folder parentFolder { get; set; }
        IEnumerable<Folder> subFolders { get; set; }
        IEnumerable<Requirement> requirements { get; set; }
        IEnumerable<Requirement> getAllOwnedRequirements();
    }
}
