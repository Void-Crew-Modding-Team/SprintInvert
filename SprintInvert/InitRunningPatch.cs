using HarmonyLib;
using Opsive.UltimateCharacterController.Character.Abilities;
using System.Reflection;

namespace SprintInvert
{
    [HarmonyPatch(typeof(SpeedChangeToggle), "Start")]
    internal class InitRunningPatch
    {
        static MethodInfo StopRunningMI = AccessTools.Method(typeof(SpeedChangeToggle), "StopRunning");
        static void Postfix(SpeedChangeToggle __instance)
        {
            //Stop running when first started, should set current running state to the inverted state.
            StopRunningMI.Invoke(__instance, null);
        }
    }
}
