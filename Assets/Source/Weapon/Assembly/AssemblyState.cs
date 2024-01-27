using System;

namespace WeaponsAR.Weapon
{
    [Serializable]
    public struct AssemblyState
    {
        public string Description;

        public AssemblyState(string description) 
            => Description = description ?? throw new ArgumentNullException(nameof(description));
    }
}