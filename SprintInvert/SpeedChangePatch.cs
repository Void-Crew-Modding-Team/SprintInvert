using HarmonyLib;
using Opsive.UltimateCharacterController.Character.Abilities;

namespace SprintInvert
{
    [HarmonyPatch(typeof(SpeedChange), "Update")]
    internal class SpeedChangePatch
    {
        static void Postfix(ref float ___m_SpeedChangeMultiplier)
        {
            ___m_SpeedChangeMultiplier = 1 / 1.7f;
        }
    }
}
