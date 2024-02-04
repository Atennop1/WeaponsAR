using System;

namespace WeaponsAR.Weapon
{
    public struct AssemblyState
    {
        public readonly string Description;

        public AssemblyState(string description) 
            => Description = description ?? throw new ArgumentNullException(nameof(description));
    }
}