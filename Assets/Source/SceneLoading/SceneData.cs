using UnityEngine;

namespace WeaponsAR.SceneLoading
{
    [CreateAssetMenu(fileName = "Scene", menuName = "Scene Data")]
    public sealed class SceneData : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
    }
}