using System.Collections;
using UnityEngine;
using System;
using UnityEngine.AddressableAssets;

public class AddrLoadScene : MonoBehaviour
{
    public string SceneAddr = "";

    public void DoLoadScene()
    {
        StartCoroutine(LoadSceneAsync());
    }

    private IEnumerator LoadSceneAsync()
    {
        Debug.Log("Loading Scene: " + SceneAddr);
        yield return Addressables.LoadSceneAsync(SceneAddr);
        Debug.Log("Scene Loaded: " + SceneAddr);
    }
}
