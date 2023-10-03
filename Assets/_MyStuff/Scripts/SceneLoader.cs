using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string StartSceneName;
    void Start()
    {

    }

    
    void Update()
    {
        
    }

    public void StartButtonPressed()
    {
        SceneManager.LoadScene(StartSceneName);
    }
}