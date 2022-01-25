using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float sceneLoadDelay = 2f;

    void Start()
    {
        Invoke("LoadFirstScene", sceneLoadDelay);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
