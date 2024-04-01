using HarmonyLib;
using Opsive.UltimateCharacterController.Character.Abilities;

namespace SprintInvert
{
    [HarmonyPatch(typeof(SpeedChangeToggle), "ChangeActiveState")]
    class ToggleStatePatch
    {
        static void Prefix(ref bool active)
        {
            //Inversion!
            if (BepinPlugin.SprintInvertEnabled.Value)
            {
                active = !active;
            }
        }
    }
}
