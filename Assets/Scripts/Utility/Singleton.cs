using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance = null;
    public static T Instance
    {
        get
        {
            if (_instance == null)
                ReCreate();

            return _instance;
        }
    }

    public static void ReCreate()
    {
        if (_instance != null)
            DestroyImmediate(_instance.gameObject);

        var go = new GameObject(StringUtil.Format("{0}_singleton", nameof(T)));
        _instance = go.AddComponent<T>();
        if (_instance != null)
            DontDestroyOnLoad(go);
    }
}