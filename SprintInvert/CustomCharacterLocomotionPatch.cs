using HarmonyLib;

namespace SprintInvert
{
    [HarmonyPatch(typeof(CustomCharacterLocomotion), "Move")]
    internal class CustomCharacterLocomotionPatch
    {
        static void Prefix(ref float horizontalMovement, ref float forwardMovement)
        {
            horizontalMovement *= 1.7f;
            forwardMovement *= 1.7f;
        }
    }
}
