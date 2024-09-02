using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

public class ResourceManager : Singleton<ResourceManager>
{
    public T LoadAsset<T>(string assetPath)
        where T : UnityEngine.Object
    {
        return default(T);
    }

    public async UniTask<T> LoadAssetAsync<T>(string assetPath, CancellationToken cancelToken = default(CancellationToken))
        where T : UnityEngine.Object
    {
        T result = null;
        return null;
    }
}