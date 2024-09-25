using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;

namespace SprintInvert
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.USERS_PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    [BepInProcess("Void Crew.exe")]
    [BepInDependency(VoidManager.MyPluginInfo.PLUGIN_GUID)]
    public class BepinPlugin : BaseUnityPlugin
    {
        internal static ManualLogSource Log;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("CodeQuality", "IDE0051:Remove unused private members", Justification = "N/A")]
        private void Awake()
        {
            Log = Logger;
            SprintInvertEnabled = Config.Bind("General", "SprintInvertEnabled", true);
            TapToggleEnabled = Config.Bind("General", "TapToggleEnabled", false);
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MyPluginInfo.PLUGIN_GUID);
            Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        }

        internal static ConfigEntry<bool> SprintInvertEnabled;
        internal static ConfigEntry<bool> TapToggleEnabled;
    }
}