using VoidManager.CustomGUI;
using static UnityEngine.GUILayout;

namespace SprintInvert
{
    internal class GUI : ModSettingsMenu
    {
        public override string Name()
        {
            return "Sprint Inverted: " + BepinPlugin.SprintInvertEnabled.Value;
        }

        public override void Draw()
        {
            if (Button("Sprint Inverted: " + BepinPlugin.SprintInvertEnabled.Value))
            {
                BepinPlugin.SprintInvertEnabled.Value = !BepinPlugin.SprintInvertEnabled.Value;
            }
            if (Button("Tap Toggle: " + (BepinPlugin.TapToggleEnabled.Value ? "Enabled" : "Disabled")))
            {
                BepinPlugin.TapToggleEnabled.Value = !BepinPlugin.TapToggleEnabled.Value;
            }
        }
    }
}
