using Pipliz;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better_Categorization
{
    class ModChecker : ModLoaderInterfaces.IAfterModsLoaded, ModLoaderInterfaces.IOnAssemblyLoaded
    {
        string assemblyPath;

        public void AfterModsLoaded(List<ModLoader.ModDescription> mods)
        {
            //bool hasColoredSandMod = mods.Where(mod => mod.name == "Colored Sand").Any();

            // If the Colored Sand mod is installed...
            if (mods.Where(mod => mod.name == "Colored Sand").Any())
                ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "overridetypes-colored_sand.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 50000);


            //Log.Write((mods.Where(mod => mod.name == "TeleportPad").Any() == true).ToString());
            if (mods.Where(mod => mod.name == "TeleportPad").Any() || mods.Where(mod => mod.name == "Teleport Pads+").Any())
                ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "overridetypes-teleportpad.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 50000);

            if (mods.Where(mod => mod.name == "Chisel").Any())
                ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "overridetypes-chisel.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 50000);

            if (mods.Where(mod => mod.name == "Lanterns+").Any())
                ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "overridetypes-lanterns+.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 50000);

            if (mods.Where(mod => mod.name == "AdvancedForester").Any())
                ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "overridetypes-advanced_forester.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 50000);

            if (mods.Where(mod => mod.name == "Compass").Any())
                ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "overridetypes-compass.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 50000);
        }

        public void OnAssemblyLoaded(string path)
        {
            assemblyPath = path;
        }
    }
}
