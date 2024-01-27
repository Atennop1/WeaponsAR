using System;
using System.IO;
using UnityEngine;
using WeaponsAR.Saving.Paths;

namespace WeaponsAR.Saving
{
    public sealed class JsonStorage<TStoreValue> : ISaveStorage<TStoreValue>
    {
        private readonly string _pathName;

        public JsonStorage(IPath path)
        {
            if (path is null)
                throw new ArgumentNullException(nameof(path));

            _pathName = path.Name;
        }

        public bool HasSave() 
            => File.Exists(_pathName);

        public TStoreValue Load()
        {
            if (HasSave() == false)
                throw new InvalidOperationException($"Hasn't save with path: {_pathName}");
            
            var saveJson = File.ReadAllText(_pathName);
            return JsonUtility.FromJson<TStoreValue>(saveJson);
        }

        public void Save(TStoreValue value)
        {
            var saveJson = JsonUtility.ToJson(value);
            File.WriteAllText(_pathName, saveJson);
        }
        
        public void DeleteSave()
        {
            if (HasSave() == false)
                throw new InvalidOperationException($"Hasn't save with path: {_pathName}. You can't delete save!");
            
            File.Delete(_pathName);
        }
    }
}