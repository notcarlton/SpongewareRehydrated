using UnityEngine;

namespace SpongewareRehydrated
{
    public class Loader
    {
        private static GameObject _gameObject;

        public static void Load()
        {
            _gameObject = new GameObject();
            _gameObject.AddComponent<Main>();
            Object.DontDestroyOnLoad(_gameObject);
        }

        public static void Unload()
        {
            Object.Destroy(_gameObject);
        }
    }
}