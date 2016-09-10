using System.Collections.Generic;

namespace TSF.UmlToolingFramework.UML.Classes.Kernel {
	public interface Package : PackageableElement, Namespace {
    PackageableElement    ownedMembers   { get; set; }
    HashSet<Type>         ownedTypes     { get; set; }
    HashSet<Package>      nestedPackages { get; set; }
    Package               nestingPackage { get; set; }
    HashSet<PackageMerge> packageMerges  { get; set; }
    void exportToXMI(string filePath);
    Package getRootPackage();
    void refresh();
	}
}
