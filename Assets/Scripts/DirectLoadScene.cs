using System.Collections;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class DirectLoadScene : MonoBehaviour
{
    public string SceneName = "";

    public void DoLoadScene()
    {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Single);
    }
}
