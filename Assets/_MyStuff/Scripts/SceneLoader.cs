using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader Instance; 
    public string TrackScene = "_Main scene";

    private void Awake()
    {
        Instance = this;
    }
    //Probably to long method names below
    public void StartAsyncSceneButtonPressed()
    {
        SceneManager.LoadSceneAsync("1_Main scene");
    }
    public void LoadSAsyncSceneButtonPressed(int sceneNumber)
    {
        string sceneName = sceneNumber.ToString();  
        SceneManager.LoadSceneAsync(sceneName + TrackScene);
    }

}