using System;

namespace WeaponsAR.Sound
{
    [Serializable]
    public struct Volume
    {
        public float Value;

        public Volume(float value)
            => Value = value;
    }
}