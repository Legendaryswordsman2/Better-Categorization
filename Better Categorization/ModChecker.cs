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
                ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "overridetypes-colored_sand.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 15000);


            //Log.Write((mods.Where(mod => mod.name == "TeleportPad").Any() == true).ToString());
            if (mods.Where(mod => mod.name == "TeleportPad").Any() || mods.Where(mod => mod.name == "Teleport Pads+").Any())
                ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "overridetypes-teleportpad.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 15000);

            if (mods.Where(mod => mod.name == "Chisel").Any())
                ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "overridetypes-chisel.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 15000);

            if (mods.Where(mod => mod.name == "Lanterns+").Any())
                ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "overridetypes-lanterns+.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 15000);

            //for (int i = 0; i < mods.Count; i++)
            //{
            //    Log.Write(mods[i].name + " -----------------");
            //}
            //Log.Write((mods.Where(mod => mod.name == "Kings 0.9 Textures and Decorations").Any() == true).ToString());

            //if (mods.Where(mod => mod.name == "Kings 0.9 Textures and Decorations").Any() == true)
            //    ItemTypesServer.QueueItemTypePatches(Path.Combine(Path.GetDirectoryName(assemblyPath), "overridetypes-kings_0.9_textures_and_decorations.json"), ItemTypesServer.EItemTypePatchType.OverrideTypeProperties, 1000);
        }

        public void OnAssemblyLoaded(string path)
        {
            assemblyPath = path;
        }
    }
}
