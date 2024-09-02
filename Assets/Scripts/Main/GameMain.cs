using System.Collections;
using UnityEngine;

public class GameMain : MonoBehaviour
{
    private void Start()
    {
        ReCreateSingleton();
    }

    private void ReCreateSingleton()
    {
        Global.ReCreate();
        ResourceManager.ReCreate();
    }
}