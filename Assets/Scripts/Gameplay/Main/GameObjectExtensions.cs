using UnityEngine;

namespace Gameplay.Main
{
    public static class GameObjectExtensions
    {
        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            if(gameObject.TryGetComponent<T>(out var t))
            { 
                return t;
            }
            return gameObject.AddComponent<T>();
        }
    }
}
