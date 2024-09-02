using System.Security.Cryptography;
using UnityEngine;

public class SingletonMono<T> : MonoBehaviour where T : MonoBehaviour
{
    private static SingletonMono<T> _instance = null;
    public static SingletonMono<T> Instance { get => _instance; }

    protected virtual void Awake()
    {
        if (FindObjectsByType<SingletonMono<T>>(FindObjectsSortMode.None) != null)
        {
            DestroyImmediate(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    }
}