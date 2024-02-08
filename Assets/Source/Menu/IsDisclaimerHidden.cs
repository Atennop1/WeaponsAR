using System;

namespace WeaponsAR.Menu
{
    [Serializable]
    public struct IsDisclaimerHidden
    {
        public bool Value;

        public IsDisclaimerHidden(bool value)
            => Value = value;
    }
}