using System;
using System.IO;
using UnityEngine;

namespace Weapons.Saving.Paths
{
    public sealed class Path : IPath
    {
        private readonly string _savesFolder = System.IO.Path.Combine(Application.persistentDataPath, "Saves");

        public Path(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (!Directory.Exists(_savesFolder)) 
                Directory.CreateDirectory(_savesFolder);

            Name = System.IO.Path.Combine(Application.persistentDataPath, _savesFolder, name);
        }

        public string Name { get; }
    }
}