using HarmonyLib;
using Opsive.UltimateCharacterController.Character.Abilities;
using System.Reflection;

namespace SprintInvert
{
    [HarmonyPatch(typeof(SpeedChangeToggle), "OnInputSpeedChangeRelease")]
    internal class TapTogglePatch
    {
        static MethodInfo StopRunningMI = AccessTools.Method(typeof(SpeedChangeToggle), "StopRunning");

        static void Postfix(SpeedChangeToggle __instance)
        {
            //Calls StopRunning. Could run twice due to vanilla calling it, but that's not an issue.
            if(!BepinPlugin.TapToggleEnabled.Value)
            {
                StopRunningMI.Invoke(__instance, null);
            }
        }
    }
}
