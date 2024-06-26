﻿using VoidManager.MPModChecks;

namespace SprintInvert
{
    public class VoidManagerPlugin : VoidManager.VoidPlugin
    {
        public override MultiplayerType MPType => MultiplayerType.Client;

        public override string Author => "18107, Dragon";

        public override string Description => "Inverts sprint keybind. Client-Side.";
    }
}
