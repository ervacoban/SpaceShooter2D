using UnityEngine;

namespace Gameplay.Main
{
    public abstract class Singleton<T> : MonoBehaviour where T : Component
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance != null)
                {
                    return _instance;
                }
                
                _instance = FindObjectOfType<T>();
                
                if (_instance != null)
                {
                    return _instance;
                }
                
                var obj = new GameObject
                {
                    name = typeof(T).Name + " (Singleton)"
                };
                _instance = obj.AddComponent<T>();

                return _instance;
            }
        }

        protected virtual void Awake()
        {
            if (_instance is null)
            {
                _instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
