using System;

namespace WeaponsAR.Camera
{
    [Serializable]
    public struct FlashlightState
    {
        public bool Value;

        public FlashlightState(bool value)
            => Value = value;
    }
}