using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] int waitTime = 4;
    int sceneIndex;
    void Start()
    {
       
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(sceneIndex == 0)
        {
            StartCoroutine(SplashSceneCoroutine());
        }       
    }

    IEnumerator SplashSceneCoroutine()
    {
        yield return new WaitForSeconds(4);
        LoadNextScene();
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(sceneIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
