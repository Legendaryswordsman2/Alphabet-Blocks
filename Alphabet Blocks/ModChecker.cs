using System.Collections.Generic;
using System.Linq;
using ModLoaderInterfaces;
using System.IO;
using Pipliz;

namespace Alphabet_Blocks
{
    public class ModChecker : IAfterModsLoaded, IOnAssemblyLoaded
    {
        string assemblyPath;
        public void AfterModsLoaded(List<ModLoader.ModDescription> mods)
        {
            if (mods.Where(mod => mod.name == "Better Categorization").Any())
                ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "better_categorization_mod_support.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 50000);
        }

        public void OnAssemblyLoaded(string path)
        {
            assemblyPath = path;
        }
    }
}
