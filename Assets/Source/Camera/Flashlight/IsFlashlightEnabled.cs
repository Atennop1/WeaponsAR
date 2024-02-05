using System;

namespace WeaponsAR.Camera
{
    [Serializable]
    public struct IsFlashlightEnabled
    {
        public bool Value;

        public IsFlashlightEnabled(bool value)
            => Value = value;
    }
}